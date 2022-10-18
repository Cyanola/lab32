using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{

    public partial class Task3 : Form
    {
        
        public Task3()
        {
            InitializeComponent();
        }
        public void F()
        {
            Hashtable ht = new Hashtable();
                ht.Add(label2.Text, comboBox1.Text);
                ht.Add(label3.Text, comboBox2.Text);
                ht.Add(label4.Text, comboBox3.Text);
                ht.Add(label5.Text, comboBox4.Text);
                ht.Add(label6.Text, numericUpDown1.Value);
            ICollection C = ht.Keys;
            foreach(string str in C)
            {
                if (listBox1.Items.Contains(str)) { }
                else
                {
                    listBox1.Items.Add(str + ": " + ht[str]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F();
        }
    }
}
