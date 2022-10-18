using System;
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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
           
            this.Delete.Enabled = false;
            this.DeleteIndex.Enabled = false;
            this.Sort_.Enabled = false;
        }
      
        public static string Str_Remove = ""; //строка для удаления элемента листа
        public static int X_remove = default; //индекс для удаления элемента листа

        List<string> Food_Basket = new List<string>();//объявление лист

        private void Add__Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            try
            {
                if (str =="") throw new Exception("Не введено значение!");
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= '0' && str[i] <= '9')
                    {

                        throw new Exception("В названии продукта не должно быть цифр!");
                    }
                }
                if (!Food_Basket.Contains(str))
                {
                    Food_Basket.Add(str);
                }
                else MessageBox.Show("Такой элемент уже есть в коллекции", "Ошибка");
             
                this.Delete.Enabled = true;
                this.DeleteIndex.Enabled = true;
                this.Sort_.Enabled = true;
                foreach (string s in Food_Basket)
                {
                    if (listBox1.Items.Contains(s)) { }
                    else { listBox1.Items.Add(s); }
                }
                textBox1.Clear();
            }
            catch (Exception err) { MessageBox.Show($"{err.Message}", "Ошибка"); }
        }

        private void Sort__Click(object sender, EventArgs e)
        {
            if (Food_Basket.Count > 1) //сортировка
            {
                listBox1.Items.Clear();
                Food_Basket.Sort();
                foreach (string s in Food_Basket)
                {
                    listBox1.Items.Add(s);
                }
            }
            else MessageBox.Show("Недостаточно элементов для сортировки!", "");

        }
        private void Delete_Click(object sender, EventArgs e)
        {
            string item = textBox2.Text;
          
            try
            {
                if (item == "") throw new Exception("Не введено значение!");
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] >= '0' && item[i] <= '9')
                    {

                        throw new Exception("В названии продукта не должно быть цифр!");
                    }
                }
                if (Food_Basket.Contains(item))
                {
                    Str_Remove = item;
                    Food_Basket.Remove(item);
                    listBox1.Items.Remove(Str_Remove);
                  
                } else MessageBox.Show($"Такого элементa нет в коллекции", "Ошибка");
                textBox2.Clear();
            } catch(Exception err) { MessageBox.Show($"{err.Message}", "Ошибка"); }
        }
        private void DeleteIndex_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textBox6.Text;
                if (int.TryParse(str, out X_remove))//конвертируем текстбокс в инт
                {
                    //если введенный индекс больше количества элементов -1 в листе
                    if (X_remove > Food_Basket.Count - 1) throw new Exception("Элемента с таким индексом не существует!");
                    else Food_Basket.RemoveAt(X_remove); listBox1.Items.RemoveAt(X_remove);
                }
                else { MessageBox.Show("Введено нецелочисленное значение!"); }
                textBox6.Clear();
            }
            catch (Exception err) { MessageBox.Show($"{err.Message}", "Ошибка"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
