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

            this.button1.Enabled = true;
            this.button2.Enabled = false;
          
            this.button3.Enabled = false;

        }
        public static bool delete = false;
        public static bool add = false; //добавление 3 людей
        public static bool ant = false; //добавление нового человека
        public class Human //класс человек
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public string Post { get; set; }
        }
        public void addest() //добавление в лист трех челоевк
        {
            if (!People.Contains(new Human())) //если в листе нет точно таких же объектов класса
            { 
            People.Add(new Human() { Name = comboBox1.Text, Age = (int)numericUpDown1.Value, Post = comboBox2.Text });
            People.Add(new Human() { Name = comboBox4.Text, Age = (int)numericUpDown2.Value, Post = comboBox3.Text });
            People.Add(new Human() { Name = comboBox6.Text, Age = (int)numericUpDown3.Value, Post = comboBox5.Text });
            }
            else MessageBox.Show("Такой элемент уже есть в коллекции", "Ошибка");

        }
        List<Human> People = new List<Human> { };//объявление листа и его инициализация пустыми элементами
        public void T2()
        {
            addest();
            if (add==true) //если выполняется условие
            {
                foreach (Human h in People)
                {
                    string str = h.Name + " " + h.Post + " " + h.Age;
                    if (this.listBox1.Items.Contains(str)) { } //если листбокс уже содержит точно такую строку, то ничего
                    else
                    { 
                    this.listBox1.Items.Add(str);
                    }
                
                }
                add = false;//прекращаем выполнение
            }
            if (ant == true) //случай если добавляем 1 человека
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
                add = true;
                T2();
               
                this.Delete_Data.Enabled = true;
                this.button1.Enabled = false;
                button2.Enabled = true;
                this.button3.Enabled = true;
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
                    this.button1.Enabled = true;
                }
                catch (Exception err) { MessageBox.Show($"{err.Message}", "Ошибка"); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ant = true;
            T2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
