using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_ntpII_3Ara_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Met1();
        }

        public void Met1()
        {
            DateTime dt= DateTime.Now; 
            MessageBox.Show(dt.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string b = textBox1.Text;
            Met2(b);
        }
        public void Met2(string a)
        {
            MessageBox.Show("Hoşgeldiniz "+a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x, sonuc;
            x = 15;
            sonuc = Met3() + x;
            MessageBox.Show(sonuc.ToString());
        }
        public int Met3()
        {
            return 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(textBox2.Text);
            if (Met4(z))
            {
                MessageBox.Show("Doğru");
            }
            else
            {
                MessageBox.Show("Yanlış");
            }
        }

        public bool Met4(int y)
        {
            return (y * y) > (25);
            
        }

    }
}
