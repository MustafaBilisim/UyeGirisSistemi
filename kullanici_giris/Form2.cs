﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanici_giris
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int giris_hakki = 3;

        private void button1_Click(object sender, EventArgs e)
        {

            
            int hata_oldumu = 0;

            if(textBox1.Text != "admin")
            {
                hata_oldumu = 1;
                label3.Visible = true;
                

            }
            if(textBox2.Text != "123")
            {
                hata_oldumu = 1;
                giris_hakki--;
            }



            if (giris_hakki > 0)
            {

                if (hata_oldumu == 0)
                {
                    MessageBox.Show("Başarılı");
                }
                else
                {
                    MessageBox.Show("Hatalı, Kalan giriş hakki :" + giris_hakki);

                }
            }
            else
            {
                button1.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";

                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }






            /*
             * 
             * Kullanıcı adı ve parolayı ayrı ayrı kontrol etme kodu.
             * 
             * 
                        if(textBox1.Text == "admin")
                        {
                            if(textBox2.Text == "123")
                            {
                                MessageBox.Show("Başarılı");
                            }
                            else
                            {
                                MessageBox.Show("Parola Yanlış");
                                giris_hakki--;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Bulunamadı");
                        }

            */




            /*
             * Tek if / else bloğu ile hem kullancı adı hem parola kontrol etme kodu.
             * 
                        if (textBox1.Text == "admin" && textBox2.Text == "123")
                        {
                            MessageBox.Show("Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("!! HATALI !!");
                            giris_hakki--;
                        }
            */
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }




        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        
    }
}
