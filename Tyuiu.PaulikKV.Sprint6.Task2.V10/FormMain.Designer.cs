
namespace Tyuiu.PaulikKV.Sprint6.Task2.V10
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
            this.groupBoxCondition_PKV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PKV = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PKV = new System.Windows.Forms.GroupBox();
            this.labelStart_PKV = new System.Windows.Forms.Label();
            this.labelStop_PKV = new System.Windows.Forms.Label();
            this.textBoxStartValue_PKV = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_PKV = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone_PKV = new System.Windows.Forms.Button();
            this.groupBoxOutput_PKV = new System.Windows.Forms.GroupBox();
            this.labelResult_PKV = new System.Windows.Forms.Label();
            this.chartFunction_PKV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_PKV = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition_PKV.SuspendLayout();
            this.groupBoxInput_PKV.SuspendLayout();
            this.groupBoxOutput_PKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PKV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PKV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PKV
            // 
            this.groupBoxCondition_PKV.Controls.Add(this.textBoxTask_PKV);
            this.groupBoxCondition_PKV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_PKV.Name = "groupBoxCondition_PKV";
            this.groupBoxCondition_PKV.Size = new System.Drawing.Size(569, 284);
            this.groupBoxCondition_PKV.TabIndex = 0;
            this.groupBoxCondition_PKV.TabStop = false;
            this.groupBoxCondition_PKV.Text = "Условие";
            // 
            // textBoxTask_PKV
            // 
            this.textBoxTask_PKV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PKV.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_PKV.Multiline = true;
            this.textBoxTask_PKV.Name = "textBoxTask_PKV";
            this.textBoxTask_PKV.ReadOnly = true;
            this.textBoxTask_PKV.Size = new System.Drawing.Size(518, 249);
            this.textBoxTask_PKV.TabIndex = 0;
            this.textBoxTask_PKV.Text = "Протабулировать функцию 2x-4+2x-1/sin(x)+1 на заданном диапазоне.\r\nРезультат выве" +
    "сти в DataGridView и построить график функции.\r\n";
            // 
            // groupBoxInput_PKV
            // 
            this.groupBoxInput_PKV.Controls.Add(this.textBoxStopValue_PKV);
            this.groupBoxInput_PKV.Controls.Add(this.textBoxStartValue_PKV);
            this.groupBoxInput_PKV.Controls.Add(this.labelStop_PKV);
            this.groupBoxInput_PKV.Controls.Add(this.labelStart_PKV);
            this.groupBoxInput_PKV.Location = new System.Drawing.Point(12, 319);
            this.groupBoxInput_PKV.Name = "groupBoxInput_PKV";
            this.groupBoxInput_PKV.Size = new System.Drawing.Size(275, 100);
            this.groupBoxInput_PKV.TabIndex = 1;
            this.groupBoxInput_PKV.TabStop = false;
            this.groupBoxInput_PKV.Text = "Ввод данных";
            // 
            // labelStart_PKV
            // 
            this.labelStart_PKV.AutoSize = true;
            this.labelStart_PKV.Location = new System.Drawing.Point(7, 20);
            this.labelStart_PKV.Name = "labelStart_PKV";
            this.labelStart_PKV.Size = new System.Drawing.Size(67, 13);
            this.labelStart_PKV.TabIndex = 0;
            this.labelStart_PKV.Text = "Старт шага:";
            // 
            // labelStop_PKV
            // 
            this.labelStop_PKV.AutoSize = true;
            this.labelStop_PKV.Location = new System.Drawing.Point(142, 20);
            this.labelStop_PKV.Name = "labelStop_PKV";
            this.labelStop_PKV.Size = new System.Drawing.Size(69, 13);
            this.labelStop_PKV.TabIndex = 1;
            this.labelStop_PKV.Text = "Конец шага:";
            // 
            // textBoxStartValue_PKV
            // 
            this.textBoxStartValue_PKV.Location = new System.Drawing.Point(10, 37);
            this.textBoxStartValue_PKV.Name = "textBoxStartValue_PKV";
            this.textBoxStartValue_PKV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartValue_PKV.TabIndex = 2;
            // 
            // textBoxStopValue_PKV
            // 
            this.textBoxStopValue_PKV.Location = new System.Drawing.Point(145, 37);
            this.textBoxStopValue_PKV.Name = "textBoxStopValue_PKV";
            this.textBoxStopValue_PKV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopValue_PKV.TabIndex = 3;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHelp.FlatAppearance.BorderSize = 2;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelp.Location = new System.Drawing.Point(312, 363);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(44, 42);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone_PKV
            // 
            this.buttonDone_PKV.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_PKV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDone_PKV.FlatAppearance.BorderSize = 2;
            this.buttonDone_PKV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_PKV.Location = new System.Drawing.Point(382, 363);
            this.buttonDone_PKV.Name = "buttonDone_PKV";
            this.buttonDone_PKV.Size = new System.Drawing.Size(139, 42);
            this.buttonDone_PKV.TabIndex = 3;
            this.buttonDone_PKV.Text = "Выполнить";
            this.buttonDone_PKV.UseVisualStyleBackColor = false;
            this.buttonDone_PKV.Click += new System.EventHandler(this.buttonDone_PKV_Click);
            this.buttonDone_PKV.MouseEnter += new System.EventHandler(this.buttonDone_PKV_MouseEnter);
            this.buttonDone_PKV.MouseLeave += new System.EventHandler(this.buttonDone_PKV_MouseLeave);
            // 
            // groupBoxOutput_PKV
            // 
            this.groupBoxOutput_PKV.Controls.Add(this.dataGridViewFunction_PKV);
            this.groupBoxOutput_PKV.Controls.Add(this.labelResult_PKV);
            this.groupBoxOutput_PKV.Location = new System.Drawing.Point(602, 22);
            this.groupBoxOutput_PKV.Name = "groupBoxOutput_PKV";
            this.groupBoxOutput_PKV.Size = new System.Drawing.Size(571, 383);
            this.groupBoxOutput_PKV.TabIndex = 4;
            this.groupBoxOutput_PKV.TabStop = false;
            this.groupBoxOutput_PKV.Text = "Вывод данных";
            this.groupBoxOutput_PKV.Enter += new System.EventHandler(this.groupBoxOutput_PKV_Enter);
            // 
            // labelResult_PKV
            // 
            this.labelResult_PKV.AutoSize = true;
            this.labelResult_PKV.Location = new System.Drawing.Point(7, 20);
            this.labelResult_PKV.Name = "labelResult_PKV";
            this.labelResult_PKV.Size = new System.Drawing.Size(62, 13);
            this.labelResult_PKV.TabIndex = 0;
            this.labelResult_PKV.Text = "Результат:";
            // 
            // chartFunction_PKV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_PKV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_PKV.Legends.Add(legend1);
            this.chartFunction_PKV.Location = new System.Drawing.Point(722, 32);
            this.chartFunction_PKV.Name = "chartFunction_PKV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_PKV.Series.Add(series1);
            this.chartFunction_PKV.Size = new System.Drawing.Size(443, 358);
            this.chartFunction_PKV.TabIndex = 2;
            this.chartFunction_PKV.Text = "chart1";
            // 
            // dataGridViewFunction_PKV
            // 
            this.dataGridViewFunction_PKV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_PKV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_PKV.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewFunction_PKV.Name = "dataGridViewFunction_PKV";
            this.dataGridViewFunction_PKV.RowHeadersVisible = false;
            this.dataGridViewFunction_PKV.Size = new System.Drawing.Size(108, 341);
            this.dataGridViewFunction_PKV.TabIndex = 5;
            this.dataGridViewFunction_PKV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFunction_PKV_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 423);
            this.Controls.Add(this.chartFunction_PKV);
            this.Controls.Add(this.groupBoxOutput_PKV);
            this.Controls.Add(this.buttonDone_PKV);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxInput_PKV);
            this.Controls.Add(this.groupBoxCondition_PKV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 10 | Паулик К.В.";
            this.groupBoxCondition_PKV.ResumeLayout(false);
            this.groupBoxCondition_PKV.PerformLayout();
            this.groupBoxInput_PKV.ResumeLayout(false);
            this.groupBoxInput_PKV.PerformLayout();
            this.groupBoxOutput_PKV.ResumeLayout(false);
            this.groupBoxOutput_PKV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PKV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_PKV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PKV;
        private System.Windows.Forms.TextBox textBoxTask_PKV;
        private System.Windows.Forms.GroupBox groupBoxInput_PKV;
        private System.Windows.Forms.TextBox textBoxStopValue_PKV;
        private System.Windows.Forms.TextBox textBoxStartValue_PKV;
        private System.Windows.Forms.Label labelStop_PKV;
        private System.Windows.Forms.Label labelStart_PKV;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone_PKV;
        private System.Windows.Forms.GroupBox groupBoxOutput_PKV;
        private System.Windows.Forms.Label labelResult_PKV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PKV;
        private System.Windows.Forms.DataGridView dataGridViewFunction_PKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

