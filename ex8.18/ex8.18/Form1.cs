using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int N = Int32.Parse(textBox2.Text);
            int r = N;
            int c = N;
            dataGridView1.RowCount = r + 2;
            dataGridView1.ColumnCount = c + 2;
            int[,] a = new int[r, c];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < r + 2; i++)
            {
                for (j = 0; j < c + 2; j++)
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
            i = j = 0;
            int g, s = 0, k = 1;
            //Заполнение первой половины
            for (g = 0; g < N; g++)
            {
                if (g % 2 == 0)
                {
                    for (s = 0; s < g + 1; s++)
                    {
                        a[i, j] = k;
                        dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                        k++;
                        if (j != 0)
                        {
                            i += 1;
                            j -= 1;
                        }
                        else
                        {
                            i = g + 1;
                            j = 0;
                        }
                    }
                }
                else if (g % 2 != 0)
                {
                    for (s = 0; s < g + 1; s++)
                    {
                        a[i, j] = k;
                        dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                        k++;
                        if (i != 0)
                        {
                            i -= 1;
                            j += 1;
                        }
                        else
                        {
                            j = g + 1;
                            i = 0;
                        }
                    }
                }
                if (g == N - 1)
                {
                    if (g % 2 == 0)
                    {
                        i = N - 1;
                        j = 1;
                    }
                    else if (g % 2 != 0)
                    {
                        i = 1;
                        j = N - 1;
                    }
                }
            }
            //Заполнение второй половины
            if (N % 2 != 0)
            {
                for (g = 0; g < N - 1; g++)
                {
                    if (g % 2 == 0)
                    {
                        for (s = 0; s < N - g - 1; s++)
                        {
                            a[i, j] = k;
                            dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                            k++;
                            if (j != N - 1)
                            {
                                i -= 1;
                                j += 1;
                            }
                            else
                            {
                                i += 1;
                            }
                        }
                    }
                    else if (g % 2 != 0)
                    {
                        for (s = 0; s < N - g - 1; s++)
                        {
                            a[i, j] = k;
                            dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                            k++;
                            if (i != N - 1)
                            {
                                i += 1;
                                j -= 1;
                            }
                            else
                            {
                                j += 1;
                            }
                        }
                    }
                }
            }
            else
            {
                for (g = 0; g < N - 1; g++)
                {
                    if (g % 2 == 0)
                    {
                        for (s = 0; s < N - g - 1; s++)
                        {
                            a[i, j] = k;
                            dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                            k++;
                            if (i != N - 1)
                            {
                                i += 1;
                                j -= 1;
                            }
                            else
                            {
                                j += 1;
                            }
                        }
                    }
                    else if (g % 2 != 0)
                    {
                        
                        for (s = 0; s < N - g - 1; s++)
                        {
                            a[i, j] = k;
                            dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                            k++;
                            if (j != N - 1)
                            {
                                i -= 1;
                                j += 1;
                            }
                            else
                            {
                                i += 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
