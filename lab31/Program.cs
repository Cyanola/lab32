using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;

            while (choice != 0)
            {
                Console.Clear();
                Console.WriteLine("Выберите номер задания(2-4) и 0, чтобы выйти: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    //case 0:
                    //    {
                    //        break;
                    //    }
                    case 2:
                        {
                            Z1();
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Z2();
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Z3();
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такого задания не существует");
                            break;
                        }
                }
            }
        }
        public static void Z1()
        {
            int[] arr = new int[6];
            Random rnd = new Random();
            int i = 0, a = 0, n = 0;
            while (a < arr.Length) { arr[a] = rnd.Next(0, 1000); Console.Write($" {arr[a]}, "); a++; }
            Console.WriteLine();
            while (i < arr.Length)
            {
                if (arr[i] > 9 && arr[i] < 100) n++;
                i++;
            }
            Console.WriteLine($"Количество двузначных чисел в массиве: {n}");
        }
        public static void Z2()
        {
            int N = 5, K = 25;
            int i = 0;
            while (i < N)
            {
                Console.Write($" {K},");
                i++;
            }
        }
        public static void Z3()
        {
            Console.WriteLine("Введите последовательность чисел:");

            string[] str = Console.ReadLine().Split(" 0")[0].Split(' ');
            if (str is null) return;

            int a = 0;
            for (int i = 0; i < str.Length; i++)
            {
                try
                {
                    var x = int.Parse(str[i]);
                    a++;
                }
                catch (Exception error) { continue; }
            }
            Console.WriteLine($"Количество чисел в последовательности равно {a}");
        }

    }
}