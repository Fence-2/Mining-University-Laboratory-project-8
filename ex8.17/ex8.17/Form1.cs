using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Int32.Parse(textBox2.Text);
            int r = N;
            int c = N;
            dataGridView1.RowCount = r + 2;
            dataGridView1.ColumnCount = c + 2;
            int[,] a = new int[r, c];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < r+2; i++)
            {
                for (j = 0; j < c+2; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = "";
                }
            }
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                    a[i, j] = 0;
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
            //матрица заполнена
            int k = 1;
            i = j = 0;
            //создаём границы во избежание ошибок
            for (j = 0, i = 0; j < c; j++)
            {
                a[i, j] = k;
                dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                k++;
            }
            for (j = c - 1, i = 1; i < r; i++)
            {
                a[i, j] = k;
                dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                k++;
            }
            for (j = c - 2, i = r - 1; j >= 0; j--)
            {
                a[i, j] = k;
                dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                k++;
            }
            for (j = 0, i = r - 2; i >= 1; i--)
            {
                a[i, j] = k;
                dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                k++;
            }
            //границы созданы
            i = j = 1;
            int h;
            double g = r;
            //заполняем всё остальное
            for (h = 0; h < r - 2; h++)
            {
                while (a[i, j + 1] == 0)
                {
                    a[i, j] = k;
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                    k++;
                    j++;
                }
                while (a[i + 1, j] == 0)
                {
                    a[i, j] = k;
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                    k++;
                    i++;
                }
                while (a[i, j - 1] == 0)
                {
                    a[i, j] = k;
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                    k++;
                    j--;
                }
                while (a[i - 1, j] == 0)
                {
                    a[i, j] = k;
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                    k++;
                    i--;
                }
                if (h == r - 3 && g % 2 == 0)
                {
                    a[r / 2, c / 2 - 1] = k;
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                }
                else if (h == r - 3 && g % 2 != 0)
                {
                    a[r / 2, c / 2] = k;
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                }
            }
        }
    }
}
