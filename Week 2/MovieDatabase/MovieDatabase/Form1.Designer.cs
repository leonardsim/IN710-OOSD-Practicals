namespace MovieDatabase
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
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddYear = new System.Windows.Forms.TextBox();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.txtAddDir = new System.Windows.Forms.TextBox();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDelYear = new System.Windows.Forms.TextBox();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.listBoxPrintAll = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(12, 12);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(111, 23);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Director:";
            // 
            // txtAddYear
            // 
            this.txtAddYear.Location = new System.Drawing.Point(238, 14);
            this.txtAddYear.Name = "txtAddYear";
            this.txtAddYear.Size = new System.Drawing.Size(189, 20);
            this.txtAddYear.TabIndex = 4;
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(238, 46);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(189, 20);
            this.txtAddTitle.TabIndex = 5;
            // 
            // txtAddDir
            // 
            this.txtAddDir.Location = new System.Drawing.Point(238, 77);
            this.txtAddDir.Name = "txtAddDir";
            this.txtAddDir.Size = new System.Drawing.Size(189, 20);
            this.txtAddDir.TabIndex = 6;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(12, 136);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteMovie.TabIndex = 7;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Year:";
            // 
            // txtDelYear
            // 
            this.txtDelYear.Location = new System.Drawing.Point(238, 138);
            this.txtDelYear.Name = "txtDelYear";
            this.txtDelYear.Size = new System.Drawing.Size(189, 20);
            this.txtDelYear.TabIndex = 9;
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Location = new System.Drawing.Point(238, 245);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(189, 20);
            this.txtSearchYear.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Year:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 242);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 303);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(111, 23);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print All";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // listBoxPrintAll
            // 
            this.listBoxPrintAll.FormattingEnabled = true;
            this.listBoxPrintAll.Location = new System.Drawing.Point(166, 303);
            this.listBoxPrintAll.Name = "listBoxPrintAll";
            this.listBoxPrintAll.Size = new System.Drawing.Size(261, 134);
            this.listBoxPrintAll.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 445);
            this.Controls.Add(this.listBoxPrintAll);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDelYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.txtAddDir);
            this.Controls.Add(this.txtAddTitle);
            this.Controls.Add(this.txtAddYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMovie);
            this.Name = "Form1";
            this.Text = "Movie Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddYear;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.TextBox txtAddDir;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDelYear;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListBox listBoxPrintAll;
    }
}

