namespace FireAlarm
{
    partial class Form1
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
            this.btnAlarm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoMinor = new System.Windows.Forms.RadioButton();
            this.rdoSerious = new System.Windows.Forms.RadioButton();
            this.rdoInferno = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlarm
            // 
            this.btnAlarm.Location = new System.Drawing.Point(10, 163);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(171, 47);
            this.btnAlarm.TabIndex = 0;
            this.btnAlarm.Text = "Fire Alarm";
            this.btnAlarm.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoInferno);
            this.groupBox1.Controls.Add(this.rdoSerious);
            this.groupBox1.Controls.Add(this.rdoMinor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fire Category";
            // 
            // rdoMinor
            // 
            this.rdoMinor.AutoSize = true;
            this.rdoMinor.Location = new System.Drawing.Point(7, 29);
            this.rdoMinor.Name = "rdoMinor";
            this.rdoMinor.Size = new System.Drawing.Size(79, 29);
            this.rdoMinor.TabIndex = 0;
            this.rdoMinor.TabStop = true;
            this.rdoMinor.Text = "Minor";
            this.rdoMinor.UseVisualStyleBackColor = true;
            // 
            // rdoSerious
            // 
            this.rdoSerious.AutoSize = true;
            this.rdoSerious.Location = new System.Drawing.Point(6, 64);
            this.rdoSerious.Name = "rdoSerious";
            this.rdoSerious.Size = new System.Drawing.Size(97, 29);
            this.rdoSerious.TabIndex = 1;
            this.rdoSerious.TabStop = true;
            this.rdoSerious.Text = "Serious";
            this.rdoSerious.UseVisualStyleBackColor = true;
            // 
            // rdoInferno
            // 
            this.rdoInferno.AutoSize = true;
            this.rdoInferno.Location = new System.Drawing.Point(7, 99);
            this.rdoInferno.Name = "rdoInferno";
            this.rdoInferno.Size = new System.Drawing.Size(90, 29);
            this.rdoInferno.TabIndex = 2;
            this.rdoInferno.TabStop = true;
            this.rdoInferno.Text = "Inferno";
            this.rdoInferno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 220);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAlarm);
            this.Name = "Form1";
            this.Text = "Fire Alarm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoInferno;
        private System.Windows.Forms.RadioButton rdoSerious;
        private System.Windows.Forms.RadioButton rdoMinor;
    }
}

