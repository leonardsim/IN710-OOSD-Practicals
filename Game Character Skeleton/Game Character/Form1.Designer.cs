namespace Game_Character
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Game Character with Strategy Pattern";

            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTroll = new System.Windows.Forms.RadioButton();
            this.rdKnight = new System.Windows.Forms.RadioButton();
            this.rdQueen = new System.Windows.Forms.RadioButton();
            this.rdKing = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBattle = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBow = new System.Windows.Forms.RadioButton();
            this.rdKnife = new System.Windows.Forms.RadioButton();
            this.rdSword = new System.Windows.Forms.RadioButton();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnAddCharacter);
            this.panel1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(16, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 208);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTroll);
            this.groupBox1.Controls.Add(this.rdKnight);
            this.groupBox1.Controls.Add(this.rdQueen);
            this.groupBox1.Controls.Add(this.rdKing);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(363, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(215, 170);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Type";
            // 
            // rdTroll
            // 
            this.rdTroll.AutoSize = true;
            this.rdTroll.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTroll.Location = new System.Drawing.Point(17, 127);
            this.rdTroll.Margin = new System.Windows.Forms.Padding(4);
            this.rdTroll.Name = "rdTroll";
            this.rdTroll.Size = new System.Drawing.Size(84, 31);
            this.rdTroll.TabIndex = 3;
            this.rdTroll.TabStop = true;
            this.rdTroll.Text = "Troll";
            this.rdTroll.UseVisualStyleBackColor = true;
            // 
            // rdKnight
            // 
            this.rdKnight.AutoSize = true;
            this.rdKnight.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKnight.Location = new System.Drawing.Point(17, 96);
            this.rdKnight.Margin = new System.Windows.Forms.Padding(4);
            this.rdKnight.Name = "rdKnight";
            this.rdKnight.Size = new System.Drawing.Size(109, 31);
            this.rdKnight.TabIndex = 2;
            this.rdKnight.TabStop = true;
            this.rdKnight.Text = "Knight";
            this.rdKnight.UseVisualStyleBackColor = true;
            // 
            // rdQueen
            // 
            this.rdQueen.AutoSize = true;
            this.rdQueen.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdQueen.Location = new System.Drawing.Point(17, 65);
            this.rdQueen.Margin = new System.Windows.Forms.Padding(4);
            this.rdQueen.Name = "rdQueen";
            this.rdQueen.Size = new System.Drawing.Size(98, 31);
            this.rdQueen.TabIndex = 1;
            this.rdQueen.TabStop = true;
            this.rdQueen.Text = "Queen";
            this.rdQueen.UseVisualStyleBackColor = true;
            // 
            // rdKing
            // 
            this.rdKing.AutoSize = true;
            this.rdKing.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKing.Location = new System.Drawing.Point(17, 34);
            this.rdKing.Margin = new System.Windows.Forms.Padding(4);
            this.rdKing.Name = "rdKing";
            this.rdKing.Size = new System.Drawing.Size(87, 31);
            this.rdKing.TabIndex = 0;
            this.rdKing.TabStop = true;
            this.rdKing.Text = "King";
            this.rdKing.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(97, 97);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 35);
            this.txtName.TabIndex = 9;
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCharacter.Location = new System.Drawing.Point(27, 22);
            this.btnAddCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(287, 39);
            this.btnAddCharacter.TabIndex = 8;
            this.btnAddCharacter.Text = "Create New Character";
            this.btnAddCharacter.UseVisualStyleBackColor = true;

            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnBattle);
            this.panel2.Controls.Add(this.checkedListBox1);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(16, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 416);
            this.panel2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "To Battle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Choose Two Combatants";
            // 
            // btnBattle
            // 
            this.btnBattle.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBattle.Location = new System.Drawing.Point(296, 42);
            this.btnBattle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(290, 43);
            this.btnBattle.TabIndex = 22;
            this.btnBattle.Text = "Battle!";
            this.btnBattle.UseVisualStyleBackColor = true;

            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(15, 98);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(267, 304);
            this.checkedListBox1.TabIndex = 21;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(296, 99);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 301);
            this.listBox1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.checkedListBox2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(644, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 645);
            this.panel3.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBow);
            this.groupBox2.Controls.Add(this.rdKnife);
            this.groupBox2.Controls.Add(this.rdSword);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 411);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(215, 132);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Weapon";
            // 
            // rdBow
            // 
            this.rdBow.AutoSize = true;
            this.rdBow.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBow.Location = new System.Drawing.Point(17, 96);
            this.rdBow.Margin = new System.Windows.Forms.Padding(4);
            this.rdBow.Name = "rdBow";
            this.rdBow.Size = new System.Drawing.Size(80, 31);
            this.rdBow.TabIndex = 2;
            this.rdBow.TabStop = true;
            this.rdBow.Text = "Bow";
            this.rdBow.UseVisualStyleBackColor = true;
            // 
            // rdKnife
            // 
            this.rdKnife.AutoSize = true;
            this.rdKnife.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdKnife.Location = new System.Drawing.Point(17, 65);
            this.rdKnife.Margin = new System.Windows.Forms.Padding(4);
            this.rdKnife.Name = "rdKnife";
            this.rdKnife.Size = new System.Drawing.Size(94, 31);
            this.rdKnife.TabIndex = 1;
            this.rdKnife.TabStop = true;
            this.rdKnife.Text = "Knife";
            this.rdKnife.UseVisualStyleBackColor = true;
            // 
            // rdSword
            // 
            this.rdSword.AutoSize = true;
            this.rdSword.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSword.Location = new System.Drawing.Point(17, 34);
            this.rdSword.Margin = new System.Windows.Forms.Padding(4);
            this.rdSword.Name = "rdSword";
            this.rdSword.Size = new System.Drawing.Size(100, 31);
            this.rdSword.TabIndex = 0;
            this.rdSword.TabStop = true;
            this.rdSword.Text = "Sword";
            this.rdSword.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(22, 54);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(267, 304);
            this.checkedListBox2.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 589);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 43);
            this.button1.TabIndex = 25;
            this.button1.Text = "Change Weapon";
            this.button1.UseVisualStyleBackColor = true;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Character";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 678);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Battle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTroll;
        private System.Windows.Forms.RadioButton rdKnight;
        private System.Windows.Forms.RadioButton rdQueen;
        private System.Windows.Forms.RadioButton rdKing;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBow;
        private System.Windows.Forms.RadioButton rdKnife;
        private System.Windows.Forms.RadioButton rdSword;
    }
}

