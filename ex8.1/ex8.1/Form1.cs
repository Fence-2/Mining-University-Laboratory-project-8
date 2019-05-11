using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 6;
            int[,] a = new int[3, 4];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 3; i++)
                for (j = 0; j < 4; j++)
                    a[i, j] = rand.Next(-100, 100);
            for (i = 0; i < 3; i++)
                for (j = 0; j < 4; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
            int m;
            for (i = 0; i < 3; i++)
            {
                m = int.MaxValue;
                for (j = 0; j < 4; j++)
                {
                    if (a[i, j] < m)
                    {
                        m = a[i, j];
                        dataGridView1.Rows[i].Cells[5].Value = Convert.ToString(m);
                    }
                }
            }
        }
    }
}
