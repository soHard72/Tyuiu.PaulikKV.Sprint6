using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PaulikKV.Sprint6.Task3.V8.Lib;

namespace Tyuiu.PaulikKV.Sprint6.Task3.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -10, 10, -7, 19, 6 },
                                        { 15, 13, -19, 9, 1},
                                        { -20, -15, -6, 8, -4},
                                        { 10, 18, -5, 9, -6 },
                                        { 16, -10, 4, 15, 16 }};

        private void buttonHelp_PKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-3 Паулик Кирилл Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_PKV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] matrx = new int[5, 5]{ { -10, 10, -7, 19, 6 },
                                          { 15, 13, -19, 9, 1},
                                          { -20, -15, -6, 8, -4},
                                          { 10, 18, -5, 9, -6 },
                                          { 16, -10, 4, 15, 16 }};
            int[,] mtrx = ds.Calculate(matrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult_PKV.ColumnCount = columns;
            dataGridViewResult_PKV.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (Math.Abs(matrix[3, j]) % 2 == 0)
                    {
                        matrix[3, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = matrix[i, j];
                    }
                    dataGridViewResult_PKV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewResult_PKV.ColumnCount = columns;
            dataGridViewResult_PKV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_PKV.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_PKV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void dataGridViewResult_PKV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
