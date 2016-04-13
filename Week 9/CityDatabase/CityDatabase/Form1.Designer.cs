namespace CityDatabase
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
            this.lbCities = new System.Windows.Forms.ListBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCities
            // 
            this.lbCities.FormattingEnabled = true;
            this.lbCities.Location = new System.Drawing.Point(201, 13);
            this.lbCities.Name = "lbCities";
            this.lbCities.Size = new System.Drawing.Size(228, 264);
            this.lbCities.TabIndex = 1;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(13, 29);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(182, 21);
            this.cbCountry.TabIndex = 2;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(13, 253);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(182, 23);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display Cities";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Countries:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lbCities);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCities;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label1;
    }
}

