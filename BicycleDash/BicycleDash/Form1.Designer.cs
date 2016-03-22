namespace BicycleDash
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRPM = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.lblCalories = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKms = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblRPM);
            this.GroupBox1.Location = new System.Drawing.Point(12, 119);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(414, 130);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "RPM";
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPM.Location = new System.Drawing.Point(157, 48);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(97, 46);
            this.lblRPM.TabIndex = 4;
            this.lblRPM.Text = "0.00";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(272, 44);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(154, 20);
            this.TextBox1.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(204, 47);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Enter RPM:";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(173, 76);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Calculate";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.Location = new System.Drawing.Point(157, 48);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(97, 46);
            this.lblCalories.TabIndex = 4;
            this.lblCalories.Text = "0.00";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lblCalories);
            this.GroupBox2.Location = new System.Drawing.Point(12, 255);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(414, 130);
            this.GroupBox2.TabIndex = 11;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Calories Per Hour";
            // 
            // lblKms
            // 
            this.lblKms.AutoSize = true;
            this.lblKms.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKms.Location = new System.Drawing.Point(157, 48);
            this.lblKms.Name = "lblKms";
            this.lblKms.Size = new System.Drawing.Size(97, 46);
            this.lblKms.TabIndex = 4;
            this.lblKms.Text = "0.00";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.lblKms);
            this.GroupBox3.Location = new System.Drawing.Point(11, 391);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(414, 130);
            this.GroupBox3.TabIndex = 12;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Kms Per Hour";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 533);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblRPM;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label lblCalories;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label lblKms;
        internal System.Windows.Forms.GroupBox GroupBox3;
    }
}

