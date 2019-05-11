using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._6
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
            int max = int.MinValue;
            int n = 0;
            for (i = 0; i < 15; i++)
            {
                if (a[i, i] > max)
                {
                    max = a[i, i];
                    n = i;
                }
            }
            dataGridView1.Rows[0].Cells[16].Value = n+1;
            for (j = 0; j < 15; j++)
                dataGridView1.Rows[16].Cells[j].Value = a[n, j];
        }
    }
}
