namespace QuizNight
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
            this.rdoAdult = new System.Windows.Forms.RadioButton();
            this.rdoChild = new System.Windows.Forms.RadioButton();
            this.lblAdult = new System.Windows.Forms.Label();
            this.lblChild = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtCorrect = new System.Windows.Forms.TextBox();
            this.txtIncorrect = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoChild);
            this.groupBox1.Controls.Add(this.rdoAdult);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teams";
            // 
            // rdoAdult
            // 
            this.rdoAdult.AutoSize = true;
            this.rdoAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdult.Location = new System.Drawing.Point(7, 20);
            this.rdoAdult.Name = "rdoAdult";
            this.rdoAdult.Size = new System.Drawing.Size(54, 17);
            this.rdoAdult.TabIndex = 0;
            this.rdoAdult.TabStop = true;
            this.rdoAdult.Text = "Adults";
            this.rdoAdult.UseVisualStyleBackColor = true;
            // 
            // rdoChild
            // 
            this.rdoChild.AutoSize = true;
            this.rdoChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChild.Location = new System.Drawing.Point(7, 44);
            this.rdoChild.Name = "rdoChild";
            this.rdoChild.Size = new System.Drawing.Size(63, 17);
            this.rdoChild.TabIndex = 1;
            this.rdoChild.TabStop = true;
            this.rdoChild.Text = "Children";
            this.rdoChild.UseVisualStyleBackColor = true;
            // 
            // lblAdult
            // 
            this.lblAdult.AutoSize = true;
            this.lblAdult.Location = new System.Drawing.Point(120, 28);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(87, 13);
            this.lblAdult.TabIndex = 1;
            this.lblAdult.Text = "Correct Answers:";
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Location = new System.Drawing.Point(112, 61);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(95, 13);
            this.lblChild.TabIndex = 2;
            this.lblChild.Text = "Incorrect Answers:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(176, 112);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score:";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(13, 106);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(81, 24);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // txtCorrect
            // 
            this.txtCorrect.Location = new System.Drawing.Point(213, 25);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(100, 20);
            this.txtCorrect.TabIndex = 8;
            // 
            // txtIncorrect
            // 
            this.txtIncorrect.Location = new System.Drawing.Point(213, 56);
            this.txtIncorrect.Name = "txtIncorrect";
            this.txtIncorrect.Size = new System.Drawing.Size(100, 20);
            this.txtIncorrect.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 139);
            this.Controls.Add(this.txtIncorrect);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblChild);
            this.Controls.Add(this.lblAdult);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoChild;
        private System.Windows.Forms.RadioButton rdoAdult;
        private System.Windows.Forms.Label lblAdult;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtCorrect;
        private System.Windows.Forms.TextBox txtIncorrect;
    }
}

