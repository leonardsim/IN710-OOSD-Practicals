namespace ZoologicalSim
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
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.btnNA = new System.Windows.Forms.Button();
            this.btnAUS = new System.Windows.Forms.Button();
            this.btnAsia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.Location = new System.Drawing.Point(120, 13);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(351, 277);
            this.lbAnimals.TabIndex = 4;
            // 
            // btnNA
            // 
            this.btnNA.Location = new System.Drawing.Point(120, 298);
            this.btnNA.Name = "btnNA";
            this.btnNA.Size = new System.Drawing.Size(113, 121);
            this.btnNA.TabIndex = 5;
            this.btnNA.Text = "North America";
            this.btnNA.UseVisualStyleBackColor = true;
            this.btnNA.Click += new System.EventHandler(this.btnNA_Click);
            // 
            // btnAUS
            // 
            this.btnAUS.Location = new System.Drawing.Point(239, 298);
            this.btnAUS.Name = "btnAUS";
            this.btnAUS.Size = new System.Drawing.Size(113, 121);
            this.btnAUS.TabIndex = 6;
            this.btnAUS.Text = "Australia";
            this.btnAUS.UseVisualStyleBackColor = true;
            this.btnAUS.Click += new System.EventHandler(this.btnAUS_Click);
            // 
            // btnAsia
            // 
            this.btnAsia.Location = new System.Drawing.Point(358, 298);
            this.btnAsia.Name = "btnAsia";
            this.btnAsia.Size = new System.Drawing.Size(113, 121);
            this.btnAsia.TabIndex = 7;
            this.btnAsia.Text = "Asia";
            this.btnAsia.UseVisualStyleBackColor = true;
            this.btnAsia.Click += new System.EventHandler(this.btnAsia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 431);
            this.Controls.Add(this.btnAsia);
            this.Controls.Add(this.btnAUS);
            this.Controls.Add(this.btnNA);
            this.Controls.Add(this.lbAnimals);
            this.Name = "Form1";
            this.Text = "Animal World";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAnimals;
        private System.Windows.Forms.Button btnNA;
        private System.Windows.Forms.Button btnAUS;
        private System.Windows.Forms.Button btnAsia;
    }
}

