using System;
using System.Linq;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace lab51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;

            while (choice != 0)
            {
                Console.Clear();
                Console.WriteLine("Выберите номер задания(1-3) и 0, чтобы выйти: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0: break;
                        case 1:
                            {
                                Console.Clear();
                                Task1();
                                Console.ReadKey();
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                Task2();
                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                Task3();
                                Console.ReadKey();
                                break;
                            }


                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("Такого задания не существует!");
                                Console.ReadKey();
                                break;
                            }
                    }
                }
                catch (Exception err) { Console.WriteLine(err.Message); Console.ReadKey(); }
            }

        }

        public static void Task1()
        {
            String str = "";
            String strow = "";

            Console.WriteLine("Введите 1 слово:");
            try
            {
                str = Console.ReadLine();

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= '0' && str[i] <= '9')
                    {

                        throw new Exception("Введенная последовательность символов не является словом");
                    }

                }
                try
                {
                    Console.WriteLine("Введите 2 слово:");
                    strow = Console.ReadLine();
                    for (int i = 0; i < strow.Length; i++)
                    {
                        if (strow[i] >= '0' && strow[i] <= '9')
                        {

                            throw new Exception("Введенная последовательность символов не является словом");
                        }
                    }
                    if (str.Length > strow.Length)
                    {
                        int count = 0;
                        count = str.Length - strow.Length;
                        Console.WriteLine($"1 слово длиннее на {count} символов");
                    }
                    else if (str.Length < strow.Length)
                    {
                        int count = 0;
                        count = strow.Length - str.Length;
                        Console.WriteLine($"2 слово длиннее на {count} символов");

                    }
                    else
                    {
                        int count = 0;
                        Console.WriteLine($"Оба слова равны по длине");
                    }
                }
                catch (Exception err)
                {
                    { Console.WriteLine($"Ошибка: {err.Message}"); }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
        public static void Task3()
        {
            string str = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩ";
            string sts = "бвгджзйклмнпрстфхцчшщ";
            string s = "";
            string next = "";
            string enstr = "bcdfghjklmnpqrstvwxz";
            string ensts = "BCDFGHJKLMNPQRSTVWXZ";
            Console.WriteLine("Введите строку: ");
            try
            {
                s = Console.ReadLine();

                for (int i = 0; i < s.Length; i++)
                {
                    next += s[i];
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (s[i] == str[j])
                        {
                            next += s[i];

                        }
                        if (s[i] == sts[j]) { next += sts[j]; }

                    }
                    for (int n = 0; n < enstr.Length; n++)
                    {
                        if (s[i] == enstr[n])
                        {
                            next += s[i];

                        }
                        if (s[i] == ensts[n]) { next += ensts[n]; }
                    }
                }
                Console.WriteLine($"\n\nНовая строка: \n\n{next}");
            }
            catch (Exception err) { Console.WriteLine($"Ошибка: {err.Message}"); }
        }
        public static void Task2()
        {
            
            Console.WriteLine("Введите последовательность слов: ");
            try
            {
                string[] str = Console.ReadLine().Split('.')[0].Split(',');
                if (str is null) return;

                int end = (str.Length - 1);

                for (int i = 0; i < (str.Length / 2); i++)
                {

                    string tmp = str[i];
                    str[i] = str[end - i];
                    str[end - i] = tmp;
                   
                }
                Console.WriteLine($"\n\nПоследовательность слов в обратном порядке: \n\n");
                foreach (var s in str)
                {
                    Console.Write(s + ",");
                }
                }
            catch (Exception err) { Console.WriteLine($"Ошибка: {err.Message}"); }
        }
    }
}
        
    

    



