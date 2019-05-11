using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._12
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
            dataGridView1.ColumnCount = c + 2;
            int[,] a = new int[r, c];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                    a[i, j] = rand.Next(-10, 10);
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
            //матрица заполнена
            int k, col, n;
            label4.Text = "Вывод: ";
            col = n = -1;
            for (j = 0; j < c; j++)
            {
                k = 0;
                for (i = 0; i < r; i++)
                    if (a[i, j] <= 0)
                        k++;
                if (k > col)
                {
                    col = k;
                    n = j;
                }
            }
            label4.Text += $"Столбец №{n+1}";
        }
    }
}
