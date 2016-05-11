namespace ADOdatabase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnDue = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(13, 248);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(185, 31);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Papers With Tutor Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnDue
            // 
            this.btnDue.Location = new System.Drawing.Point(204, 248);
            this.btnDue.Name = "btnDue";
            this.btnDue.Size = new System.Drawing.Size(185, 31);
            this.btnDue.TabIndex = 2;
            this.btnDue.Text = "Assignments Due In 2 Weeks";
            this.btnDue.UseVisualStyleBackColor = true;
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(395, 248);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(185, 31);
            this.btnAvg.TabIndex = 3;
            this.btnAvg.Text = "Average Marks";
            this.btnAvg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 292);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnDue);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnDue;
        private System.Windows.Forms.Button btnAvg;


    }
}

