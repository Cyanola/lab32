using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab52
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"1 Задание - Определить, какое из двух слов длиннее и на сколько.\n" +
                $"2 Задание - Дана последовательность, содержащая от 1 до 30 слов, в каждом из которых от 1 до 5 строчных латинских букв; между соседними словами -- запятая, за последним словом -- точка. Напечатать: эту же последовательность слов, но в обратном порядке.\n" +
                $"3 Задание - Удвоить все согласные буквы.","Вариант 1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();   
           
        }
    }
}
