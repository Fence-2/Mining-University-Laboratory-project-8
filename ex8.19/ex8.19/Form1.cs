using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int r = 8;
            int c = 8;
            dataGridView1.RowCount = r + 2;
            dataGridView1.ColumnCount = c + 2;
            int[,] a = new int[r, c];
            int i, j;
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                    a[i, j] = 0;
            for (i = 0; i < r; i++)
                for (j = 0; j < c; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 0;
                    dataGridView1.Rows[i].Cells[j].Selected = false;
                }
            //матрица заполнена

            int k = 1;
            Random rand = new Random();
            i = rand.Next(0, 8);
            j = rand.Next(0, 8);
            a[i, j] = 1;
            dataGridView1.Rows[i].Cells[j].Value = a[i, j];

            int Up_R, R_Up, R_Down, Down_R, Down_L, L_Down, L_Up, Up_L, g, rg;
            while (k < 65)
            {
                Up_R = R_Up = R_Down = Down_R = Down_L = L_Down = L_Up = Up_L = 1;
                if (i < 2 || j == 7)
                    Up_R = 0;
                else if (j != 7 && a[i - 2, j + 1] != 0)
                    Up_R = 0;

                if (i == 0 || j > 5)
                    R_Up = 0;
                else if (j <= 5 && a[i - 1, j + 2] != 0)
                    R_Up = 0;

                if (i == 7 || j > 5)
                    R_Down = 0;
                else if (j <= 5 && a[i + 1, j + 2] != 0)
                    R_Down = 0;

                if (i > 5 || j == 7)
                    Down_R = 0;
                else if (j != 7 && a[i + 2, j + 1] != 0)
                    Down_R = 0;

                if (i > 5 || j == 0)
                    Down_L = 0;
                else if (j != 0 && a[i + 2, j - 1] != 0)
                    Down_L = 0;

                if (i == 7 || j < 2)
                    L_Down = 0;
                else if (j >= 2 && a[i + 1, j - 2] != 0)
                    L_Down = 0;

                if (i == 0 || j < 2)
                    L_Up = 0;
                else if (j >= 2 && a[i - 1, j - 2] != 0)
                    L_Up = 0;

                if (i < 2 || j == 0)
                    Up_L = 0;
                else if (j != 0 && a[i - 2, j - 1] != 0)
                    Up_L = 0;

                g = 0;
                while (g == 0)
                {
                    rg = rand.Next(1, 9);
                    if (rg == 1)
                        if (Up_R == 1)
                        {
                            i -= 2;
                            j += 1;
                            g++;
                            k++;
                        }

                    if (rg == 2)
                        if (R_Up == 1)
                        {
                            i -= 1;
                            j += 2;
                            g++;
                            k++;
                        }

                    if (rg == 3)
                        if (R_Down == 1)
                        {
                            i += 1;
                            j += 2;
                            g++;
                            k++;
                        }

                    if (rg == 4)
                        if (Down_R == 1)
                        {
                            i += 2;
                            j += 1;
                            g++;
                            k++;
                        }

                    if (rg == 5)
                        if (Down_L == 1)
                        {
                            i += 2;
                            j -= 1;
                            g++;
                            k++;
                        }

                    if (rg == 6)
                        if (L_Down == 1)
                        {
                            i += 1;
                            j -= 2;
                            g++;
                            k++;
                        }

                    if (rg == 7)
                        if (L_Up == 1)
                        {
                            i -= 1;
                            j -= 2;
                            g++;
                            k++;
                        }

                    if (rg == 8)
                        if (Up_L == 1)
                        {
                            i -= 2;
                            j -= 1;
                            g++;
                            k++;
                        }
                    if (Up_R == 0 && R_Up == 0 && R_Down == 0 && Down_R == 0 && Down_L == 0 && L_Down == 0 && L_Up == 0 && Up_L == 0)
                        break;
                }
                if (Up_R == 0 && R_Up == 0 && R_Down == 0 && Down_R == 0 && Down_L == 0 && L_Down == 0 && L_Up == 0 && Up_L == 0)
                {
                    dataGridView1.Rows[i].Cells[j].Selected = true;
                    break;
                }
                a[i, j] = k;
                dataGridView1.Rows[i].Cells[j].Value = a[i, j];
            }
        }
    }
}
