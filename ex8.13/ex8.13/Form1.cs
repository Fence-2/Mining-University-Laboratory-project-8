using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = 20;
            int c = 20;
            dataGridView1.RowCount = r + 2;
            dataGridView2.RowCount = r + 2;
            dataGridView1.ColumnCount = c + 2;
            dataGridView2.ColumnCount = c + 2;
            int[,] a = new int[r, c];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                    a[i, j] = rand.Next(-10, 10);
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                    dataGridView2.Rows[i].Cells[j].Value = "";
                }
            //Матрицы заполнены
            for (j = 0; j < c; j++)
                for (i = 0; i < r; i++)
                {
                    if (j == 0) //проверка на первый столбец
                    {
                        if ((a[i, j + 1]) <= a[i, j])
                            dataGridView2.Rows[i].Cells[j].Value = a[i, j];
                    }
                    else if (j >= 1 && j <= c - 2)
                    {
                        if ((a[i, j - 1]) <= a[i, j] && (a[i, j + 1]) <= a[i, j])
                            dataGridView2.Rows[i].Cells[j].Value = a[i, j];
                    }
                    else if (j == c - 1) // проверка на последний столбец
                    {
                        if ((a[i, j - 1]) <= a[i, j])
                            dataGridView2.Rows[i].Cells[j].Value = a[i, j];
                    }
                }
        }
    }
}
