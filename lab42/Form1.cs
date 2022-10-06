using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab42.Program;
namespace lab42
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Massiv();

        }

     
    
        
        public Program.Human human = new Program.Human();
        public Program.AdminBuild admin = new Program.AdminBuild();
        public Program.Auto autos = new Program.Auto();
        public object[][] Massiv()
        {

            object[][] array = new object[][]
          {
           new object[] { human.Name, human.Lastname, human.Age,  human.Height },
           new object[] {admin.AdminName, admin.AdminPost, admin.workers, admin.Area, admin.floors },
           new object[] {autos.speed, autos.model, autos.weight}
          };
            return array;
        }
        public void Output()
        {
           Form2 form = new Form2();
            for(int i = 0; i < form.Input().GetLength(0); i++)
            {
                label1.Text = form.Input()[0][i].ToString();
            }
            //foreach(object var in form.Input()[0])
            //{
            //    label1.Text = var.ToString();

            //}
       //    label1.Text = form.Input()[0].ToString();
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Output();
         
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
