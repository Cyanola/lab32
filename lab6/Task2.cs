using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
            this.Delete_Data.Enabled = false;
            this.Show_data.Enabled = true;
            this.button1.Enabled = true;
            this.button2.Enabled = false;
          
            this.button3.Enabled = false;

        }
        public static bool delete = false;
        public static bool add = false;
        public static bool ant = false;
        public class Human
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public string Post { get; set; }
        }
        public void addest()
        {
            if (!People.Contains(new Human())) 
            { 
            People.Add(new Human() { Name = comboBox1.Text, Age = (int)numericUpDown1.Value, Post = comboBox2.Text });
            People.Add(new Human() { Name = comboBox4.Text, Age = (int)numericUpDown2.Value, Post = comboBox3.Text });
            People.Add(new Human() { Name = comboBox6.Text, Age = (int)numericUpDown3.Value, Post = comboBox5.Text });
            }
            else MessageBox.Show("Такой элемент уже есть в коллекции", "Ошибка");

        }
        List<Human> People = new List<Human> { };
        public void T2()
        {
            addest();
            if (add==true)
            {
                foreach (Human h in People)
                {
                    string str = h.Name + " " + h.Post + " " + h.Age;
                    if (this.listBox1.Items.Contains(str)) { }
                    else
                    { 
                    this.listBox1.Items.Add(str);
                    }
                
                }
                add = false;
            }
            if (ant == true)
            {
                Human h = new Human();
                People.Add(new Human() {Name = comboBox7.Text, Age = (int)numericUpDown4.Value, Post = comboBox8.Text });
                h.Name = comboBox7.Text;
                h.Post = comboBox8.Text;
                h.Age = (int)numericUpDown4.Value;
                string row = h.Name + " " + h.Post + " " + h.Age;
                if (this.listBox1.Items.Contains(row)) { MessageBox.Show("Такой человек уже есть в коллекции", "Ошибка"); }
                else
                {
                    this.listBox1.Items.Add(row);
                }
                Delete_Data.Enabled = true;
            }
            button2.Enabled = true;
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Enabled)
            {
                addest();
                this.Show_data.Enabled = true;
                this.Delete_Data.Enabled = true;
                this.button1.Enabled = false;
               add = true;
                button2.Enabled = true;
                this.button3.Enabled = true;
            }
        }

        private void Show_data_Click(object sender, EventArgs e)
        {
            if (this.Show_data.Enabled)
            {
                
                this.button1.Enabled = false;
             
                T2();
                this.Show_data.Enabled = false;
                
            }
        }

        private void Delete_Data_Click(object sender, EventArgs e)
        {
            if (this.Delete_Data.Enabled)
            {
                addest();
                delete = true;
                if (delete == true)
                {
                    People.Clear(); this.listBox1.Items.Clear();
                }
                delete = false;
                Human h = new Human();
                if (h.Name =="" &&h.Post=="" &&h.Age == default(int) )
                {
                    this.Show_data.Enabled = false; //скрываем видимость кнопки
                    MessageBox.Show("Нет элементов для удаления", "Ошибка");
                }
                this.Delete_Data.Enabled = false;
                this.button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Enabled)
            {
                try
                {
                    if (listBox1.SelectedIndex >= 0)
                    {
                        People.RemoveAt(listBox1.SelectedIndex);
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    }
                  Human h = new Human();
                    if (h.Name == "" && h.Post == "" && h.Age == default(int))
                    {
                        this.Show_data.Enabled = false;
                         button2.Enabled = false;
                    this.Delete_Data.Enabled = false;
                        MessageBox.Show("Нет элементов для удаления", "Ошибка");

                    }
                    this.button1.Enabled = true;
                }
                catch (Exception err) { MessageBox.Show($"{err.Message}", "Ошибка"); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ant = true;
            T2();
            ant = false;
        }
    }
}
