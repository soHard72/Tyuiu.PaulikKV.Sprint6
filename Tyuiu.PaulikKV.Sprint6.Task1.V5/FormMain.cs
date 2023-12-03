using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PaulikKV.Sprint6.Task1.V5.Lib;

namespace Tyuiu.PaulikKV.Sprint6.Task1.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelStart_PKV_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_PKV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_PKV.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_PKV.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxTable_PKV.Text = "";
                textBoxTable_PKV.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxTable_PKV.AppendText("|    X     +    f(x)   |" + Environment.NewLine);
                textBoxTable_PKV.AppendText("+----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxTable_PKV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxTable_PKV.AppendText("+----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-3 Паулик Кирилл Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
