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
                Console.WriteLine("Выберите номер задания(1-4) и 0, чтобы выйти: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                }
        public void  Task1()
        {
            Random random = new Random();
            double k;
            k = random.Next();
        }
        public void Task2()
        {
           int[] A = new int[10];
           int[] B = new int[10];
            Random rnd = new Random();
            double sumA = 0, sumB = 0;
            for (int i = 0;i < A.Length; i++)
            {
                A[i] = rnd.Next();
                sumA += A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = rnd.Next();
                sumB += B[i];
            }
            if (sumA < sumB)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"{A[i]}");

                        }
            }
            else
            {
                for (int i = 0; i < B.Length; i++)
                {
                    Console.Write($"{B[i]}");

                }
            }
        }
        }
    }

