namespace PubsAndClubs
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
            this.dgvGigs = new System.Windows.Forms.DataGridView();
            this.bandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.dgvBand = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instruments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBand)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGigs
            // 
            this.dgvGigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGigs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bandName,
            this.genre,
            this.venue,
            this.date,
            this.time});
            this.dgvGigs.Location = new System.Drawing.Point(13, 13);
            this.dgvGigs.Name = "dgvGigs";
            this.dgvGigs.Size = new System.Drawing.Size(504, 119);
            this.dgvGigs.TabIndex = 0;
            // 
            // bandName
            // 
            this.bandName.HeaderText = "Band Name";
            this.bandName.Name = "bandName";
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            // 
            // venue
            // 
            this.venue.HeaderText = "Venue";
            this.venue.Name = "venue";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(13, 266);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(114, 44);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Display band info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(133, 266);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(114, 44);
            this.btnRock.TabIndex = 2;
            this.btnRock.Text = "\"Hard Rock\" genre";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(253, 266);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(114, 44);
            this.btnMonth.TabIndex = 3;
            this.btnMonth.Text = "Current month gig";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // dgvBand
            // 
            this.dgvBand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.role,
            this.instruments});
            this.dgvBand.Location = new System.Drawing.Point(12, 138);
            this.dgvBand.Name = "dgvBand";
            this.dgvBand.Size = new System.Drawing.Size(505, 119);
            this.dgvBand.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Alabama Shakes members";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.Width = 82;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.Width = 83;
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.Width = 54;
            // 
            // instruments
            // 
            this.instruments.HeaderText = "Instruments";
            this.instruments.Name = "instruments";
            this.instruments.Width = 86;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvBand);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.dgvGigs);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGigs;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.DataGridView dgvBand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn instruments;
    }
}

