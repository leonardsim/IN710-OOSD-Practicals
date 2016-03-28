namespace SocialNetworking
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
            this.tcSocial = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.tpFriend1 = new System.Windows.Forms.TabPage();
            this.tpFriend2 = new System.Windows.Forms.TabPage();
            this.tpFriend3 = new System.Windows.Forms.TabPage();
            this.tpFriend4 = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tcSocial.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSocial
            // 
            this.tcSocial.Controls.Add(this.tpMain);
            this.tcSocial.Controls.Add(this.tpFriend1);
            this.tcSocial.Controls.Add(this.tpFriend2);
            this.tcSocial.Controls.Add(this.tpFriend3);
            this.tcSocial.Controls.Add(this.tpFriend4);
            this.tcSocial.Location = new System.Drawing.Point(12, 12);
            this.tcSocial.Name = "tcSocial";
            this.tcSocial.SelectedIndex = 0;
            this.tcSocial.Size = new System.Drawing.Size(458, 308);
            this.tcSocial.TabIndex = 0;
            // 
            // tpMain
            // 
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(450, 282);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Main Page";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // tpFriend1
            // 
            this.tpFriend1.Location = new System.Drawing.Point(4, 22);
            this.tpFriend1.Name = "tpFriend1";
            this.tpFriend1.Padding = new System.Windows.Forms.Padding(3);
            this.tpFriend1.Size = new System.Drawing.Size(450, 282);
            this.tpFriend1.TabIndex = 1;
            this.tpFriend1.Text = "Friend 1";
            this.tpFriend1.UseVisualStyleBackColor = true;
            // 
            // tpFriend2
            // 
            this.tpFriend2.Location = new System.Drawing.Point(4, 22);
            this.tpFriend2.Name = "tpFriend2";
            this.tpFriend2.Padding = new System.Windows.Forms.Padding(3);
            this.tpFriend2.Size = new System.Drawing.Size(450, 282);
            this.tpFriend2.TabIndex = 2;
            this.tpFriend2.Text = "Friend 2";
            this.tpFriend2.UseVisualStyleBackColor = true;
            // 
            // tpFriend3
            // 
            this.tpFriend3.Location = new System.Drawing.Point(4, 22);
            this.tpFriend3.Name = "tpFriend3";
            this.tpFriend3.Padding = new System.Windows.Forms.Padding(3);
            this.tpFriend3.Size = new System.Drawing.Size(450, 282);
            this.tpFriend3.TabIndex = 3;
            this.tpFriend3.Text = "Friend 3";
            this.tpFriend3.UseVisualStyleBackColor = true;
            // 
            // tpFriend4
            // 
            this.tpFriend4.Location = new System.Drawing.Point(4, 22);
            this.tpFriend4.Name = "tpFriend4";
            this.tpFriend4.Padding = new System.Windows.Forms.Padding(3);
            this.tpFriend4.Size = new System.Drawing.Size(450, 282);
            this.tpFriend4.TabIndex = 4;
            this.tpFriend4.Text = "Friend 4";
            this.tpFriend4.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 326);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Status";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(155, 328);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(311, 20);
            this.tbStatus.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 357);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tcSocial);
            this.Name = "Form1";
            this.Text = "Social Network";
            this.tcSocial.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcSocial;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpFriend1;
        private System.Windows.Forms.TabPage tpFriend2;
        private System.Windows.Forms.TabPage tpFriend3;
        private System.Windows.Forms.TabPage tpFriend4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbStatus;
    }
}

