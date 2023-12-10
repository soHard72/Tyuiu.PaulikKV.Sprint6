
namespace Tyuiu.PaulikKV.Sprint6.Task6.V24
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOpenFile_PKV = new System.Windows.Forms.Button();
            this.buttonDone_PKV = new System.Windows.Forms.Button();
            this.openFileDialogTask_PKV = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonHelp_PKV = new System.Windows.Forms.Button();
            this.groupBoxTask_PKV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PKV = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PKV = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_PKV = new System.Windows.Forms.GroupBox();
            this.textBoxInput_PKV = new System.Windows.Forms.TextBox();
            this.textBoxOutput_PKV = new System.Windows.Forms.TextBox();
            this.groupBoxTask_PKV.SuspendLayout();
            this.groupBoxInput_PKV.SuspendLayout();
            this.groupBoxOutput_PKV.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile_PKV
            // 
            this.buttonOpenFile_PKV.BackColor = System.Drawing.Color.White;
            this.buttonOpenFile_PKV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_PKV.Image")));
            this.buttonOpenFile_PKV.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_PKV.Name = "buttonOpenFile_PKV";
            this.buttonOpenFile_PKV.Size = new System.Drawing.Size(77, 53);
            this.buttonOpenFile_PKV.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonOpenFile_PKV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_PKV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_PKV.Click += new System.EventHandler(this.buttonOpenFile_PKV_Click);
            // 
            // buttonDone_PKV
            // 
            this.buttonDone_PKV.BackColor = System.Drawing.Color.White;
            this.buttonDone_PKV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_PKV.Image")));
            this.buttonDone_PKV.Location = new System.Drawing.Point(95, 12);
            this.buttonDone_PKV.Name = "buttonDone_PKV";
            this.buttonDone_PKV.Size = new System.Drawing.Size(76, 53);
            this.buttonDone_PKV.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonDone_PKV, "Производит поиск в файле вхождений символов и конкатенирует строки, в которых нах" +
        "одятся эти символы");
            this.buttonDone_PKV.UseVisualStyleBackColor = false;
            this.buttonDone_PKV.Click += new System.EventHandler(this.buttonDone_PKV_Click);
            // 
            // openFileDialogTask_PKV
            // 
            this.openFileDialogTask_PKV.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_PKV
            // 
            this.buttonHelp_PKV.BackColor = System.Drawing.Color.White;
            this.buttonHelp_PKV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_PKV.Image")));
            this.buttonHelp_PKV.Location = new System.Drawing.Point(725, 13);
            this.buttonHelp_PKV.Name = "buttonHelp_PKV";
            this.buttonHelp_PKV.Size = new System.Drawing.Size(63, 52);
            this.buttonHelp_PKV.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonHelp_PKV, "Сведения о программе\r\n");
            this.buttonHelp_PKV.UseVisualStyleBackColor = false;
            this.buttonHelp_PKV.Click += new System.EventHandler(this.buttonHelp_PKV_Click);
            // 
            // groupBoxTask_PKV
            // 
            this.groupBoxTask_PKV.Controls.Add(this.textBoxTask_PKV);
            this.groupBoxTask_PKV.Location = new System.Drawing.Point(12, 72);
            this.groupBoxTask_PKV.Name = "groupBoxTask_PKV";
            this.groupBoxTask_PKV.Size = new System.Drawing.Size(776, 94);
            this.groupBoxTask_PKV.TabIndex = 3;
            this.groupBoxTask_PKV.TabStop = false;
            this.groupBoxTask_PKV.Text = "Условие";
            // 
            // textBoxTask_PKV
            // 
            this.textBoxTask_PKV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PKV.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_PKV.Multiline = true;
            this.textBoxTask_PKV.Name = "textBoxTask_PKV";
            this.textBoxTask_PKV.ReadOnly = true;
            this.textBoxTask_PKV.Size = new System.Drawing.Size(763, 68);
            this.textBoxTask_PKV.TabIndex = 0;
            this.textBoxTask_PKV.Text = resources.GetString("textBoxTask_PKV.Text");
            this.textBoxTask_PKV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxInput_PKV
            // 
            this.groupBoxInput_PKV.Controls.Add(this.textBoxInput_PKV);
            this.groupBoxInput_PKV.Location = new System.Drawing.Point(12, 173);
            this.groupBoxInput_PKV.Name = "groupBoxInput_PKV";
            this.groupBoxInput_PKV.Size = new System.Drawing.Size(387, 265);
            this.groupBoxInput_PKV.TabIndex = 4;
            this.groupBoxInput_PKV.TabStop = false;
            this.groupBoxInput_PKV.Text = "Ввод :";
            // 
            // groupBoxOutput_PKV
            // 
            this.groupBoxOutput_PKV.Controls.Add(this.textBoxOutput_PKV);
            this.groupBoxOutput_PKV.Location = new System.Drawing.Point(405, 173);
            this.groupBoxOutput_PKV.Name = "groupBoxOutput_PKV";
            this.groupBoxOutput_PKV.Size = new System.Drawing.Size(383, 265);
            this.groupBoxOutput_PKV.TabIndex = 5;
            this.groupBoxOutput_PKV.TabStop = false;
            this.groupBoxOutput_PKV.Text = "Вывод : ";
            // 
            // textBoxInput_PKV
            // 
            this.textBoxInput_PKV.Location = new System.Drawing.Point(7, 40);
            this.textBoxInput_PKV.Multiline = true;
            this.textBoxInput_PKV.Name = "textBoxInput_PKV";
            this.textBoxInput_PKV.ReadOnly = true;
            this.textBoxInput_PKV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_PKV.Size = new System.Drawing.Size(374, 219);
            this.textBoxInput_PKV.TabIndex = 0;
            // 
            // textBoxOutput_PKV
            // 
            this.textBoxOutput_PKV.Location = new System.Drawing.Point(7, 19);
            this.textBoxOutput_PKV.Multiline = true;
            this.textBoxOutput_PKV.Name = "textBoxOutput_PKV";
            this.textBoxOutput_PKV.ReadOnly = true;
            this.textBoxOutput_PKV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_PKV.Size = new System.Drawing.Size(370, 240);
            this.textBoxOutput_PKV.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutput_PKV);
            this.Controls.Add(this.groupBoxInput_PKV);
            this.Controls.Add(this.groupBoxTask_PKV);
            this.Controls.Add(this.buttonHelp_PKV);
            this.Controls.Add(this.buttonDone_PKV);
            this.Controls.Add(this.buttonOpenFile_PKV);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 24 | Паулик К.В.";
            this.groupBoxTask_PKV.ResumeLayout(false);
            this.groupBoxTask_PKV.PerformLayout();
            this.groupBoxInput_PKV.ResumeLayout(false);
            this.groupBoxInput_PKV.PerformLayout();
            this.groupBoxOutput_PKV.ResumeLayout(false);
            this.groupBoxOutput_PKV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_PKV;
        private System.Windows.Forms.Button buttonDone_PKV;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PKV;
        private System.Windows.Forms.Button buttonHelp_PKV;
        private System.Windows.Forms.GroupBox groupBoxTask_PKV;
        private System.Windows.Forms.TextBox textBoxTask_PKV;
        private System.Windows.Forms.GroupBox groupBoxInput_PKV;
        private System.Windows.Forms.TextBox textBoxInput_PKV;
        private System.Windows.Forms.GroupBox groupBoxOutput_PKV;
        private System.Windows.Forms.TextBox textBoxOutput_PKV;
    }
}

