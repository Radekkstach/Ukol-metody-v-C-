using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukolmetodyc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool JePrvocislo(int cislo)
        {
            bool prvocislo = true;
            if (cislo == 2) prvocislo = true;
            else
            {
                if (cislo == 1 || cislo % 2 == 0) prvocislo = false;
                else for (int delitel = 3; delitel <= Math.Sqrt(cislo) && prvocislo; ++delitel)
                    {
                        if (cislo % delitel == 0) return false;
                    }
            }
            return prvocislo;
        }

        void Prepis(TextBox text, ListBox list)
        {
            int n = (int)numericUpDown1.Value;
            Random rng = new Random();
            text.Clear();
            list.Items.Clear();
            for (; n != 0; n--)
            {
                int nahodne = rng.Next(2, 16);
                if (JePrvocislo(nahodne)) listBox1.Items.Add(nahodne);
                text.Text = text.Text + nahodne + "  ";
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            Prepis(textBox1, listBox1);
        }
    }
}
