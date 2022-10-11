using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab41
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
                    case 4:
                        {
                            Console.Clear();
                            Task4();
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
        }
        public static void  Task1()
        {
            Random random = new Random();
            double k;
            int n; int m;
            k = random.Next(-10,10);
            Console.WriteLine("Введите значение n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение m");
            m = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            double[,] mas= new double[n, m];
            Console.WriteLine($"При k = {k}");
            Console.WriteLine();
            Console.WriteLine("Одномерный массив: ");
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(n, k)/ (Math.Pow((n + 1), k)))),3,MidpointRounding.AwayFromZero);
                Console.Write($"{arr[i]}  ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Двумерный массив: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i,j] = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(n, k) / (Math.Pow((n + 1), k)))),3,MidpointRounding.AwayFromZero);
                    Console.Write($"{mas[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
        public static void Task2()
        {
           int[] A = new int[10];
           int[] B = new int[10];
            Random rnd = new Random();
            int sumA = 0, sumB = 0;
            for (int i = 0;i < A.Length; i++)
            {
                A[i] = rnd.Next(-100,100);
                sumA += A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = rnd.Next(-100,100);
                sumB += B[i];
            }
            if (sumA < sumB)
            {
                Console.WriteLine("Наименьшая сумма значений у массива А.");
                Console.WriteLine($"Она равна {sumA}");
                Console.WriteLine("Массив A:");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"{A[i]}, ");

                        }
                Console.WriteLine("");
                Console.WriteLine("Массив В:");
                for (int i = 0; i < B.Length; i++)
                {
                    Console.Write($"{B[i]}, ");

                }
            }
            else if (sumA==sumB)
            {
                Console.WriteLine("Суммы массивов одинаковы!.");
                Console.WriteLine($"Они равны {sumB}");
                Console.WriteLine("Массив A:");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"{A[i]}, ");

                }
                Console.WriteLine("");
                Console.WriteLine("Массив В:");
                for (int i = 0; i < B.Length; i++)
                {
                    Console.Write($"{B[i]}, ");

                }
               
               
            }
            else
            {
                Console.WriteLine("Наименьшая сумма значений у массива B.");
                Console.WriteLine($"Она равна {sumB}");
                Console.WriteLine("Массив В:"); 
                for (int i = 0; i < B.Length; i++)
                {
                    Console.Write($"{B[i]}, ");

                }
                Console.WriteLine("");
                Console.WriteLine("Массив A:");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"{A[i]}, ");

                }
            }
        }
        public static void Task4()
        {
            int[] arr = new int[10];
            Random r = new Random();
            Console.WriteLine("Сортировка простым выбором ");
            Console.WriteLine("Массив до сортировки: ");
            for (int i = 0; i < arr.Length; i++)
                {
                arr[i] = r.Next(-100,100);
                Console.Write($"{arr[i]}, ");
            }
              Console.WriteLine("\nМассив после сортировки: ");
            for (int i = 0; i < arr.Length; i++)
            {
                int m = i, s;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[m] >arr[j])
                    {
                        m = j;
                    }
                }
                s = arr[m]; 
               arr[m] = arr[i];
               arr[i] = s;
            }
           for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
        }
        public static void Task3()
        {
            int n, sum = 0;
            Console.WriteLine("Введите размер массива: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                int[,] A = new int[n, n];

                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        A[i, j] = r.Next(-100,100);
                        Console.Write($"{A[i, j]}, \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                       if (j>i)
                        {
                            sum+= A[i, j];
                        }
                     
                    }
                }
                Console.WriteLine($"Сумма всех элементов массива выше главной диагонали равна:\n {sum}");
            }
            catch { Exception error; }
           
        }
    }
  
    }

