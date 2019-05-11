using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._16
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
            label4.ForeColor = Color.Black;
            label4.Text = "Выберите диагональ для транспонирования матрицы";
            int cell;
            j = 0;
            if (radioButton1.Checked == true)
            {
                for (i = 0; i < r; i++)
                    for (j = i; j < c; j++)
                    {
                        cell = a[i, j];
                        dataGridView2.Rows[i].Cells[j].Value = a[j, i];
                        dataGridView2.Rows[j].Cells[i].Value = cell;
                        if (i == j)
                        {
                            dataGridView1.Rows[i].Cells[j].Selected = true;
                            dataGridView2.Rows[i].Cells[j].Selected = true;
                        }
                    }
            }
            else if (radioButton2.Checked == true)
            {
                for (i = 0; i < r; i++)
                    for (j = r-1-i; j >= 0; j--)
                    {
                        cell = a[i, j];
                        dataGridView2.Rows[i].Cells[j].Value = a[r-1-j, r-1-i];
                        dataGridView2.Rows[r-1-j].Cells[r-1-i].Value = cell;
                        if (i == r-1-j)
                        {
                            dataGridView1.Rows[i].Cells[j].Selected = true;
                            dataGridView2.Rows[i].Cells[j].Selected = true;
                        }
                    }
            }
            else
            {
                label4.ForeColor = Color.Red;
                label4.Text = "                          Не выбрана диагональ!";
            }
        }
    }
}
