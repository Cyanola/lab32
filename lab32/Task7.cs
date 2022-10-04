using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab32
{
    public partial class Task7 : Form
    {
        public Task7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0, kolichestvo = 0;
            string  strnull = "NO";
            foreach (var i in numericUpDown1.Text)
            {
                int chislo = int.Parse(i.ToString());
                if (chislo % 2 == 0)
                {
                    result += chislo;
                    kolichestvo++;
                }
            }
            label3.Text = (result / kolichestvo).ToString();
            if (kolichestvo == 0)
            {
                // если нету четный цифр <3
                label3.Text = strnull;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}