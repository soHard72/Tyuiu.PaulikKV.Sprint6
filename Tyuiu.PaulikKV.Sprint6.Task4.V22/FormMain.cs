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
using Tyuiu.PaulikKV.Sprint6.Task4.V22.Lib;

namespace Tyuiu.PaulikKV.Sprint6.Task4.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTask_PKV_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_PKV_Click(object sender, EventArgs e)
        {
            try
            {
                int StartStep = Convert.ToInt32(textBoxStartValue_PKV.Text);
                int StopStep = Convert.ToInt32(textBoxStopValue_PKV.Text);

                int len = ds.GetMassFunction(StartStep, StopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(StartStep, StopStep);

                this.chartFunction_PKV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PKV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_PKV.Text = "";

                chartFunction_PKV.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                this.chartFunction_PKV.Series[0].Points.AddXY(StartStep, valueArray[i]);
                textBoxResult_PKV.AppendText(valueArray[i] + Environment.NewLine);
                StartStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_PKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-3 Паулик Кирилл Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_PKV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V22.txt";
                File.WriteAllText(path, textBoxResult_PKV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
