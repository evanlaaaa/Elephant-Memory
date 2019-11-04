namespace StupidGame
{
    partial class dialogName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNameOK = new System.Windows.Forms.Button();
            this.btnNameCancel = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(10, 19);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(148, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "What is your name? (Player 1)";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnNameOK
            // 
            this.btnNameOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNameOK.Location = new System.Drawing.Point(117, 64);
            this.btnNameOK.Name = "btnNameOK";
            this.btnNameOK.Size = new System.Drawing.Size(75, 23);
            this.btnNameOK.TabIndex = 2;
            this.btnNameOK.Text = "OK";
            this.btnNameOK.UseVisualStyleBackColor = true;
            this.btnNameOK.Click += new System.EventHandler(this.btnNameOK_Click);
            // 
            // btnNameCancel
            // 
            this.btnNameCancel.Location = new System.Drawing.Point(198, 64);
            this.btnNameCancel.Name = "btnNameCancel";
            this.btnNameCancel.Size = new System.Drawing.Size(75, 23);
            this.btnNameCancel.TabIndex = 3;
            this.btnNameCancel.Text = "Cancel";
            this.btnNameCancel.UseVisualStyleBackColor = true;
            this.btnNameCancel.Click += new System.EventHandler(this.btnNameCancel_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(158, 19);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 4;
            // 
            // dialogName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 99);
            this.ControlBox = false;
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnNameCancel);
            this.Controls.Add(this.btnNameOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "dialogName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter your name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnNameOK;
        private System.Windows.Forms.Button btnNameCancel;
        private System.Windows.Forms.Label lblWarning;
    }
}