
namespace Tyuiu.PaulikKV.Sprint6.Task4.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonDone_PKV = new System.Windows.Forms.Button();
            this.buttonSave_PKV = new System.Windows.Forms.Button();
            this.buttonHelp_PKV = new System.Windows.Forms.Button();
            this.groupBoxCondition_PKV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PKV = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PKV = new System.Windows.Forms.GroupBox();
            this.textBoxStopValue_PKV = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_PKV = new System.Windows.Forms.TextBox();
            this.labelStop_PKV = new System.Windows.Forms.Label();
            this.labelStart_PKV = new System.Windows.Forms.Label();
            this.groupBoxOutput_PKV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_PKV = new System.Windows.Forms.TextBox();
            this.chartFunction_PKV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition_PKV.SuspendLayout();
            this.groupBoxInput_PKV.SuspendLayout();
            this.groupBoxOutput_PKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PKV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_PKV
            // 
            this.buttonDone_PKV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_PKV.Location = new System.Drawing.Point(661, 13);
            this.buttonDone_PKV.Name = "buttonDone_PKV";
            this.buttonDone_PKV.Size = new System.Drawing.Size(122, 41);
            this.buttonDone_PKV.TabIndex = 0;
            this.buttonDone_PKV.Text = "Выполнить";
            this.buttonDone_PKV.UseVisualStyleBackColor = false;
            this.buttonDone_PKV.Click += new System.EventHandler(this.buttonDone_PKV_Click);
            // 
            // buttonSave_PKV
            // 
            this.buttonSave_PKV.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_PKV.Location = new System.Drawing.Point(790, 13);
            this.buttonSave_PKV.Name = "buttonSave_PKV";
            this.buttonSave_PKV.Size = new System.Drawing.Size(121, 41);
            this.buttonSave_PKV.TabIndex = 1;
            this.buttonSave_PKV.Text = "Сохранить";
            this.buttonSave_PKV.UseVisualStyleBackColor = false;
            this.buttonSave_PKV.Click += new System.EventHandler(this.buttonSave_PKV_Click);
            // 
            // buttonHelp_PKV
            // 
            this.buttonHelp_PKV.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonHelp_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_PKV.Location = new System.Drawing.Point(920, 13);
            this.buttonHelp_PKV.Name = "buttonHelp_PKV";
            this.buttonHelp_PKV.Size = new System.Drawing.Size(47, 41);
            this.buttonHelp_PKV.TabIndex = 2;
            this.buttonHelp_PKV.Text = "?";
            this.buttonHelp_PKV.UseVisualStyleBackColor = false;
            this.buttonHelp_PKV.Click += new System.EventHandler(this.buttonHelp_PKV_Click);
            // 
            // groupBoxCondition_PKV
            // 
            this.groupBoxCondition_PKV.Controls.Add(this.textBoxTask_PKV);
            this.groupBoxCondition_PKV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_PKV.Name = "groupBoxCondition_PKV";
            this.groupBoxCondition_PKV.Size = new System.Drawing.Size(360, 90);
            this.groupBoxCondition_PKV.TabIndex = 3;
            this.groupBoxCondition_PKV.TabStop = false;
            this.groupBoxCondition_PKV.Text = "Условие";
            // 
            // textBoxTask_PKV
            // 
            this.textBoxTask_PKV.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_PKV.Multiline = true;
            this.textBoxTask_PKV.Name = "textBoxTask_PKV";
            this.textBoxTask_PKV.ReadOnly = true;
            this.textBoxTask_PKV.Size = new System.Drawing.Size(347, 61);
            this.textBoxTask_PKV.TabIndex = 0;
            this.textBoxTask_PKV.Text = "Произвести табулирование f(x) на заданном диапазоне  [-5; 5]\r\nс шагом 1.Результат" +
    " вывести в textBox, построить график функции и сохранить в файл OutPutFileTask4V" +
    "22.txt по нажатию кнопки.\r\n";
            this.textBoxTask_PKV.TextChanged += new System.EventHandler(this.textBoxTask_PKV_TextChanged);
            // 
            // groupBoxInput_PKV
            // 
            this.groupBoxInput_PKV.Controls.Add(this.textBoxStopValue_PKV);
            this.groupBoxInput_PKV.Controls.Add(this.textBoxStartValue_PKV);
            this.groupBoxInput_PKV.Controls.Add(this.labelStop_PKV);
            this.groupBoxInput_PKV.Controls.Add(this.labelStart_PKV);
            this.groupBoxInput_PKV.Location = new System.Drawing.Point(379, 13);
            this.groupBoxInput_PKV.Name = "groupBoxInput_PKV";
            this.groupBoxInput_PKV.Size = new System.Drawing.Size(263, 89);
            this.groupBoxInput_PKV.TabIndex = 4;
            this.groupBoxInput_PKV.TabStop = false;
            this.groupBoxInput_PKV.Text = "Ввод данных";
            // 
            // textBoxStopValue_PKV
            // 
            this.textBoxStopValue_PKV.Location = new System.Drawing.Point(141, 36);
            this.textBoxStopValue_PKV.Name = "textBoxStopValue_PKV";
            this.textBoxStopValue_PKV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopValue_PKV.TabIndex = 3;
            // 
            // textBoxStartValue_PKV
            // 
            this.textBoxStartValue_PKV.Location = new System.Drawing.Point(6, 36);
            this.textBoxStartValue_PKV.Name = "textBoxStartValue_PKV";
            this.textBoxStartValue_PKV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartValue_PKV.TabIndex = 2;
            // 
            // labelStop_PKV
            // 
            this.labelStop_PKV.AutoSize = true;
            this.labelStop_PKV.Location = new System.Drawing.Point(138, 19);
            this.labelStop_PKV.Name = "labelStop_PKV";
            this.labelStop_PKV.Size = new System.Drawing.Size(66, 13);
            this.labelStop_PKV.TabIndex = 1;
            this.labelStop_PKV.Text = "Конец шага";
            // 
            // labelStart_PKV
            // 
            this.labelStart_PKV.AutoSize = true;
            this.labelStart_PKV.Location = new System.Drawing.Point(7, 19);
            this.labelStart_PKV.Name = "labelStart_PKV";
            this.labelStart_PKV.Size = new System.Drawing.Size(64, 13);
            this.labelStart_PKV.TabIndex = 0;
            this.labelStart_PKV.Text = "Старт шага";
            // 
            // groupBoxOutput_PKV
            // 
            this.groupBoxOutput_PKV.Controls.Add(this.textBoxResult_PKV);
            this.groupBoxOutput_PKV.Location = new System.Drawing.Point(19, 109);
            this.groupBoxOutput_PKV.Name = "groupBoxOutput_PKV";
            this.groupBoxOutput_PKV.Size = new System.Drawing.Size(248, 380);
            this.groupBoxOutput_PKV.TabIndex = 5;
            this.groupBoxOutput_PKV.TabStop = false;
            this.groupBoxOutput_PKV.Text = "Вывод";
            // 
            // textBoxResult_PKV
            // 
            this.textBoxResult_PKV.Location = new System.Drawing.Point(7, 20);
            this.textBoxResult_PKV.Multiline = true;
            this.textBoxResult_PKV.Name = "textBoxResult_PKV";
            this.textBoxResult_PKV.ReadOnly = true;
            this.textBoxResult_PKV.Size = new System.Drawing.Size(235, 354);
            this.textBoxResult_PKV.TabIndex = 0;
            // 
            // chartFunction_PKV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_PKV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_PKV.Legends.Add(legend1);
            this.chartFunction_PKV.Location = new System.Drawing.Point(267, 103);
            this.chartFunction_PKV.Name = "chartFunction_PKV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_PKV.Series.Add(series1);
            this.chartFunction_PKV.Size = new System.Drawing.Size(802, 380);
            this.chartFunction_PKV.TabIndex = 6;
            this.chartFunction_PKV.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.Blue;
            title1.Name = "Title1";
            title1.Text = "График функции f(x)";
            this.chartFunction_PKV.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 501);
            this.Controls.Add(this.chartFunction_PKV);
            this.Controls.Add(this.groupBoxOutput_PKV);
            this.Controls.Add(this.groupBoxInput_PKV);
            this.Controls.Add(this.groupBoxCondition_PKV);
            this.Controls.Add(this.buttonHelp_PKV);
            this.Controls.Add(this.buttonSave_PKV);
            this.Controls.Add(this.buttonDone_PKV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Такс 4 | Вариант 22 | Паулик К.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_PKV.ResumeLayout(false);
            this.groupBoxCondition_PKV.PerformLayout();
            this.groupBoxInput_PKV.ResumeLayout(false);
            this.groupBoxInput_PKV.PerformLayout();
            this.groupBoxOutput_PKV.ResumeLayout(false);
            this.groupBoxOutput_PKV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PKV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_PKV;
        private System.Windows.Forms.Button buttonSave_PKV;
        private System.Windows.Forms.Button buttonHelp_PKV;
        private System.Windows.Forms.GroupBox groupBoxCondition_PKV;
        private System.Windows.Forms.TextBox textBoxTask_PKV;
        private System.Windows.Forms.GroupBox groupBoxInput_PKV;
        private System.Windows.Forms.Label labelStop_PKV;
        private System.Windows.Forms.Label labelStart_PKV;
        private System.Windows.Forms.TextBox textBoxStopValue_PKV;
        private System.Windows.Forms.TextBox textBoxStartValue_PKV;
        private System.Windows.Forms.GroupBox groupBoxOutput_PKV;
        private System.Windows.Forms.TextBox textBoxResult_PKV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PKV;
    }
}

