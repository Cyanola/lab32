using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

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
            Application.Run(new Form2());

           
        }
      
           
            public struct AdminBuild
        {

            public string AdminName;
            public string AdminPost;
            public string workers;
            public string Area;
            public string floors;
           
        }
        public struct Auto
        {
            public string speed;
            public string model;
            public string weight;
          
        }
            public struct Human
            {
            public string Name;
            public string Lastname;
            public string Age;
            public string Height;

          
        }


        }
        
    
}
