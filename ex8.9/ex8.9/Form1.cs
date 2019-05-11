using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = 9;
            int c = 9;
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
                    dataGridView1.Rows[i].Cells[j].Selected = false;
                    dataGridView2.Rows[i].Cells[j].Selected = false;
                }
            //Матрицы заполнены
            int min = int.MaxValue;
            for (i = 0; i < r; i++)
            {
                min = int.MaxValue;
                for (j = 0; j < c; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
                dataGridView2.Rows[i].Cells[0].Value = min;
            }
        }
    }
}
