using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab32
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public int Calc(int n)
        {
            int res = 0;
            int buf = 1;

            for (int i = 1; i <= n; i++)
            {
                buf *= i;
                res += buf;
            }

            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = Calc(Convert.ToInt32(numericUpDown1.Value)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
