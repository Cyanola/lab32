using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab32
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public double Func(int x)
        {
            double res = Math.Sqrt(Math.Abs(2.0 * Math.Pow((x - 2.0),2) * (8.0 - x) - 1.0));
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 6;
          
            double sum = 0.0;
            while (a <= b)
            {
                if (a == 0)
                {
                    double k = Math.Round(Func(a), 5, MidpointRounding.AwayFromZero);
                    label2.Text = $"в точке {a} равно {k}";
                    sum += k;
                }
                if (a == 1)
                {
                    double k = Math.Round(Func(a), 5, MidpointRounding.AwayFromZero);
                    label3.Text = $"в точке {a} равно {k}"; 
                    sum += k;
                }
                if (a == 2)
                {
                    double k = Math.Round(Func(a), 5, MidpointRounding.AwayFromZero);
                    label4.Text = $"в точке {a} равно {k}";
                    sum += k;
                }
                if (a == 3)
                {
                    double k = Math.Round(Func(a), 5, MidpointRounding.AwayFromZero);
                    label5.Text = $"в точке {a} равно {k}";
                    sum += k;
                }
                if (a == 4)
                {
                    double k = Math.Round(Func(a), 5, MidpointRounding.AwayFromZero);
                    label6.Text = $"в точке {a} равно {k}";
                    sum += Func(a);
                }

                if (a == 5)
                {
                    double k = Math.Round(Func(a), 5, MidpointRounding.AwayFromZero);
                    label7.Text = $"в точке {a} равно {k}"; 
                    sum +=k;
                }
                if (a == 6)
                {
                    double k = Math.Round(Func(a), 5, MidpointRounding.AwayFromZero); 
                    label10.Text = $"в точке {a} равно {k}"; 
                    sum += k;
                }
             
                a++; 

            }
            label9.Text = $"{Math.Round(sum, 5, MidpointRounding.AwayFromZero)}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}