using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab42
{
 public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           
        }
      
           
            public struct AdminBuild
        {

            public string AdminName;
            public string AdminPost;
            public int workers;
            public double Area;
            public int floors;

        }
        public struct Auto
        {
            public double speed;
            public string model;
            public int weight;
        }
            public struct Human
            {
            public string Name;
            public string Lastname;
            public int Age;
            public int Height;

          
            }

        }
        
    
}
