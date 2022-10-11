using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace lab52
{
    public partial class Form1 : Form
    {
        Form2 form = new Form2();
        public Form1()
        {
            InitializeComponent();
            this.button3.Enabled = true;
            this.button4.Enabled = false;
            
        }
        public void Task1()
        {
            string a = textBox1.Text;
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] >= '0' && a[i] <= '9')
                    {

                        throw new Exception("Введенная последовательность символов не является словом");
                    }

                }
                try
                {
                    string b = textBox2.Text;
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (b[i] >= '0' && b[i] <= '9')
                        {

                            throw new Exception("Введенная последовательность символов не является словом");
                        }

                    }
                    if (a.Length > b.Length)
                    {
                        int count = 0;
                        count = a.Length - b.Length;
                        label1.Text = ($"1 слово длиннее на {count} символов");
                    }
                    else if (a.Length < b.Length)
                    {
                        int count = 0;
                        count = b.Length - a.Length;
                        label1.Text = ($"2 слово длиннее на {count} символов");

                    }
                    else
                    {
                        if (textBox2.Text.Length == 0 || textBox1.Text.Length == 0) { label1.Text = "Неправильно введены данные!"; }
                       else label1.Text = ($"Оба слова равны по длине");
                    }
                }
                catch (Exception err)
                {
                    { MessageBox.Show($"{err.Message}", "Ошибка"); }
                }
            }
            catch (Exception err) { MessageBox.Show($"{err.Message}", "Ошибка"); }
        
    }
        private void button1_Click(object sender, EventArgs e)
        {
            Task1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button4.Enabled == true)
            {
                this.textBox3.Clear();
                this.textBox4.Clear();

                this.button3.Enabled = true;
                this.button4.Enabled = false;
            }
        }
        public void Task2()
        {
            if (this.button3.Enabled)
            {
                try
                {
                    string[] restr = textBox3.Text.Split(".".ToCharArray())[0].Split(",".ToCharArray());

                    if (restr is null) return;

                    int end = (restr.GetLength(0) - 1);

                    for (int i = 0; i < (restr.GetLength(0) / 2); i++)
                    {

                        string tmp = restr[i];
                        restr[i] = restr[end - i];
                        restr[end - i] = tmp;
                    }

                    foreach (var s in restr)
                    {
                        textBox4.Text += (s.ToString() + ",");
                    }
                }

                catch (Exception err) { MessageBox.Show($"{err.Message}", "Ошибка"); }
                this.button3.Enabled = false;
                this.button4.Enabled = true;
            }
        }
        public void Task3()
        {
            try
            {
                string strin = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩ";
                string sts = "бвгджзйклмнпрстфхцчшщ";
               
                string next = "";
                string enstr = "bcdfghjklmnpqrstvwxz";
                string ensts = "BCDFGHJKLMNPQRSTVWXZ";
                string str = textBox5.Text;
                for (int i = 0; i < str.Length; i++)
                {
                    next += str[i];
                    for (int j = 0; j < strin.Length; j++)
                    {
                        if (str[i] == strin[j])
                        {
                            next += str[i];

                        }
                        if (str[i] == sts[j]) { next += sts[j]; }

                    }
                    for (int n = 0; n < enstr.Length; n++)
                    {
                        if (str[i] == enstr[n])
                        {
                            next += str[i];

                        }
                        if (str[i] == ensts[n]) { next += ensts[n]; }
                    }
                }
                textBox6.Text = next.ToString();
            }
            catch (Exception err) { MessageBox.Show($"{err.Message}", ""); }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Task2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox5.Clear();
            this.textBox6.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task3();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
