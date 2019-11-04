namespace StupidGame {
    partial class gamePlay {
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
            this.components = new System.ComponentModel.Container();
            this.timerCloseCard = new System.Windows.Forms.Timer(this.components);
            this.animateOpening = new System.Windows.Forms.Timer(this.components);
            this.animateClosing = new System.Windows.Forms.Timer(this.components);
            this.animateCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblTextScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbCardsBackground = new System.Windows.Forms.PictureBox();
            this.panelP1 = new System.Windows.Forms.Panel();
            this.panelBtnBack = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnRule = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardsBackground)).BeginInit();
            this.panelBtnBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRule)).BeginInit();
            this.SuspendLayout();
            // 
            // animateOpening
            // 
            this.animateOpening.Interval = 200;
            this.animateOpening.Tick += new System.EventHandler(this.animateOpening_Tick);
            // 
            // animateClosing
            // 
            this.animateClosing.Interval = 200;
            this.animateClosing.Tick += new System.EventHandler(this.animateClosing_Tick);
            // 
            // animateCloseTimer
            // 
            this.animateCloseTimer.Interval = 2000;
            this.animateCloseTimer.Tick += new System.EventHandler(this.animateCloseTimer_Tick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(432, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 900);
            this.label1.TabIndex = 0;
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPlayer1Name.Location = new System.Drawing.Point(440, 9);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(222, 33);
            this.lblPlayer1Name.TabIndex = 2;
            this.lblPlayer1Name.Text = "lblPlayer1Name";
            // 
            // lblTextScore
            // 
            this.lblTextScore.AutoSize = true;
            this.lblTextScore.BackColor = System.Drawing.Color.Transparent;
            this.lblTextScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextScore.Location = new System.Drawing.Point(440, 51);
            this.lblTextScore.Name = "lblTextScore";
            this.lblTextScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTextScore.Size = new System.Drawing.Size(99, 33);
            this.lblTextScore.TabIndex = 3;
            this.lblTextScore.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(523, 53);
            this.lblScore.Name = "lblScore";
            this.lblScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblScore.Size = new System.Drawing.Size(121, 33);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "lblScore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 763);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(661, 716);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // pbCardsBackground
            // 
            this.pbCardsBackground.BackgroundImage = global::StupidGame.Properties.Resources.test;
            this.pbCardsBackground.Location = new System.Drawing.Point(7, 9);
            this.pbCardsBackground.Name = "pbCardsBackground";
            this.pbCardsBackground.Size = new System.Drawing.Size(419, 540);
            this.pbCardsBackground.TabIndex = 9;
            this.pbCardsBackground.TabStop = false;
            // 
            // panelP1
            // 
            this.panelP1.Location = new System.Drawing.Point(440, 5);
            this.panelP1.Name = "panelP1";
            this.panelP1.Size = new System.Drawing.Size(339, 86);
            this.panelP1.TabIndex = 10;
            // 
            // panelBtnBack
            // 
            this.panelBtnBack.Controls.Add(this.btnMenu);
            this.panelBtnBack.Controls.Add(this.btnRule);
            this.panelBtnBack.Location = new System.Drawing.Point(432, 497);
            this.panelBtnBack.Name = "panelBtnBack";
            this.panelBtnBack.Size = new System.Drawing.Size(353, 65);
            this.panelBtnBack.TabIndex = 11;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = global::StupidGame.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Location = new System.Drawing.Point(148, 15);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(196, 40);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnExit_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // btnRule
            // 
            this.btnRule.BackColor = System.Drawing.Color.Transparent;
            this.btnRule.BackgroundImage = global::StupidGame.Properties.Resources.rule;
            this.btnRule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRule.Location = new System.Drawing.Point(11, 14);
            this.btnRule.Name = "btnRule";
            this.btnRule.Size = new System.Drawing.Size(96, 40);
            this.btnRule.TabIndex = 0;
            this.btnRule.TabStop = false;
            this.btnRule.Click += new System.EventHandler(this.btnRule_Click);
            this.btnRule.MouseEnter += new System.EventHandler(this.btnRule_MouseEnter);
            this.btnRule.MouseLeave += new System.EventHandler(this.btnRule_MouseLeave);
            // 
            // gamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StupidGame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTextScore);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCardsBackground);
            this.Controls.Add(this.panelP1);
            this.Controls.Add(this.panelBtnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "gamePlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elephant Memory";
            ((System.ComponentModel.ISupportInitialize)(this.pbCardsBackground)).EndInit();
            this.panelBtnBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Timer timerCloseCard;
        protected System.Windows.Forms.Timer animateOpening;
        protected System.Windows.Forms.Timer animateClosing;
        protected System.Windows.Forms.Timer animateCloseTimer;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label lblPlayer1Name;
        protected System.Windows.Forms.Label lblTextScore;
        protected System.Windows.Forms.Label lblScore;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.PictureBox pbCardsBackground;
        private System.Windows.Forms.Panel panelP1;
        private System.Windows.Forms.Panel panelBtnBack;
        private System.Windows.Forms.PictureBox btnRule;
        private System.Windows.Forms.PictureBox btnMenu;
    }
}