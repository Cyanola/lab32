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
using static lab32.Program;
namespace lab32
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value = numericUpDown1.Text;
            double E = 0;
            if (double.TryParse(value, out E))
            {
                label3.Text = $"{calc_f(E)}";
            }

        }
        public double calc_f(double eps)
        {
            double res = 0;

            for (int i = 1; true; i++)
            {
                double current_row = 1.0 / Math.Sqrt(Factorial(i));
                if (current_row < eps) return res;
                res += current_row;
            }
        }
    }
}