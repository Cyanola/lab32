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
          
          public string AdminName { get; set; }    
            public string AdminPost { get; set; }
          public  int workers { get; set; }
         public   double Area { get; set; }
       public     int floors { get; set; }

        }
        public struct Auto
        {
           public double speed { get; set; }
        public    string model { get; set; }
         public   int weight { get; set; }
        }
            public struct Human
            {
                public string Name { get; set; }
              public  string Lastname { get; set; }
               public int Age { get; set; }
              public  int Height { get; set; }

          
            }

        }
        
    
}
