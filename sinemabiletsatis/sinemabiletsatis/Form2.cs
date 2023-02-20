using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemabiletsatis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox7.Enabled = false;
            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button18.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label4.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label7.Visible = false;
            label18.Visible = false;
            textBox11.Visible = false;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox7.Enabled = true;
            pictureBox7.Visible = true;


            pictureBox4.Visible = false;
            pictureBox4.Enabled = false;
            pictureBox3.Visible = false;
            pictureBox1.Enabled = false;
            label17.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;


            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button18.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label4.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label7.Visible = true;
            label18.Visible = true;
            textBox11.Visible = true;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox7.Enabled = false;
            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button18.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label4.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label7.Visible = false;
            label18.Visible = false;
            textBox11.Visible = false;

            pictureBox4.Visible = true;
            pictureBox4.Enabled = true;
            pictureBox3.Visible = true;
            pictureBox1.Enabled = true;
            label17.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
        }

        int ogrbilet = 0;
        int tambilet = 0;
        int buyukmisir = 0; //14 Tl
        int normalmisir = 0; //8 TL
        int su = 0; //5 TL
        int cola = 0; //10 TL
        int toplamfiyat = 0;
        int gunsonufiyat = 0;
        int gunsonubilet = 0;
        int toplambiletfiyat = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            ogrbilet++;
            textBox1.Text = ogrbilet.ToString();
            toplamfiyat = toplamfiyat + 15;
            textBox2.Text = toplamfiyat.ToString();

            toplambiletfiyat += 15;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrbilet--;
            if (ogrbilet == -1)
            {
                MessageBox.Show("Negatif bir değer yapamazsınız.");
                ogrbilet = 0;
            }
            textBox1.Text = ogrbilet.ToString();
            toplamfiyat = toplamfiyat - 15;
            textBox2.Text = toplamfiyat.ToString();
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tambilet++;
            textBox11.Text = tambilet.ToString();
            toplamfiyat = toplamfiyat + 25;
            textBox2.Text = toplamfiyat.ToString();

            toplambiletfiyat += 25;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tambilet--;
            if (tambilet == -1)
            {
                MessageBox.Show("Negatif bir değer yapamazsınız.");
                tambilet = 0;
            }
            textBox11.Text = tambilet.ToString();
            toplamfiyat = toplamfiyat - 25;
            textBox2.Text = toplamfiyat.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buyukmisir++;
            textBox3.Text = buyukmisir.ToString();
            toplamfiyat = toplamfiyat + 14;
            textBox2.Text = toplamfiyat.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            normalmisir++;
            textBox4.Text = normalmisir.ToString();
            toplamfiyat = toplamfiyat + 8;
            textBox2.Text = toplamfiyat.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buyukmisir--;

            if (buyukmisir == -1)
            {
                MessageBox.Show("Negatif bir değer yapamazsınız.");
                buyukmisir = 0;
            }
            textBox3.Text = buyukmisir.ToString();
            toplamfiyat = toplamfiyat - 14;
            textBox2.Text = toplamfiyat.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            normalmisir--;
            if (normalmisir == -1)
            {
                MessageBox.Show("Negatif bir değer yapamazsınız.");
                normalmisir = 0;
            }
            textBox4.Text = normalmisir.ToString();
            toplamfiyat = toplamfiyat - 8;
            textBox2.Text = toplamfiyat.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cola++;
            textBox5.Text = cola.ToString();
            toplamfiyat = toplamfiyat + 10;
            textBox2.Text = toplamfiyat.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cola--;
            if (cola == -1)
            {
                MessageBox.Show("Negatif bir değer yapamazsınız.");
                cola = 0;
            }
            textBox5.Text = cola.ToString() ;
            toplamfiyat = toplamfiyat - 10;
            textBox2.Text = toplamfiyat.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            su++;
            textBox6.Text = su.ToString ();
            toplamfiyat = toplamfiyat +5;
            textBox2.Text = toplamfiyat.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            su--;
            if (su == -1)
            {
                MessageBox.Show("Negatif bir değer yapamazsınız.");
                su = 0;
            }
            textBox6.Text = su.ToString();
            toplamfiyat = toplamfiyat - 5;
            textBox2.Text = toplamfiyat.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gunsonubilet = ogrbilet + gunsonubilet;
            gunsonubilet = tambilet + gunsonubilet;
            textBox7.Text = gunsonubilet.ToString();

            gunsonufiyat = toplambiletfiyat + gunsonufiyat;

            textBox8.Text = gunsonufiyat.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            ogrbilet = 0;
            tambilet = 0;
            toplamfiyat = 0;
            toplambiletfiyat = 0;
            textBox1.Text = "0";
            textBox3.Text = "0";     
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox11.Text = "0";
            textBox2.Text = "0";
        }
    }
}
