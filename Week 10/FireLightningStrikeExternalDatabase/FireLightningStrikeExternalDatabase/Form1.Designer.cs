namespace FireLightningStrikeExternalDatabase
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
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnLargest = new System.Windows.Forms.Button();
            this.btnLatLongPic = new System.Windows.Forms.Button();
            this.btnStrikeFire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(12, 12);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(490, 251);
            this.lbOutput.TabIndex = 0;
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(12, 269);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(118, 23);
            this.btnAvg.TabIndex = 1;
            this.btnAvg.Text = "Average Insentity";
            this.btnAvg.UseVisualStyleBackColor = true;
            // 
            // btnLargest
            // 
            this.btnLargest.Location = new System.Drawing.Point(136, 269);
            this.btnLargest.Name = "btnLargest";
            this.btnLargest.Size = new System.Drawing.Size(118, 23);
            this.btnLargest.TabIndex = 2;
            this.btnLargest.Text = "Largest 3 Fires";
            this.btnLargest.UseVisualStyleBackColor = true;
            // 
            // btnLatLongPic
            // 
            this.btnLatLongPic.Location = new System.Drawing.Point(260, 269);
            this.btnLatLongPic.Name = "btnLatLongPic";
            this.btnLatLongPic.Size = new System.Drawing.Size(118, 23);
            this.btnLatLongPic.TabIndex = 3;
            this.btnLatLongPic.Text = "Picture Lat and Long";
            this.btnLatLongPic.UseVisualStyleBackColor = true;
            // 
            // btnStrikeFire
            // 
            this.btnStrikeFire.Location = new System.Drawing.Point(384, 269);
            this.btnStrikeFire.Name = "btnStrikeFire";
            this.btnStrikeFire.Size = new System.Drawing.Size(118, 23);
            this.btnStrikeFire.TabIndex = 4;
            this.btnStrikeFire.Text = "Strike Cause Fire";
            this.btnStrikeFire.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 311);
            this.Controls.Add(this.btnStrikeFire);
            this.Controls.Add(this.btnLatLongPic);
            this.Controls.Add(this.btnLargest);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.lbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button btnLargest;
        private System.Windows.Forms.Button btnLatLongPic;
        private System.Windows.Forms.Button btnStrikeFire;
    }
}

