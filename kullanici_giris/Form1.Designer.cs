namespace kullanici_giris
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            checkBox2 = new CheckBox();
            button3 = new Button();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Kozuka Gothic Pr6N M", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(361, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 48);
            textBox1.TabIndex = 1;
            textBox1.Text = "Kullanıc Adı";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Kozuka Gothic Pr6N M", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(360, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 48);
            textBox2.TabIndex = 2;
            textBox2.Text = "123456";
            textBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Parola;
            pictureBox2.Location = new Point(297, 188);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(364, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(789, 378);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Parolayı Göster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Giris;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(293, 378);
            button2.Name = "button2";
            button2.Size = new Size(364, 76);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(710, 319);
            button1.Name = "button1";
            button1.Size = new Size(222, 23);
            button1.TabIndex = 7;
            button1.Text = "Göster / Gizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(789, 66);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(96, 19);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Göster / Gizle";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button3
            // 
            button3.Location = new Point(789, 520);
            button3.Name = "button3";
            button3.Size = new Size(83, 23);
            button3.TabIndex = 9;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(789, 482);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(361, 293);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 11;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Kullanici_adi;
            pictureBox1.Location = new Point(293, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Arkaplan;
            ClientSize = new Size(1264, 761);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(button3);
            Controls.Add(checkBox2);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        private Button button2;
        private Button button1;
        private CheckBox checkBox2;
        private Button button3;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private PictureBox pictureBox1;
    }
}
