namespace MixMatch
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
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.pbBody = new System.Windows.Forms.PictureBox();
            this.pbLegs = new System.Windows.Forms.PictureBox();
            this.cbHead = new System.Windows.Forms.ComboBox();
            this.cbBody = new System.Windows.Forms.ComboBox();
            this.cbLegs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMakeMonster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHead
            // 
            this.pbHead.Location = new System.Drawing.Point(13, 13);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(290, 176);
            this.pbHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHead.TabIndex = 0;
            this.pbHead.TabStop = false;
            // 
            // pbBody
            // 
            this.pbBody.Location = new System.Drawing.Point(13, 186);
            this.pbBody.Name = "pbBody";
            this.pbBody.Size = new System.Drawing.Size(290, 176);
            this.pbBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBody.TabIndex = 1;
            this.pbBody.TabStop = false;
            // 
            // pbLegs
            // 
            this.pbLegs.Location = new System.Drawing.Point(13, 355);
            this.pbLegs.Name = "pbLegs";
            this.pbLegs.Size = new System.Drawing.Size(290, 176);
            this.pbLegs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLegs.TabIndex = 2;
            this.pbLegs.TabStop = false;
            // 
            // cbHead
            // 
            this.cbHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHead.FormattingEnabled = true;
            this.cbHead.Location = new System.Drawing.Point(351, 10);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(173, 21);
            this.cbHead.TabIndex = 3;
            // 
            // cbBody
            // 
            this.cbBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBody.FormattingEnabled = true;
            this.cbBody.Location = new System.Drawing.Point(351, 51);
            this.cbBody.Name = "cbBody";
            this.cbBody.Size = new System.Drawing.Size(173, 21);
            this.cbBody.TabIndex = 4;
            // 
            // cbLegs
            // 
            this.cbLegs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLegs.FormattingEnabled = true;
            this.cbLegs.Location = new System.Drawing.Point(351, 96);
            this.cbLegs.Name = "cbLegs";
            this.cbLegs.Size = new System.Drawing.Size(173, 21);
            this.cbLegs.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Head";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Body";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Legs";
            // 
            // btnMakeMonster
            // 
            this.btnMakeMonster.Location = new System.Drawing.Point(351, 154);
            this.btnMakeMonster.Name = "btnMakeMonster";
            this.btnMakeMonster.Size = new System.Drawing.Size(173, 23);
            this.btnMakeMonster.TabIndex = 9;
            this.btnMakeMonster.Text = "Make Monster";
            this.btnMakeMonster.UseVisualStyleBackColor = true;
            this.btnMakeMonster.Click += new System.EventHandler(this.btnMakeMonster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 543);
            this.Controls.Add(this.btnMakeMonster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLegs);
            this.Controls.Add(this.cbBody);
            this.Controls.Add(this.cbHead);
            this.Controls.Add(this.pbLegs);
            this.Controls.Add(this.pbBody);
            this.Controls.Add(this.pbHead);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.PictureBox pbBody;
        private System.Windows.Forms.PictureBox pbLegs;
        private System.Windows.Forms.ComboBox cbHead;
        private System.Windows.Forms.ComboBox cbBody;
        private System.Windows.Forms.ComboBox cbLegs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMakeMonster;
    }
}

