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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var v = numericUpDown1.Text;
            
            List <int> list = new List<int> ();
            List<int> x = new List<int>();
            //    List <string> strings = new List <string> ();
            for (int i = 0; i < x.ToString().Length; i++)
            {
                x[i] = Convert.ToInt32(numericUpDown1.Value);
                {
                    for (int d = 0; d < x.Count; d++) //цикл по длине числа
                    {
                        try
                        {
                            int a = int.Parse(x.ToString()); //разделить цифры в числе

                            if (a % 2 == 0) //если цифра четное
                            {
                                list.Add(x.ToString()[i]);
                            }
                        }
                        catch (Exception error) { continue; }
                    }
                    label4.Text = list.Count.ToString();// должно быть количество четных цифр в числе,
                }
            } 
            double n = 0;
            for (int m =0; m < list.Count; m++)
            {  
                n += int.Parse(list[m].ToString());        
            }

            double sum = 0;
            sum = (double)n/ list.Count;
            label3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
