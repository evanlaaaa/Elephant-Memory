namespace StupidGame {
    partial class OnePlayerGamePlay {
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
            this.panelTimer = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.panelTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTimer
            // 
            this.panelTimer.Controls.Add(this.lblTime);
            this.panelTimer.Controls.Add(this.txtTime);
            this.panelTimer.Location = new System.Drawing.Point(440, 98);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(339, 50);
            this.panelTimer.TabIndex = 12;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(168, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(87, 33);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.BackColor = System.Drawing.Color.Transparent;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(0, 8);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(178, 33);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "Time Taken:";
            // 
            // OnePlayerGamePlay
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelTimer);
            this.Name = "OnePlayerGamePlay";
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label txtTime;
    }
}
