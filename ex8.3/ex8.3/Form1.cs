using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = 10;
            int c = 10;
            dataGridView1.RowCount = r + 2;
            dataGridView1.ColumnCount = c + 2;
            double[,] a = new double[r, c];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                    a[i, j] = rand.Next(-10, 10);
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();

            double s, mas;
            s = 0;
            for (i = 0; i < 10; i++)
                s += a[i, i];

            dataGridView1.Rows[0].Cells[11].Value = $"S = {s}";
            if (s > 10)
            {
                for (i = 0; i < 10; i++)
                    for (j = 0; j < 10; j++)
                    {
                        mas = 0;
                        mas = a[i, j] + 13.5;
                        dataGridView1.Rows[i].Cells[j].Value = mas;
                    }
            }
            if (s <= 10)
            {
                for (i = 0; i < 10; i++)
                    for (j = 0; j < 10; j++)
                    {
                        mas = 0;
                        mas = a[i, j] * a[i, j] - 1.5;
                        dataGridView1.Rows[i].Cells[j].Value = mas;
                    }
            }
        }
    }
}
