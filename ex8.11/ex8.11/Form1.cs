using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = 12;
            int c = 12;
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
            int s = 0;
            label4.Text = "Вывод: ";
            for (i = 0; i < r - 1; i++)
                s += a[i, i + 1];
            label4.Text += $"{s}";
       }
    }
}
