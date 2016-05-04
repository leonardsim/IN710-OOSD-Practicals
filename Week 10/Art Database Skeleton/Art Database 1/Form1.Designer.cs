namespace Art_Database_1
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
            this.btnAllPaintings = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnItaly = new System.Windows.Forms.Button();
            this.btnBefore1800 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnOldest = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnNbyCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAllPaintings
            // 
            this.btnAllPaintings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPaintings.Location = new System.Drawing.Point(29, 16);
            this.btnAllPaintings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllPaintings.Name = "btnAllPaintings";
            this.btnAllPaintings.Size = new System.Drawing.Size(201, 31);
            this.btnAllPaintings.TabIndex = 0;
            this.btnAllPaintings.Text = "All Paintings";
            this.btnAllPaintings.UseVisualStyleBackColor = true;
            this.btnAllPaintings.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(29, 256);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1245, 445);
            this.listBox1.TabIndex = 1;
            // 
            // btnItaly
            // 
            this.btnItaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItaly.Location = new System.Drawing.Point(29, 53);
            this.btnItaly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnItaly.Name = "btnItaly";
            this.btnItaly.Size = new System.Drawing.Size(201, 31);
            this.btnItaly.TabIndex = 2;
            this.btnItaly.Text = "Artists from Italy";
            this.btnItaly.UseVisualStyleBackColor = true;
            this.btnItaly.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBefore1800
            // 
            this.btnBefore1800.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBefore1800.Location = new System.Drawing.Point(29, 90);
            this.btnBefore1800.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBefore1800.Name = "btnBefore1800";
            this.btnBefore1800.Size = new System.Drawing.Size(201, 31);
            this.btnBefore1800.TabIndex = 3;
            this.btnBefore1800.Text = "Paintings Before 1800";
            this.btnBefore1800.UseVisualStyleBackColor = true;
            this.btnBefore1800.Click += new System.EventHandler(this.btnBefore1800_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(536, 127);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(375, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "All Paintings with Artist and Artist\'s Country";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnOldest
            // 
            this.btnOldest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOldest.Location = new System.Drawing.Point(29, 127);
            this.btnOldest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOldest.Name = "btnOldest";
            this.btnOldest.Size = new System.Drawing.Size(201, 31);
            this.btnOldest.TabIndex = 5;
            this.btnOldest.Text = "Oldest Painting";
            this.btnOldest.UseVisualStyleBackColor = true;
            this.btnOldest.Click += new System.EventHandler(this.btnOldest_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(29, 164);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(201, 31);
            this.button6.TabIndex = 6;
            this.button6.Text = "Painted by:";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(244, 166);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Raphael";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(536, 90);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(375, 31);
            this.button7.TabIndex = 8;
            this.button7.Text = "Paintings by Dutch Painters";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(536, 53);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(375, 31);
            this.button8.TabIndex = 9;
            this.button8.Text = "Artists Grouped  by Country";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(536, 164);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(375, 31);
            this.button9.TabIndex = 10;
            this.button9.Text = "Paintings by French or Italian Painters";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnNbyCountry
            // 
            this.btnNbyCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNbyCountry.Location = new System.Drawing.Point(536, 16);
            this.btnNbyCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNbyCountry.Name = "btnNbyCountry";
            this.btnNbyCountry.Size = new System.Drawing.Size(375, 31);
            this.btnNbyCountry.TabIndex = 11;
            this.btnNbyCountry.Text = "Number of Paintings from each Country";
            this.btnNbyCountry.UseVisualStyleBackColor = true;
            this.btnNbyCountry.Click += new System.EventHandler(this.btnNbyCountry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 730);
            this.Controls.Add(this.btnNbyCountry);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnOldest);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnBefore1800);
            this.Controls.Add(this.btnItaly);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAllPaintings);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Art Collection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllPaintings;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnItaly;
        private System.Windows.Forms.Button btnBefore1800;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnOldest;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnNbyCountry;
    }
}

