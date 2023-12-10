using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.PaulikKV.Sprint6.Task5.V6.Lib;

namespace Tyuiu.PaulikKV.Sprint6.Task5.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\User\source\repos\Tyuiu.PaulikKV.Sprint6\Tyuiu.PaulikKV.Sprint6.Task5.V6\bin\Debug\InPutFileTask5V6.txt";
        private void buttonDone_PKV_Click(object sender, EventArgs e)
        {
            dataGridViewOutput_PKV.ColumnCount = 2;
            dataGridViewOutput_PKV.Columns[0].Width = 20;
            dataGridViewOutput_PKV.Columns[1].Width = 50;

            this.chartFunction_PKV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_PKV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_PKV.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutput_PKV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_PKV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonHelp_PKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-3 Паулик Кирилл Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_PKV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void dataGridViewOutput_PKV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
