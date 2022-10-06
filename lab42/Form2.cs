using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static lab42.Program;
namespace lab42
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Delete_Data.Enabled = false;
            this.Show_data.Enabled = false; //видимость кнопки показать данные, чтобы не показывать массив с пустыми элементами
            this.Input_button.Enabled = true;
        }

        public static bool but = false; //перемер=нная шоб по миллиону раз не заполнять листбокс

        public string[][] Massiv() //массив массивов, в качестве его элементов выступают структуры, со своими полями
        {

            string[][] array = new string[][]
          {
           new string[] { human.Name, human.Lastname, human.Age,  human.Height },
           new string[] {admin.AdminName, admin.AdminPost, admin.workers, admin.Area, admin.floors },
           new string[] { autos.model, autos.speed, autos.weight}
          };
            return array;
        }
        public string[][] Input() //заполнение массива
        {
          string[][] array = new string [][] { };
          
            array = Massiv();
          
           array[0][2] = this.numericUpDown1.Text;
              array[0][0] = this.comboBox1.Text;
              array[0][1] = this.comboBox2.Text;
            array[0][3] = this.numericUpDown2.Text;
          
               array[1][2] = this.numericUpDown3.Text;
              array[1][0] = this.comboBox3.Text;
              array[1][1] = this.comboBox4.Text;
               array[1][3] = this.numericUpDown4.Text;
                array[1][4] = this.numericUpDown5.Text;
     
           
        
            
              array[2][2] = this.numericUpDown7.Text;
              array[2][0] = this.comboBox5.Text;
            array[2][1] = this.numericUpDown6.Text;

            return array;
  
        }
        public Program.Human human = new Program.Human(); //объекты структур для функции Massiv()
        public Program.AdminBuild admin = new Program.AdminBuild();
        public Program.Auto autos = new Program.Auto();

        private void Input_button_Click(object sender, EventArgs e)
        {
            if (this.Input_button.Enabled)
            {
                Input();
                this.Show_data.Enabled = true; //видно кнопочку
                this.Delete_Data.Enabled = true;
                but = true; // для заполнения листбокса
                this.Input_button.Enabled = false;
            }
        }

        public void Output()
        {
        
           string str1 = Input()[0][0] + " " + Input()[0][1] + " "+ Input()[0][2] + " "+ Input()[0][3];
               
            string str2 = Input()[1][0] + " " + Input()[1][1] + " " + Input()[1][2] + " " + Input()[1][3] + " " + Input()[1][4];
          
            string str3 = Input()[2][0] + " " + Input()[2][1] + " " + Input()[2][2];

            //если листбокс уже содержит какаие-то элементы в себе, то ничем новым не заполняем
            if (listBox1.Items.Contains(str1) || listBox1.Items.Contains(str2) || listBox1.Items.Contains(str3)) { } 
            else
            {
                if (but == true)
                {
                    but = false;
                    listBox1.Items.Add(str1);
                    listBox1.Items.Add(str2);
                    listBox1.Items.Add(str3);
                }
            }
         
        }
        private void Show_Data_Click(object sender, EventArgs e)
        {
            if (this.Show_data.Enabled) //если кнопочку видно
            {
                Output();
                this.Input_button.Enabled = false;
            }
        }

        private void Delete_Data_Click(object sender, EventArgs e)
        {
            if (this.Delete_Data.Enabled)
            {
                this.listBox1.Items.Clear(); //очищаем листбокс
                this.Show_data.Enabled = false; //скрываем видимость кнопки
                this.Delete_Data.Enabled = false;
                this.Input_button.Enabled = true;
            }
        }

    
    }
}
