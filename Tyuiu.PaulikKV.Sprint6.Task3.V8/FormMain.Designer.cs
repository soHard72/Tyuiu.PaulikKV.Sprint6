
namespace Tyuiu.PaulikKV.Sprint6.Task3.V8
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
            this.dataGridViewResult_PKV = new System.Windows.Forms.DataGridView();
            this.groupBoxOutput_PKV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_PKV = new System.Windows.Forms.TextBox();
            this.labelResult_PKV = new System.Windows.Forms.Label();
            this.buttonHelp_PKV = new System.Windows.Forms.Button();
            this.buttonDone_PKV = new System.Windows.Forms.Button();
            this.groupBoxCondition_PKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PKV)).BeginInit();
            this.groupBoxOutput_PKV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PKV
            // 
            this.groupBoxCondition_PKV.Controls.Add(this.textBoxTask_PKV);
            this.groupBoxCondition_PKV.Controls.Add(this.dataGridViewResult_PKV);
            this.groupBoxCondition_PKV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_PKV.Name = "groupBoxCondition_PKV";
            this.groupBoxCondition_PKV.Size = new System.Drawing.Size(625, 265);
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
            this.textBoxTask_PKV.Size = new System.Drawing.Size(355, 239);
            this.textBoxTask_PKV.TabIndex = 0;
            this.textBoxTask_PKV.Text = "Дана матрица 5 на 5\r\n\r\n-10 10 -7 19 6\r\n15 -13 -19  9 1\r\n-20 -15 -6 8 -4\r\n10 18 -5" +
    " 9 -6\r\n16 -10 4 15 16\r\n\r\nЗаменить четные значения в четвертой строке на 0\r\n\r\n\r\n";
            // 
            // dataGridViewResult_PKV
            // 
            this.dataGridViewResult_PKV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PKV.Location = new System.Drawing.Point(368, 9);
            this.dataGridViewResult_PKV.Name = "dataGridViewResult_PKV";
            this.dataGridViewResult_PKV.Size = new System.Drawing.Size(240, 250);
            this.dataGridViewResult_PKV.TabIndex = 1;
            // 
            // groupBoxOutput_PKV
            // 
            this.groupBoxOutput_PKV.Controls.Add(this.labelResult_PKV);
            this.groupBoxOutput_PKV.Controls.Add(this.textBoxResult_PKV);
            this.groupBoxOutput_PKV.Location = new System.Drawing.Point(644, 21);
            this.groupBoxOutput_PKV.Name = "groupBoxOutput_PKV";
            this.groupBoxOutput_PKV.Size = new System.Drawing.Size(167, 100);
            this.groupBoxOutput_PKV.TabIndex = 2;
            this.groupBoxOutput_PKV.TabStop = false;
            this.groupBoxOutput_PKV.Text = "Вывод данных";
            // 
            // textBoxResult_PKV
            // 
            this.textBoxResult_PKV.Location = new System.Drawing.Point(6, 42);
            this.textBoxResult_PKV.Name = "textBoxResult_PKV";
            this.textBoxResult_PKV.ReadOnly = true;
            this.textBoxResult_PKV.Size = new System.Drawing.Size(155, 20);
            this.textBoxResult_PKV.TabIndex = 0;
            // 
            // labelResult_PKV
            // 
            this.labelResult_PKV.AutoSize = true;
            this.labelResult_PKV.Location = new System.Drawing.Point(6, 16);
            this.labelResult_PKV.Name = "labelResult_PKV";
            this.labelResult_PKV.Size = new System.Drawing.Size(62, 13);
            this.labelResult_PKV.TabIndex = 1;
            this.labelResult_PKV.Text = "Результат:";
            // 
            // buttonHelp_PKV
            // 
            this.buttonHelp_PKV.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_PKV.FlatAppearance.BorderSize = 2;
            this.buttonHelp_PKV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PKV.Location = new System.Drawing.Point(611, 306);
            this.buttonHelp_PKV.Name = "buttonHelp_PKV";
            this.buttonHelp_PKV.Size = new System.Drawing.Size(26, 27);
            this.buttonHelp_PKV.TabIndex = 3;
            this.buttonHelp_PKV.Text = "?";
            this.buttonHelp_PKV.UseVisualStyleBackColor = false;
            this.buttonHelp_PKV.Click += new System.EventHandler(this.buttonHelp_PKV_Click);
            // 
            // buttonDone_PKV
            // 
            this.buttonDone_PKV.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDone_PKV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_PKV.Location = new System.Drawing.Point(668, 306);
            this.buttonDone_PKV.Name = "buttonDone_PKV";
            this.buttonDone_PKV.Size = new System.Drawing.Size(137, 27);
            this.buttonDone_PKV.TabIndex = 4;
            this.buttonDone_PKV.Text = "Выполнить";
            this.buttonDone_PKV.UseCompatibleTextRendering = true;
            this.buttonDone_PKV.UseVisualStyleBackColor = false;
            this.buttonDone_PKV.Click += new System.EventHandler(this.buttonDone_PKV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 345);
            this.Controls.Add(this.buttonDone_PKV);
            this.Controls.Add(this.buttonHelp_PKV);
            this.Controls.Add(this.groupBoxOutput_PKV);
            this.Controls.Add(this.groupBoxCondition_PKV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 8 | Паулик К.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_PKV.ResumeLayout(false);
            this.groupBoxCondition_PKV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PKV)).EndInit();
            this.groupBoxOutput_PKV.ResumeLayout(false);
            this.groupBoxOutput_PKV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PKV;
        private System.Windows.Forms.TextBox textBoxTask_PKV;
        private System.Windows.Forms.DataGridView dataGridViewResult_PKV;
        private System.Windows.Forms.GroupBox groupBoxOutput_PKV;
        private System.Windows.Forms.Label labelResult_PKV;
        private System.Windows.Forms.TextBox textBoxResult_PKV;
        private System.Windows.Forms.Button buttonHelp_PKV;
        private System.Windows.Forms.Button buttonDone_PKV;
    }
}

