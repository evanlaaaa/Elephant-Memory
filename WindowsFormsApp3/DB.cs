using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StupidGame {
    public class DB {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader dr;
        public DB() {
            //establise connection when create instance for db class
            conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ElephantMemory;Integrated Security=True");
        }

        //Save score (single player)
        public void saveScore(Player p, int s, int d, DateTime dt) {
            try {
                int type = (d == 4) ? 1 : 2;
                string query = "INSERT INTO dbo.score (pOne, sOne, Time, Type) VALUES (@p1Name, @s1, @time, @type)";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@p1Name", p.Name);
                command.Parameters.AddWithValue("@s1", p.Score);
                command.Parameters.AddWithValue("@time", Convert.ToDateTime(dt.ToString("HH:mm:ss")));
                command.Parameters.AddWithValue("@type", type);

                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        //Save score (multiplayer)
        public void saveScore(Player p, Player p2, int s, int s2) {
            try {
                //Make the highest score player as p1 for scoreboard
                if(p2.Score > p.Score) {
                    Player temp = p;
                    p = p2;
                    p2 = temp;
                }

                string query = "INSERT INTO dbo.score (pOne, pTwo, sOne, sTwo, Type) VALUES (@p1Name, @p2Name, @s1, @s2, @type)";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@p1Name", p.Name);
                command.Parameters.AddWithValue("@p2Name", p2.Name);
                command.Parameters.AddWithValue("@s1", p.Score);
                command.Parameters.AddWithValue("@s2", p2.Score);
                command.Parameters.AddWithValue("@type", 3);

                conn.Open();
                command.ExecuteNonQuery();
            } 
            catch (Exception ex) {
                throw ex;
            }
            finally {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        //Get top10 performance details based on mode for scoreboard
        public List<string[]> getScoreBoard(int t) {
            try {
                List<string[]> sb = new List<string[]>();
                string[] row;
                string query;
                if(t != 3) query = "SELECT TOP 10 pOne, sOne, Time FROM dbo.score WHERE Type = @type ORDER BY (sOne) DESC, Time ASC";
                else query = "SELECT TOP 10 pOne, pTwo, sOne, sTwo FROM dbo.score WHERE Type = @type ORDER BY (sOne) DESC";

                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@type", t);
                conn.Open();
                dr = command.ExecuteReader();
                if(dr.HasRows) {
                    while(dr.Read()) {
                        if (t != 3) row = new string[] { dr.GetString(0), dr.GetInt32(1).ToString(), dr.GetTimeSpan(2).ToString(@"mm\:ss") };
                        else row = new string[] { dr.GetString(0), dr.GetString(1), dr.GetInt32(2).ToString(), dr.GetInt32(3).ToString() };
                        sb.Add(row);
                    }
                }
                return sb;
            } catch (Exception ex) {
                throw ex;
            }
            finally {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        //Get data to display in graph
        public List<string[]> getChart(int t, string player) {
            
            List<string[]> sb = new List<string[]>();
            string[] row;
            try {
                string p = (player == "") ? "%" : player;
                string query = "SELECT pOne, sOne FROM dbo.score WHERE Type = @type AND pOne LIKE @name";               
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@type", t);
                command.Parameters.AddWithValue("@name", p);
                conn.Open();
                dr = command.ExecuteReader();
                if(dr.HasRows) {
                    while (dr.Read()) {
                        row = new string[] { dr.GetString(0), dr.GetInt32(1).ToString() };
                        sb.Add(row);
                    }
                }
                return sb;
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        //Get all player name who have participated and complete the game for graph combobox
        public List<chart_player> getAllPlayer(int t) {
            List<chart_player> player_set = new List<chart_player>();
            player_set.Add(new chart_player() { Name = "( All )", Value = "%" });
            try {
                string query = "SELECT DISTINCT pOne FROM dbo.score WHERE Type = @type";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@type", t);
                conn.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows) {
                    while (dr.Read()) {
                        player_set.Add(new chart_player() { Name = dr.GetString(0), Value = dr.GetString(0) });
                    }
                }
                return player_set;
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
