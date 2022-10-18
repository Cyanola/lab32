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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            System.Drawing.Drawing2D.GraphicsPath path2 = new System.Drawing.Drawing2D.GraphicsPath();
            path2.AddEllipse(0, 0, 70, 70);
            Region rgn2 = new Region(path2);
            button5.Region = rgn2;
            System.Drawing.Drawing2D.GraphicsPath path1 = new System.Drawing.Drawing2D.GraphicsPath();
            path1.AddEllipse(0, 0, 70, 70);
            Region rgn1 = new Region(path1);
            button4.Region = rgn1;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 70, 70);
            Region rgn = new Region(path);
            button3.Region = rgn;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            new Task1().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Task2().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Task3().ShowDialog();
        }
    }
}
