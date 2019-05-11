using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                dataGridView1.RowCount = 5;
                dataGridView1.ColumnCount = 5;
                int[,] a = new int[3, 3];
                int i, j;
                Random rand = new Random();
                for (i = 0; i < 3; i++)
                    for (j = 0; j < 3; j++)
                        a[i, j] = rand.Next(-100, 100);
                for (i = 0; i < 3; i++)
                    for (j = 0; j < 3; j++)
                        dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                int m = 1;
                for (i = 0; i < 3; i++)
                {
                    m *= a[i, 0];
                }
                dataGridView1.Rows[4].Cells[0].Value = m;

                m = 0;
                for (j = 0; j < 3; j++)
                {
                    m += a[1, j];
                }
                dataGridView1.Rows[1].Cells[4].Value = m;
            }
        }
    }
}
