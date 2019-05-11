using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = 3;
            int c = 3;
            dataGridView1.RowCount = r + 2;
            dataGridView1.ColumnCount = c + 2;
            int[,] a = new int[r, c];
            int i, j, z;
            Random rand = new Random();
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                    a[i, j] = rand.Next(-100, 100);
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                    dataGridView1.Rows[i].Cells[j].Selected = false;
                }
            
            //Матрицы заполнены
            int k = 0, n_col = 0, n_row = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            for (i = 0; i < r; i++)
            {
                max = int.MinValue;
                min = int.MaxValue;
                n_col = n_row = 0;
                for (j = 0; j < c; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        n_col = j;
                    }
                }
                for (z = 0; z < r; z++)
                {
                    if (a[z, n_col] > max)
                    {
                        max = a[z, n_col];
                        n_row = z;
                    }
                }
                if (n_row == i)
                {
                    k++;
                    dataGridView1.Rows[n_row].Cells[n_col].Selected = true;
                }
            }
            label4.Text = $"Вывод: седловых точек: {k}";
        }
    }
}
