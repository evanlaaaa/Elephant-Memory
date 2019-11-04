namespace StupidGame {
    partial class menu {
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
            this.btnScore = new System.Windows.Forms.PictureBox();
            this.btn2p = new System.Windows.Forms.PictureBox();
            this.btn1p = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn1p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.Transparent;
            this.btnScore.BackgroundImage = global::StupidGame.Properties.Resources.sb;
            this.btnScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScore.Location = new System.Drawing.Point(202, 351);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(380, 66);
            this.btnScore.TabIndex = 6;
            this.btnScore.TabStop = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            this.btnScore.MouseEnter += new System.EventHandler(this.btnScore_MouseEnter);
            this.btnScore.MouseLeave += new System.EventHandler(this.btnScore_MouseLeave);
            // 
            // btn2p
            // 
            this.btn2p.BackColor = System.Drawing.Color.Transparent;
            this.btn2p.BackgroundImage = global::StupidGame.Properties.Resources.twop;
            this.btn2p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2p.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2p.Location = new System.Drawing.Point(202, 269);
            this.btn2p.Name = "btn2p";
            this.btn2p.Size = new System.Drawing.Size(380, 66);
            this.btn2p.TabIndex = 5;
            this.btn2p.TabStop = false;
            this.btn2p.Click += new System.EventHandler(this.btn2p_Click);
            this.btn2p.MouseEnter += new System.EventHandler(this.btn2p_MouseEnter);
            this.btn2p.MouseLeave += new System.EventHandler(this.btn2p_MouseLeave);
            // 
            // btn1p
            // 
            this.btn1p.BackColor = System.Drawing.Color.Transparent;
            this.btn1p.BackgroundImage = global::StupidGame.Properties.Resources.onep;
            this.btn1p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1p.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1p.Location = new System.Drawing.Point(202, 187);
            this.btn1p.Name = "btn1p";
            this.btn1p.Size = new System.Drawing.Size(380, 66);
            this.btn1p.TabIndex = 4;
            this.btn1p.TabStop = false;
            this.btn1p.Click += new System.EventHandler(this.btn1p_Click);
            this.btn1p.MouseEnter += new System.EventHandler(this.btn1p_MouseEnter);
            this.btn1p.MouseLeave += new System.EventHandler(this.btn1p_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::StupidGame.Properties.Resources.title;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(64, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 104);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::StupidGame.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(318, 423);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 94);
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StupidGame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btn2p);
            this.Controls.Add(this.btn1p);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.btnScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn1p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btn1p;
        private System.Windows.Forms.PictureBox btn2p;
        private System.Windows.Forms.PictureBox btnScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnExit;
    }
}

