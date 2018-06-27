using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSISP_TASK_8
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen pen;
        public Form1()
        {

            InitializeComponent();
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            g = this.CreateGraphics();

            g.DrawEllipse(pen, 0, 0, this.Width - 17, this.Height - 40);
        }
    }
}
