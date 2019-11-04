namespace StupidGame
{
    partial class dialogGameSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCar = new System.Windows.Forms.RadioButton();
            this.rbAnimal = new System.Windows.Forms.RadioButton();
            this.btnSettingOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Controls.Add(this.rbEasy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(20, 56);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(74, 17);
            this.rbNormal.TabIndex = 1;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Hard (6x6)";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Location = new System.Drawing.Point(20, 32);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(74, 17);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy (4x4)";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCar);
            this.groupBox2.Controls.Add(this.rbAnimal);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Theme";
            // 
            // rbCar
            // 
            this.rbCar.AutoSize = true;
            this.rbCar.Location = new System.Drawing.Point(20, 56);
            this.rbCar.Name = "rbCar";
            this.rbCar.Size = new System.Drawing.Size(56, 17);
            this.rbCar.TabIndex = 1;
            this.rbCar.TabStop = true;
            this.rbCar.Text = "Shape";
            this.rbCar.UseVisualStyleBackColor = true;
            // 
            // rbAnimal
            // 
            this.rbAnimal.AutoSize = true;
            this.rbAnimal.Checked = true;
            this.rbAnimal.Location = new System.Drawing.Point(20, 32);
            this.rbAnimal.Name = "rbAnimal";
            this.rbAnimal.Size = new System.Drawing.Size(45, 17);
            this.rbAnimal.TabIndex = 0;
            this.rbAnimal.TabStop = true;
            this.rbAnimal.Text = "Fruit";
            this.rbAnimal.UseVisualStyleBackColor = true;
            // 
            // btnSettingOK
            // 
            this.btnSettingOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSettingOK.Location = new System.Drawing.Point(149, 216);
            this.btnSettingOK.Name = "btnSettingOK";
            this.btnSettingOK.Size = new System.Drawing.Size(75, 23);
            this.btnSettingOK.TabIndex = 3;
            this.btnSettingOK.Text = "OK";
            this.btnSettingOK.UseVisualStyleBackColor = true;
            this.btnSettingOK.Click += new System.EventHandler(this.btnSettingOK_Click);
            // 
            // dialogGameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 246);
            this.ControlBox = false;
            this.Controls.Add(this.btnSettingOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "dialogGameSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCar;
        private System.Windows.Forms.RadioButton rbAnimal;
        private System.Windows.Forms.Button btnSettingOK;
    }
}