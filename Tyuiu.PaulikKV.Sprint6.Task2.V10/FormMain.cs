using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PaulikKV.Sprint6.Task2.V10.Lib;

namespace Tyuiu.PaulikKV.Sprint6.Task2.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_PKV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_PKV.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_PKV.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_PKV.Titles.Add("График функции");

                this.chartFunction_PKV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PKV.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_PKV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_PKV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFunction_PKV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_PKV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PKV.BackColor = Color.Red;
        }

        private void buttonDone_PKV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PKV.BackColor = Color.ForestGreen;
        }

        private void groupBoxOutput_PKV_Enter(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-3 Паулик Кирилл Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
