namespace kullanici_giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123456")
            {
                MessageBox.Show("Baþarýlý");
            }
            else
            {
                MessageBox.Show("Hatalý Giriþ.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false; // Gözüksün
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false; // Gözüksün
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }




        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox4.Checked;
        }
    }
}
