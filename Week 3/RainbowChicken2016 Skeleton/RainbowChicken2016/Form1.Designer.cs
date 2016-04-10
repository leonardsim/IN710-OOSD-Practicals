namespace RainbowChicken2016
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
            this.components = new System.ComponentModel.Container();
            this.pbxChicken = new System.Windows.Forms.PictureBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxChicken)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxChicken
            // 
            this.pbxChicken.BackColor = System.Drawing.SystemColors.ControlText;
            this.pbxChicken.Image = global::RainbowChicken2016.Properties.Resources.chicken;
            this.pbxChicken.Location = new System.Drawing.Point(379, 422);
            this.pbxChicken.Name = "pbxChicken";
            this.pbxChicken.Size = new System.Drawing.Size(64, 64);
            this.pbxChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxChicken.TabIndex = 0;
            this.pbxChicken.TabStop = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(27, 23);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(31, 32);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "0";
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Enabled = true;
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.pbxChicken);
            this.Name = "Form1";
            this.Text = "Incredible Rainbow Spitting Chicken";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxChicken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxChicken;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Timer tmrAnimation;
    }
}

