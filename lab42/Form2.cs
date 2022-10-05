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
using static lab42.Program;
namespace lab42
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form1 form = new Form1();
           form.Massiv();
        }
        
        public object[][] Input()
        {
            object[][] array = new object[][] { };
            Form1 form = new Form1();
            array = form.Massiv();
            int.TryParse(this.numericUpDown1.Text, out int x);
            int.TryParse(this.numericUpDown2.Text, out int y);
            int.TryParse(this.numericUpDown3.Text, out int a);
            int.TryParse(this.numericUpDown5.Text, out int b);
            double.TryParse(this.numericUpDown4.Text, out double m);
            for (int i = 0; i < array[0].Length; i++)
            {
                if (i == 2) array[0][2] = x;
                if (i == 0) array[0][0] = this.comboBox1.Text;
                if (i == 1) array[0][1] = this.comboBox2.Text;
                if (i == 3) array[0][3] = y;
            }
            for (int i = 0; i < array[1].Length; i++)
            {
                if (i == 2) array[1][2] = a;
                if (i == 0) array[1][0] = this.comboBox3.Text;
                if (i == 1) array[1][1] = this.comboBox4.Text;
                if (i == 3) array[1][3] = m;
                if (i == 4) array[1][4] = b;
            }
            int.TryParse(this.numericUpDown7.Text, out int e);
            double.TryParse(this.numericUpDown6.Text, out double o);
            for (int i = 0; i < array[2].Length; i++)
            {
                if (i == 2) array[2][2] = e;
                if (i == 0) array[2][0] = o;
                if (i == 1) array[2][1] = this.comboBox5.Text;

            }
            return array;
  
        }
        public Program.Human human = new Program.Human();
        public Program.AdminBuild admin = new Program.AdminBuild();
        public Program.Auto autos = new Program.Auto();

        private void button1_Click(object sender, EventArgs e)
        {
            Input();
            this.Close();
        }
    }
}
