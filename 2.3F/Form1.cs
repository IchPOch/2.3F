using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._3F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Vivod_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(A.Text);
            int b = Convert.ToInt32(B.Text);
            if (b < a) viv.Text = ("Неккоректный ввод");
            else
                viv.Text = "";
            {
                int g = a;
                while (g <= b)
                {
                    if (g > 0) { viv.Text += " "; viv.Text += g; }
                    g++;
                }
                g = a;
                viv.Text += Environment.NewLine;
                for (int i = a; i <= b; i++)
                {
                    if (i > 0) 
                    {
                        viv.Text += " ";
                        viv.Text += i; 
                    }
                }
                viv.Text += Environment.NewLine;
                do
                {
                    if (g > 0) { viv.Text += " "; viv.Text += g; }
                    g++;
                }
                while (g <= b);
            }
        }
    }

}

