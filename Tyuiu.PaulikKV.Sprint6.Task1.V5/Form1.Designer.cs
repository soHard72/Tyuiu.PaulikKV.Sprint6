
namespace Tyuiu.PaulikKV.Sprint6.Task1.V5
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
            this.groupBoxCondition_PKV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PKV = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PKV = new System.Windows.Forms.GroupBox();
            this.labelStart_PKV = new System.Windows.Forms.Label();
            this.labelStop_PKV = new System.Windows.Forms.Label();
            this.textBoxStartValue_PKV = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_PKV = new System.Windows.Forms.TextBox();
            this.buttonHelp_PKV = new System.Windows.Forms.Button();
            this.buttonDone_PKV = new System.Windows.Forms.Button();
            this.groupBoxOutput_PKV = new System.Windows.Forms.GroupBox();
            this.labelResult_PKV = new System.Windows.Forms.Label();
            this.textBoxTable_PKV = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_PKV.SuspendLayout();
            this.groupBoxInput_PKV.SuspendLayout();
            this.groupBoxOutput_PKV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PKV
            // 
            this.groupBoxCondition_PKV.Controls.Add(this.textBoxTask_PKV);
            this.groupBoxCondition_PKV.Location = new System.Drawing.Point(12, 23);
            this.groupBoxCondition_PKV.Name = "groupBoxCondition_PKV";
            this.groupBoxCondition_PKV.Size = new System.Drawing.Size(483, 282);
            this.groupBoxCondition_PKV.TabIndex = 0;
            this.groupBoxCondition_PKV.TabStop = false;
            this.groupBoxCondition_PKV.Text = "Условие";
            // 
            // textBoxTask_PKV
            // 
            this.textBoxTask_PKV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PKV.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_PKV.Multiline = true;
            this.textBoxTask_PKV.Name = "textBoxTask_PKV";
            this.textBoxTask_PKV.ReadOnly = true;
            this.textBoxTask_PKV.Size = new System.Drawing.Size(457, 238);
            this.textBoxTask_PKV.TabIndex = 0;
            this.textBoxTask_PKV.Text = "Протабулировать функцию sin(x) + cos(2x)/2 - 1.5x на заданном диапазоне.\r\nРезульт" +
    "ат вывести в виде таблицы.\r\n\r\n";
            // 
            // groupBoxInput_PKV
            // 
            this.groupBoxInput_PKV.Controls.Add(this.textBoxStopValue_PKV);
            this.groupBoxInput_PKV.Controls.Add(this.textBoxStartValue_PKV);
            this.groupBoxInput_PKV.Controls.Add(this.labelStop_PKV);
            this.groupBoxInput_PKV.Controls.Add(this.labelStart_PKV);
            this.groupBoxInput_PKV.Location = new System.Drawing.Point(12, 322);
            this.groupBoxInput_PKV.Name = "groupBoxInput_PKV";
            this.groupBoxInput_PKV.Size = new System.Drawing.Size(247, 116);
            this.groupBoxInput_PKV.TabIndex = 1;
            this.groupBoxInput_PKV.TabStop = false;
            this.groupBoxInput_PKV.Text = "Ввод данных";
            // 
            // labelStart_PKV
            // 
            this.labelStart_PKV.AutoSize = true;
            this.labelStart_PKV.Location = new System.Drawing.Point(6, 30);
            this.labelStart_PKV.Name = "labelStart_PKV";
            this.labelStart_PKV.Size = new System.Drawing.Size(67, 13);
            this.labelStart_PKV.TabIndex = 0;
            this.labelStart_PKV.Text = "Старт шага:";
            this.labelStart_PKV.Click += new System.EventHandler(this.labelStart_PKV_Click);
            // 
            // labelStop_PKV
            // 
            this.labelStop_PKV.AutoSize = true;
            this.labelStop_PKV.Location = new System.Drawing.Point(129, 29);
            this.labelStop_PKV.Name = "labelStop_PKV";
            this.labelStop_PKV.Size = new System.Drawing.Size(69, 13);
            this.labelStop_PKV.TabIndex = 1;
            this.labelStop_PKV.Text = "Конец шага:";
            // 
            // textBoxStartValue_PKV
            // 
            this.textBoxStartValue_PKV.Location = new System.Drawing.Point(6, 46);
            this.textBoxStartValue_PKV.Name = "textBoxStartValue_PKV";
            this.textBoxStartValue_PKV.Size = new System.Drawing.Size(95, 20);
            this.textBoxStartValue_PKV.TabIndex = 2;
            // 
            // textBoxStopValue_PKV
            // 
            this.textBoxStopValue_PKV.Location = new System.Drawing.Point(132, 46);
            this.textBoxStopValue_PKV.Name = "textBoxStopValue_PKV";
            this.textBoxStopValue_PKV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopValue_PKV.TabIndex = 3;
            // 
            // buttonHelp_PKV
            // 
            this.buttonHelp_PKV.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_PKV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHelp_PKV.FlatAppearance.BorderSize = 2;
            this.buttonHelp_PKV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PKV.Location = new System.Drawing.Point(290, 359);
            this.buttonHelp_PKV.Name = "buttonHelp_PKV";
            this.buttonHelp_PKV.Size = new System.Drawing.Size(39, 37);
            this.buttonHelp_PKV.TabIndex = 4;
            this.buttonHelp_PKV.Text = "?";
            this.buttonHelp_PKV.UseVisualStyleBackColor = false;
            this.buttonHelp_PKV.Click += new System.EventHandler(this.buttonHelp_PKV_Click);
            // 
            // buttonDone_PKV
            // 
            this.buttonDone_PKV.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_PKV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_PKV.Location = new System.Drawing.Point(347, 359);
            this.buttonDone_PKV.Name = "buttonDone_PKV";
            this.buttonDone_PKV.Size = new System.Drawing.Size(128, 37);
            this.buttonDone_PKV.TabIndex = 5;
            this.buttonDone_PKV.Text = "Выполнить";
            this.buttonDone_PKV.UseVisualStyleBackColor = false;
            this.buttonDone_PKV.Click += new System.EventHandler(this.buttonDone_PKV_Click);
            // 
            // groupBoxOutput_PKV
            // 
            this.groupBoxOutput_PKV.Controls.Add(this.textBoxTable_PKV);
            this.groupBoxOutput_PKV.Controls.Add(this.labelResult_PKV);
            this.groupBoxOutput_PKV.Location = new System.Drawing.Point(510, 32);
            this.groupBoxOutput_PKV.Name = "groupBoxOutput_PKV";
            this.groupBoxOutput_PKV.Size = new System.Drawing.Size(200, 273);
            this.groupBoxOutput_PKV.TabIndex = 6;
            this.groupBoxOutput_PKV.TabStop = false;
            this.groupBoxOutput_PKV.Text = "Вывод данных";
            // 
            // labelResult_PKV
            // 
            this.labelResult_PKV.AutoSize = true;
            this.labelResult_PKV.Location = new System.Drawing.Point(6, 32);
            this.labelResult_PKV.Name = "labelResult_PKV";
            this.labelResult_PKV.Size = new System.Drawing.Size(62, 13);
            this.labelResult_PKV.TabIndex = 0;
            this.labelResult_PKV.Text = "Результат:";
            // 
            // textBoxTable_PKV
            // 
            this.textBoxTable_PKV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTable_PKV.Location = new System.Drawing.Point(47, 59);
            this.textBoxTable_PKV.Multiline = true;
            this.textBoxTable_PKV.Name = "textBoxTable_PKV";
            this.textBoxTable_PKV.ReadOnly = true;
            this.textBoxTable_PKV.Size = new System.Drawing.Size(100, 208);
            this.textBoxTable_PKV.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.groupBoxOutput_PKV);
            this.Controls.Add(this.buttonDone_PKV);
            this.Controls.Add(this.buttonHelp_PKV);
            this.Controls.Add(this.groupBoxInput_PKV);
            this.Controls.Add(this.groupBoxCondition_PKV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 5 | Паулик К.В.";
            this.groupBoxCondition_PKV.ResumeLayout(false);
            this.groupBoxCondition_PKV.PerformLayout();
            this.groupBoxInput_PKV.ResumeLayout(false);
            this.groupBoxInput_PKV.PerformLayout();
            this.groupBoxOutput_PKV.ResumeLayout(false);
            this.groupBoxOutput_PKV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PKV;
        private System.Windows.Forms.TextBox textBoxTask_PKV;
        private System.Windows.Forms.GroupBox groupBoxInput_PKV;
        private System.Windows.Forms.Label labelStart_PKV;
        private System.Windows.Forms.TextBox textBoxStopValue_PKV;
        private System.Windows.Forms.TextBox textBoxStartValue_PKV;
        private System.Windows.Forms.Label labelStop_PKV;
        private System.Windows.Forms.Button buttonHelp_PKV;
        private System.Windows.Forms.Button buttonDone_PKV;
        private System.Windows.Forms.GroupBox groupBoxOutput_PKV;
        private System.Windows.Forms.TextBox textBoxTable_PKV;
        private System.Windows.Forms.Label labelResult_PKV;
    }
}

