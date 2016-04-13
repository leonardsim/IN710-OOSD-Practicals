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
            this.btnMulti = new System.Windows.Forms.Button();
            this.lbPop = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCities
            // 
            this.lbCities.FormattingEnabled = true;
            this.lbCities.Location = new System.Drawing.Point(201, 26);
            this.lbCities.Name = "lbCities";
            this.lbCities.Size = new System.Drawing.Size(228, 108);
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
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Countries:";
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(13, 224);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(182, 23);
            this.btnMulti.TabIndex = 5;
            this.btnMulti.Text = "Multiply by 3";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // lbPop
            // 
            this.lbPop.FormattingEnabled = true;
            this.lbPop.Location = new System.Drawing.Point(201, 155);
            this.lbPop.Name = "lbPop";
            this.lbPop.Size = new System.Drawing.Size(228, 121);
            this.lbPop.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cities:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Population:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPop);
            this.Controls.Add(this.btnMulti);
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
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.ListBox lbPop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

