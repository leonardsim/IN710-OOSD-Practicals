namespace MachineSpec
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoMulti = new System.Windows.Forms.RadioButton();
            this.rdoBusiness = new System.Windows.Forms.RadioButton();
            this.rdoGame = new System.Windows.Forms.RadioButton();
            this.rdoLaptop = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(128, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(372, 173);
            this.listBox1.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(13, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print Spec";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLaptop);
            this.groupBox1.Controls.Add(this.rdoMulti);
            this.groupBox1.Controls.Add(this.rdoBusiness);
            this.groupBox1.Controls.Add(this.rdoGame);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine Type";
            // 
            // rdoMulti
            // 
            this.rdoMulti.AutoSize = true;
            this.rdoMulti.Location = new System.Drawing.Point(7, 68);
            this.rdoMulti.Name = "rdoMulti";
            this.rdoMulti.Size = new System.Drawing.Size(75, 17);
            this.rdoMulti.TabIndex = 2;
            this.rdoMulti.TabStop = true;
            this.rdoMulti.Text = "Multimedia";
            this.rdoMulti.UseVisualStyleBackColor = true;
            // 
            // rdoBusiness
            // 
            this.rdoBusiness.AutoSize = true;
            this.rdoBusiness.Location = new System.Drawing.Point(7, 44);
            this.rdoBusiness.Name = "rdoBusiness";
            this.rdoBusiness.Size = new System.Drawing.Size(67, 17);
            this.rdoBusiness.TabIndex = 1;
            this.rdoBusiness.TabStop = true;
            this.rdoBusiness.Text = "Business";
            this.rdoBusiness.UseVisualStyleBackColor = true;
            // 
            // rdoGame
            // 
            this.rdoGame.AutoSize = true;
            this.rdoGame.Location = new System.Drawing.Point(7, 19);
            this.rdoGame.Name = "rdoGame";
            this.rdoGame.Size = new System.Drawing.Size(53, 17);
            this.rdoGame.TabIndex = 0;
            this.rdoGame.TabStop = true;
            this.rdoGame.Text = "Game";
            this.rdoGame.UseVisualStyleBackColor = true;
            // 
            // rdoLaptop
            // 
            this.rdoLaptop.AutoSize = true;
            this.rdoLaptop.Location = new System.Drawing.Point(7, 92);
            this.rdoLaptop.Name = "rdoLaptop";
            this.rdoLaptop.Size = new System.Drawing.Size(58, 17);
            this.rdoLaptop.TabIndex = 3;
            this.rdoLaptop.TabStop = true;
            this.rdoLaptop.Text = "Laptop";
            this.rdoLaptop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Computer Builder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoMulti;
        private System.Windows.Forms.RadioButton rdoBusiness;
        private System.Windows.Forms.RadioButton rdoGame;
        private System.Windows.Forms.RadioButton rdoLaptop;
    }
}

