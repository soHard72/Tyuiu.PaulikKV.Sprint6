using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PaulikKV.Sprint6.Task0.V9.Lib;

namespace Tyuiu.PaulikKV.Sprint6.Task0.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxVarB_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_PKV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {

                textBoxResult_PKV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_PKV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУб-23-3 Паулик Кирилл Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxVarX_PKV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void labelVarC_PKV_Click(object sender, EventArgs e)
        {

        }
    }
}
