using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int n = Convert.ToInt32(textBox2.Text);
                int[] pole = new int[n];
                int prvni;
                int sesty;
                Random rng = new Random();
                for (int i = 0; i < n; i++)
                {
                    int nahodne = rng.Next(1, 21);
                    pole[i] = nahodne;
                    listBox1.Items.Add(nahodne);
                }
                prvni = pole[0];
                sesty = pole[5];
                double cislo = 0;
                cislo = Math.Pow(prvni,sesty);
                int cislo2 = Convert.ToInt32(cislo);
                label1.Text = cislo2.ToString();
            }
            catch(FormatException cc)
            {
                MessageBox.Show(cc.Message);
            }
            catch(ArithmeticException ll)
            {
                MessageBox.Show(ll.Message);
            }
            catch(IndexOutOfRangeException pp)
            {
                MessageBox.Show(pp.Message);
            }
        }
    }
}
