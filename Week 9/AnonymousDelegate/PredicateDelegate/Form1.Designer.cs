namespace PredicateDelegate
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
            this.btnRand = new System.Windows.Forms.Button();
            this.btnOdd = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.lbRand = new System.Windows.Forms.ListBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRand
            // 
            this.btnRand.Location = new System.Drawing.Point(13, 13);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(146, 35);
            this.btnRand.TabIndex = 0;
            this.btnRand.Text = "Generate Random ";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.btnRand_Click);
            // 
            // btnOdd
            // 
            this.btnOdd.Location = new System.Drawing.Point(257, 13);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(146, 35);
            this.btnOdd.TabIndex = 1;
            this.btnOdd.Text = "Select Odd Numbers";
            this.btnOdd.UseVisualStyleBackColor = true;
            this.btnOdd.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(257, 54);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(146, 35);
            this.btnTen.TabIndex = 2;
            this.btnTen.Text = "Select Numbers < 10";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // lbRand
            // 
            this.lbRand.FormattingEnabled = true;
            this.lbRand.Location = new System.Drawing.Point(13, 106);
            this.lbRand.Name = "lbRand";
            this.lbRand.Size = new System.Drawing.Size(186, 212);
            this.lbRand.TabIndex = 3;
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(217, 106);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(186, 212);
            this.lbResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 336);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbRand);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnOdd);
            this.Controls.Add(this.btnRand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.ListBox lbRand;
        private System.Windows.Forms.ListBox lbResult;
    }
}

