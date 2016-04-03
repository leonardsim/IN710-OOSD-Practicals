namespace ProgressFeedbackDisplay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSpin = new System.Windows.Forms.RadioButton();
            this.rdoProg = new System.Windows.Forms.RadioButton();
            this.rdoTrack = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTrack);
            this.groupBox1.Controls.Add(this.rdoProg);
            this.groupBox1.Controls.Add(this.rdoSpin);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feedback";
            // 
            // rdoSpin
            // 
            this.rdoSpin.AutoSize = true;
            this.rdoSpin.Location = new System.Drawing.Point(7, 20);
            this.rdoSpin.Name = "rdoSpin";
            this.rdoSpin.Size = new System.Drawing.Size(67, 17);
            this.rdoSpin.TabIndex = 0;
            this.rdoSpin.TabStop = true;
            this.rdoSpin.Text = "Spin Box";
            this.rdoSpin.UseVisualStyleBackColor = true;
            // 
            // rdoProg
            // 
            this.rdoProg.AutoSize = true;
            this.rdoProg.Location = new System.Drawing.Point(7, 44);
            this.rdoProg.Name = "rdoProg";
            this.rdoProg.Size = new System.Drawing.Size(85, 17);
            this.rdoProg.TabIndex = 1;
            this.rdoProg.TabStop = true;
            this.rdoProg.Text = "Progress Bar";
            this.rdoProg.UseVisualStyleBackColor = true;
            // 
            // rdoTrack
            // 
            this.rdoTrack.AutoSize = true;
            this.rdoTrack.Location = new System.Drawing.Point(7, 68);
            this.rdoTrack.Name = "rdoTrack";
            this.rdoTrack.Size = new System.Drawing.Size(72, 17);
            this.rdoTrack.TabIndex = 2;
            this.rdoTrack.TabStop = true;
            this.rdoTrack.Text = "Track Bar";
            this.rdoTrack.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 146);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(228, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(228, 60);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(237, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(218, 89);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(257, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 185);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTrack;
        private System.Windows.Forms.RadioButton rdoProg;
        private System.Windows.Forms.RadioButton rdoSpin;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

