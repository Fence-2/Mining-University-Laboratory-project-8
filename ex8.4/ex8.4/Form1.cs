using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = 15;
            int c = 15;
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
            //Матрица заполнена

            double avg = 0;
            int n = -1;
            for (j = 0; j < r; j++)
                if (a[j, 0] == 1)
                    n = j;
            if (n != -1)
            {
                for (i = 0; i < r; i++)
                    avg += a[n, i];
                avg /= r;
                label2.Text = $"Строка {n+1}," + Environment.NewLine + $"ср. арифм. = {avg}";
            }
            else
                label2.Text = "Строки нет";
        }
    }
}
