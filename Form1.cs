using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortings
{
    public partial class Form1 : Form
    {
        int[] tomb;
        Graphics grafika;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            grafika = panel1.CreateGraphics();
            int szelesseg = panel1.Width;
            int maximum = panel1.Height;
            tomb = new int[szelesseg];
            grafika.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, szelesseg, maximum);
            Random random = new Random();
            for (int i = 0; i < szelesseg; i++)
            {
                tomb[i] = random.Next(0, maximum);
            }
            for (int i = 0; i < szelesseg; i++)
            {
                grafika.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Khaki), i, maximum-tomb[i], 1, maximum);
            }
        }

        

        private void Bubble_Click(object sender, EventArgs e)
        {
            ISortings BubbleSort = new BubbleSorting();
            BubbleSort.DoSorting(tomb, grafika, panel1.Height);
        }

    }
}
