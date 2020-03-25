using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Faktöriyel_Hesapla_SınıfKavramı
{
    public partial class Form1 : Form
    {
        class Matemetik
        {
            public int değer;

            public int faktöriyelHesapla(int değer)
            {
                int çarpım = 1;

                for (int i = 1; i <= değer; i++)
                {
                    çarpım *= i;
                }
                return çarpım;
            
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matemetik mat = new Matemetik();

            mat.değer = int.Parse(textBox1.Text);

            label3.Text = mat.faktöriyelHesapla(mat.değer).ToString();
        }
    }
}
