namespace StupidGame {
    partial class ScoreBoard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.plBackground = new System.Windows.Forms.Panel();
            this.pbChart = new System.Windows.Forms.PictureBox();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pb2p = new System.Windows.Forms.PictureBox();
            this.pb1pHard = new System.Windows.Forms.PictureBox();
            this.pb1pEasy = new System.Windows.Forms.PictureBox();
            this.plBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1pHard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1pEasy)).BeginInit();
            this.SuspendLayout();
            // 
            // plBackground
            // 
            this.plBackground.Controls.Add(this.pbChart);
            this.plBackground.Controls.Add(this.pbMenu);
            this.plBackground.Controls.Add(this.pb2p);
            this.plBackground.Controls.Add(this.pb1pHard);
            this.plBackground.Controls.Add(this.pb1pEasy);
            this.plBackground.Location = new System.Drawing.Point(12, 12);
            this.plBackground.Name = "plBackground";
            this.plBackground.Size = new System.Drawing.Size(760, 537);
            this.plBackground.TabIndex = 0;
            // 
            // pbChart
            // 
            this.pbChart.BackColor = System.Drawing.Color.Transparent;
            this.pbChart.BackgroundImage = global::StupidGame.Properties.Resources.coollogo_com_69431;
            this.pbChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbChart.Location = new System.Drawing.Point(670, 489);
            this.pbChart.Name = "pbChart";
            this.pbChart.Size = new System.Drawing.Size(87, 46);
            this.pbChart.TabIndex = 4;
            this.pbChart.TabStop = false;
            this.pbChart.Click += new System.EventHandler(this.pbChart_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.Transparent;
            this.pbMenu.BackgroundImage = global::StupidGame.Properties.Resources.menu;
            this.pbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMenu.Location = new System.Drawing.Point(271, 503);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(213, 31);
            this.pbMenu.TabIndex = 3;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // pb2p
            // 
            this.pb2p.BackColor = System.Drawing.Color.Transparent;
            this.pb2p.BackgroundImage = global::StupidGame.Properties.Resources.sbp2;
            this.pb2p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2p.Location = new System.Drawing.Point(520, 17);
            this.pb2p.Name = "pb2p";
            this.pb2p.Size = new System.Drawing.Size(213, 36);
            this.pb2p.TabIndex = 2;
            this.pb2p.TabStop = false;
            this.pb2p.Click += new System.EventHandler(this.pb2p_Click);
            // 
            // pb1pHard
            // 
            this.pb1pHard.BackColor = System.Drawing.Color.Transparent;
            this.pb1pHard.BackgroundImage = global::StupidGame.Properties.Resources.sbp1h;
            this.pb1pHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1pHard.Location = new System.Drawing.Point(271, 17);
            this.pb1pHard.Name = "pb1pHard";
            this.pb1pHard.Size = new System.Drawing.Size(213, 36);
            this.pb1pHard.TabIndex = 1;
            this.pb1pHard.TabStop = false;
            this.pb1pHard.Click += new System.EventHandler(this.pb1pHard_Click);
            // 
            // pb1pEasy
            // 
            this.pb1pEasy.BackColor = System.Drawing.Color.Transparent;
            this.pb1pEasy.BackgroundImage = global::StupidGame.Properties.Resources.sbp1e;
            this.pb1pEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1pEasy.Location = new System.Drawing.Point(21, 17);
            this.pb1pEasy.Name = "pb1pEasy";
            this.pb1pEasy.Size = new System.Drawing.Size(213, 36);
            this.pb1pEasy.TabIndex = 0;
            this.pb1pEasy.TabStop = false;
            this.pb1pEasy.Click += new System.EventHandler(this.pb1pEasy_Click);
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StupidGame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.plBackground);
            this.Name = "ScoreBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreBoard";
            this.plBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1pHard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1pEasy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plBackground;
        private System.Windows.Forms.PictureBox pb1pEasy;
        private System.Windows.Forms.PictureBox pb2p;
        private System.Windows.Forms.PictureBox pb1pHard;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.PictureBox pbChart;
    }
}