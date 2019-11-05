using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StupidGame {
    public partial class Chart : Form {
        private DB db;
        private List<string[]> data_pack;
        private int game_type;
        
        public Chart() { }

        public Chart(int t) {
            InitializeComponent();
            db = new DB();
            game_type = t;
            createGraph("");
            fillComboBox();
        }

        public void createGraph(string player) {
            data_pack = db.getChart(game_type, player);
            Dictionary<string, int> map = new Dictionary<string, int>();
            chartPerform.Series.Clear();
            foreach (string[] data in data_pack) {
                if (chartPerform.Series.FindByName(data[0]) == null) {
                    chartPerform.Series.Add(data[0]);
                    chartPerform.Series[data[0]].BorderWidth = 2;
                    chartPerform.Series[data[0]].MarkerStyle = MarkerStyle.Circle;
                    chartPerform.Series[data[0]].MarkerSize = 10;
                    chartPerform.Series[data[0]].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chartPerform.Series[data[0]].Points.AddXY(1, System.Convert.ToInt32(data[1]));
                    map.Add(data[0], 1);
                } else {
                    map[data[0]]++;
                    chartPerform.Series[data[0]].Points.AddXY(map[data[0]], System.Convert.ToInt32(data[1]));
                }
            }
        }

        public void fillComboBox() {
            this.cbPlayer.DataSource = db.getAllPlayer(game_type);
            this.cbPlayer.DisplayMember = "Name";
            this.cbPlayer.ValueMember = "Value";
        }

        private void cbPlayer_SelectedIndexChanged(object sender, EventArgs e) {
            createGraph(cbPlayer.SelectedItem.ToString());
        }
    }
}
