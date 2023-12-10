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
using Tyuiu.PaulikKV.Sprint6.Task6.V24.Lib;

namespace Tyuiu.PaulikKV.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_PKV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PKV.ShowDialog();
            openFilePath = openFileDialogTask_PKV.FileName;
            textBoxInput_PKV.Text = File.ReadAllText(openFilePath);
            groupBoxInput_PKV.Text = groupBoxInput_PKV.Text + " " + openFileDialogTask_PKV.FileName;
            buttonDone_PKV.Enabled = true;
        }

        private void buttonDone_PKV_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxOutput_PKV.Text = ds.CollectTextFromFile(str,openFilePath);
        }

        private void buttonHelp_PKV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
