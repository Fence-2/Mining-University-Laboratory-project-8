using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = 7;
            int c = 7;
            dataGridView1.RowCount = r + 2;
            dataGridView2.RowCount = r + 2;
            dataGridView1.ColumnCount = c + 2;
            dataGridView2.ColumnCount = c + 2;
            int[,] a = new int[r, c];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                    a[i, j] = rand.Next(-100, 100);
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                    dataGridView2.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
            //Матрицы заполнены
            int max = int.MinValue;
            for (i = 0; i < r; i++)
                if (a[i, i] > max)
                    max = a[i, i];
            for (i = 0; i < r; i++)
                if (a[i, r - 1 - i] > max)
                    max = a[i, r - 1 - i];
            dataGridView2.Rows[r / 2].Cells[c / 2].Value = max;
        }
    }
}
