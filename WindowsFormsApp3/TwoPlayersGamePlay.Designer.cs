namespace StupidGame {
    partial class TwoPlayersGamePlay {
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
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.panelP2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Name.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPlayer2Name.Location = new System.Drawing.Point(443, 117);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(222, 33);
            this.lblPlayer2Name.TabIndex = 0;
            this.lblPlayer2Name.Text = "lblPlayer2Name";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.BackColor = System.Drawing.Color.Transparent;
            this.lbls.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls.Location = new System.Drawing.Point(443, 160);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(99, 33);
            this.lbls.TabIndex = 1;
            this.lbls.Text = "Score:";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.Transparent;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.Location = new System.Drawing.Point(527, 160);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(137, 33);
            this.lblScore2.TabIndex = 2;
            this.lblScore2.Text = "lblScore2";
            // 
            // panelP2
            // 
            this.panelP2.Location = new System.Drawing.Point(439, 115);
            this.panelP2.Name = "panelP2";
            this.panelP2.Size = new System.Drawing.Size(339, 86);
            this.panelP2.TabIndex = 11;
            // 
            // TwoPlayersGamePlay
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.panelP2);
            this.Name = "TwoPlayersGamePlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Panel panelP2;
    }
}
