
namespace Tyuiu.PaulikKV.Sprint6.Task5.V6
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
            this.groupBoxOutput_PKV = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonDone_PKV = new System.Windows.Forms.Button();
            this.buttonOpen_PKV = new System.Windows.Forms.Button();
            this.buttonHelp_PKV = new System.Windows.Forms.Button();
            this.dataGridViewOutput_PKV = new System.Windows.Forms.DataGridView();
            this.chartFunction_PKV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition_PKV.SuspendLayout();
            this.groupBoxOutput_PKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_PKV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PKV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PKV
            // 
            this.groupBoxCondition_PKV.Controls.Add(this.textBox1);
            this.groupBoxCondition_PKV.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_PKV.Name = "groupBoxCondition_PKV";
            this.groupBoxCondition_PKV.Size = new System.Drawing.Size(507, 100);
            this.groupBoxCondition_PKV.TabIndex = 0;
            this.groupBoxCondition_PKV.TabStop = false;
            this.groupBoxCondition_PKV.Text = "Условие";
            // 
            // groupBoxOutput_PKV
            // 
            this.groupBoxOutput_PKV.Controls.Add(this.dataGridViewOutput_PKV);
            this.groupBoxOutput_PKV.Location = new System.Drawing.Point(13, 119);
            this.groupBoxOutput_PKV.Name = "groupBoxOutput_PKV";
            this.groupBoxOutput_PKV.Size = new System.Drawing.Size(200, 319);
            this.groupBoxOutput_PKV.TabIndex = 1;
            this.groupBoxOutput_PKV.TabStop = false;
            this.groupBoxOutput_PKV.Text = "Вывод данных";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(494, 74);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V6.txt. Вывести в dataGridView все числа," +
    " кратные 3.\r\n\r\nПостроить диаграмму по этим значениям.";
            // 
            // buttonDone_PKV
            // 
            this.buttonDone_PKV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_PKV.Location = new System.Drawing.Point(526, 33);
            this.buttonDone_PKV.Name = "buttonDone_PKV";
            this.buttonDone_PKV.Size = new System.Drawing.Size(108, 52);
            this.buttonDone_PKV.TabIndex = 2;
            this.buttonDone_PKV.Text = "Выполнить";
            this.buttonDone_PKV.UseVisualStyleBackColor = false;
            this.buttonDone_PKV.Click += new System.EventHandler(this.buttonDone_PKV_Click);
            // 
            // buttonOpen_PKV
            // 
            this.buttonOpen_PKV.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpen_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_PKV.Location = new System.Drawing.Point(640, 33);
            this.buttonOpen_PKV.Name = "buttonOpen_PKV";
            this.buttonOpen_PKV.Size = new System.Drawing.Size(106, 52);
            this.buttonOpen_PKV.TabIndex = 3;
            this.buttonOpen_PKV.Text = "Открыть файл";
            this.buttonOpen_PKV.UseVisualStyleBackColor = false;
            this.buttonOpen_PKV.Click += new System.EventHandler(this.buttonOpen_PKV_Click);
            // 
            // buttonHelp_PKV
            // 
            this.buttonHelp_PKV.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonHelp_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_PKV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PKV.Location = new System.Drawing.Point(752, 44);
            this.buttonHelp_PKV.Name = "buttonHelp_PKV";
            this.buttonHelp_PKV.Size = new System.Drawing.Size(32, 31);
            this.buttonHelp_PKV.TabIndex = 4;
            this.buttonHelp_PKV.Text = "?";
            this.buttonHelp_PKV.UseVisualStyleBackColor = false;
            this.buttonHelp_PKV.Click += new System.EventHandler(this.buttonHelp_PKV_Click);
            // 
            // dataGridViewOutput_PKV
            // 
            this.dataGridViewOutput_PKV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_PKV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewOutput_PKV.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewOutput_PKV.Name = "dataGridViewOutput_PKV";
            this.dataGridViewOutput_PKV.ReadOnly = true;
            this.dataGridViewOutput_PKV.RowHeadersVisible = false;
            this.dataGridViewOutput_PKV.Size = new System.Drawing.Size(187, 293);
            this.dataGridViewOutput_PKV.TabIndex = 0;
            this.dataGridViewOutput_PKV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOutput_PKV_CellContentClick);
            // 
            // chartFunction_PKV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_PKV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_PKV.Legends.Add(legend1);
            this.chartFunction_PKV.Location = new System.Drawing.Point(243, 120);
            this.chartFunction_PKV.Name = "chartFunction_PKV";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Green;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_PKV.Series.Add(series1);
            this.chartFunction_PKV.Size = new System.Drawing.Size(709, 301);
            this.chartFunction_PKV.TabIndex = 5;
            this.chartFunction_PKV.Text = "chart1";
            // 
            // X
            // 
            this.X.HeaderText = "";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 30;
            // 
            // Y
            // 
            this.Y.HeaderText = "";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.chartFunction_PKV);
            this.Controls.Add(this.buttonHelp_PKV);
            this.Controls.Add(this.buttonOpen_PKV);
            this.Controls.Add(this.buttonDone_PKV);
            this.Controls.Add(this.groupBoxOutput_PKV);
            this.Controls.Add(this.groupBoxCondition_PKV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Такс 5 | Вариант 6 | Паулик К.В.";
            this.groupBoxCondition_PKV.ResumeLayout(false);
            this.groupBoxCondition_PKV.PerformLayout();
            this.groupBoxOutput_PKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_PKV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PKV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PKV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxOutput_PKV;
        private System.Windows.Forms.DataGridView dataGridViewOutput_PKV;
        private System.Windows.Forms.Button buttonDone_PKV;
        private System.Windows.Forms.Button buttonOpen_PKV;
        private System.Windows.Forms.Button buttonHelp_PKV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

