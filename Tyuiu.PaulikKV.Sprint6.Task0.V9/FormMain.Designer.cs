
namespace Tyuiu.PaulikKV.Sprint6.Task0.V9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_PKV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PKV = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_PKV = new System.Windows.Forms.PictureBox();
            this.groupBoxCondition2_PKV = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_PKV = new System.Windows.Forms.TextBox();
            this.labelVarC_PKV = new System.Windows.Forms.Label();
            this.groupBoxCondition3_PKV = new System.Windows.Forms.GroupBox();
            this.labelVarB_PKV = new System.Windows.Forms.Label();
            this.textBoxResult_PKV = new System.Windows.Forms.TextBox();
            this.buttonDone_PKV = new System.Windows.Forms.Button();
            this.buttonHelp_PKV = new System.Windows.Forms.Button();
            this.groupBoxCondition_PKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PKV)).BeginInit();
            this.groupBoxCondition2_PKV.SuspendLayout();
            this.groupBoxCondition3_PKV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_PKV
            // 
            this.groupBoxCondition_PKV.Controls.Add(this.textBoxTask_PKV);
            this.groupBoxCondition_PKV.Controls.Add(this.pictureBoxFormula_PKV);
            this.groupBoxCondition_PKV.Location = new System.Drawing.Point(12, 24);
            this.groupBoxCondition_PKV.Name = "groupBoxCondition_PKV";
            this.groupBoxCondition_PKV.Size = new System.Drawing.Size(641, 183);
            this.groupBoxCondition_PKV.TabIndex = 0;
            this.groupBoxCondition_PKV.TabStop = false;
            this.groupBoxCondition_PKV.Text = "Условие";
            this.groupBoxCondition_PKV.Enter += new System.EventHandler(this.groupBoxCondition_PKV_Enter);
            // 
            // textBoxTask_PKV
            // 
            this.textBoxTask_PKV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PKV.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_PKV.Multiline = true;
            this.textBoxTask_PKV.Name = "textBoxTask_PKV";
            this.textBoxTask_PKV.ReadOnly = true;
            this.textBoxTask_PKV.Size = new System.Drawing.Size(495, 158);
            this.textBoxTask_PKV.TabIndex = 6;
            this.textBoxTask_PKV.Text = "Вычислить выражение по формуле\r\n";
            // 
            // pictureBoxFormula_PKV
            // 
            this.pictureBoxFormula_PKV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_PKV.Image")));
            this.pictureBoxFormula_PKV.Location = new System.Drawing.Point(507, 29);
            this.pictureBoxFormula_PKV.Name = "pictureBoxFormula_PKV";
            this.pictureBoxFormula_PKV.Size = new System.Drawing.Size(99, 57);
            this.pictureBoxFormula_PKV.TabIndex = 5;
            this.pictureBoxFormula_PKV.TabStop = false;
            this.pictureBoxFormula_PKV.Click += new System.EventHandler(this.pictureBoxFormula_PKV_Click);
            // 
            // groupBoxCondition2_PKV
            // 
            this.groupBoxCondition2_PKV.Controls.Add(this.textBoxVarX_PKV);
            this.groupBoxCondition2_PKV.Controls.Add(this.labelVarC_PKV);
            this.groupBoxCondition2_PKV.Location = new System.Drawing.Point(12, 213);
            this.groupBoxCondition2_PKV.Name = "groupBoxCondition2_PKV";
            this.groupBoxCondition2_PKV.Size = new System.Drawing.Size(407, 120);
            this.groupBoxCondition2_PKV.TabIndex = 1;
            this.groupBoxCondition2_PKV.TabStop = false;
            this.groupBoxCondition2_PKV.Text = "Ввод данных";
            this.groupBoxCondition2_PKV.Enter += new System.EventHandler(this.groupBoxCondition2_PKV_Enter);
            // 
            // textBoxVarX_PKV
            // 
            this.textBoxVarX_PKV.Location = new System.Drawing.Point(10, 52);
            this.textBoxVarX_PKV.Name = "textBoxVarX_PKV";
            this.textBoxVarX_PKV.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_PKV.TabIndex = 1;
            this.textBoxVarX_PKV.TextChanged += new System.EventHandler(this.textBoxVarX_PKV_TextChanged);
            this.textBoxVarX_PKV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_PKV_KeyPress);
            // 
            // labelVarC_PKV
            // 
            this.labelVarC_PKV.AutoSize = true;
            this.labelVarC_PKV.Location = new System.Drawing.Point(22, 36);
            this.labelVarC_PKV.Name = "labelVarC_PKV";
            this.labelVarC_PKV.Size = new System.Drawing.Size(84, 13);
            this.labelVarC_PKV.TabIndex = 0;
            this.labelVarC_PKV.Text = "Переменная X:";
            this.labelVarC_PKV.Click += new System.EventHandler(this.labelVarC_PKV_Click);
            // 
            // groupBoxCondition3_PKV
            // 
            this.groupBoxCondition3_PKV.Controls.Add(this.labelVarB_PKV);
            this.groupBoxCondition3_PKV.Controls.Add(this.textBoxResult_PKV);
            this.groupBoxCondition3_PKV.Location = new System.Drawing.Point(435, 213);
            this.groupBoxCondition3_PKV.Name = "groupBoxCondition3_PKV";
            this.groupBoxCondition3_PKV.Size = new System.Drawing.Size(218, 120);
            this.groupBoxCondition3_PKV.TabIndex = 2;
            this.groupBoxCondition3_PKV.TabStop = false;
            this.groupBoxCondition3_PKV.Text = "Вывод данных";
            this.groupBoxCondition3_PKV.Enter += new System.EventHandler(this.groupBoxCondition3_PKV_Enter);
            // 
            // labelVarB_PKV
            // 
            this.labelVarB_PKV.AutoSize = true;
            this.labelVarB_PKV.Location = new System.Drawing.Point(6, 36);
            this.labelVarB_PKV.Name = "labelVarB_PKV";
            this.labelVarB_PKV.Size = new System.Drawing.Size(62, 13);
            this.labelVarB_PKV.TabIndex = 1;
            this.labelVarB_PKV.Text = "Результат:";
            this.labelVarB_PKV.Click += new System.EventHandler(this.labelVarB_PKV_Click);
            // 
            // textBoxResult_PKV
            // 
            this.textBoxResult_PKV.Location = new System.Drawing.Point(6, 52);
            this.textBoxResult_PKV.Name = "textBoxResult_PKV";
            this.textBoxResult_PKV.ReadOnly = true;
            this.textBoxResult_PKV.Size = new System.Drawing.Size(147, 20);
            this.textBoxResult_PKV.TabIndex = 0;
            this.textBoxResult_PKV.TextChanged += new System.EventHandler(this.textBoxVarB_TextChanged);
            // 
            // buttonDone_PKV
            // 
            this.buttonDone_PKV.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonDone_PKV.FlatAppearance.BorderSize = 3;
            this.buttonDone_PKV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_PKV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDone_PKV.Location = new System.Drawing.Point(493, 352);
            this.buttonDone_PKV.Name = "buttonDone_PKV";
            this.buttonDone_PKV.Size = new System.Drawing.Size(160, 35);
            this.buttonDone_PKV.TabIndex = 3;
            this.buttonDone_PKV.Text = "Выполнить";
            this.buttonDone_PKV.UseVisualStyleBackColor = true;
            this.buttonDone_PKV.Click += new System.EventHandler(this.buttonDone_PKV_Click);
            // 
            // buttonHelp_PKV
            // 
            this.buttonHelp_PKV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonHelp_PKV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_PKV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonHelp_PKV.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonHelp_PKV.Location = new System.Drawing.Point(435, 352);
            this.buttonHelp_PKV.Name = "buttonHelp_PKV";
            this.buttonHelp_PKV.Size = new System.Drawing.Size(43, 35);
            this.buttonHelp_PKV.TabIndex = 4;
            this.buttonHelp_PKV.Text = "?";
            this.buttonHelp_PKV.UseVisualStyleBackColor = false;
            this.buttonHelp_PKV.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(662, 403);
            this.Controls.Add(this.buttonHelp_PKV);
            this.Controls.Add(this.buttonDone_PKV);
            this.Controls.Add(this.groupBoxCondition3_PKV);
            this.Controls.Add(this.groupBoxCondition2_PKV);
            this.Controls.Add(this.groupBoxCondition_PKV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт6 | Такс 0 | Вариант 9 | Паулик К.В.";
            this.groupBoxCondition_PKV.ResumeLayout(false);
            this.groupBoxCondition_PKV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PKV)).EndInit();
            this.groupBoxCondition2_PKV.ResumeLayout(false);
            this.groupBoxCondition2_PKV.PerformLayout();
            this.groupBoxCondition3_PKV.ResumeLayout(false);
            this.groupBoxCondition3_PKV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_PKV;
        private System.Windows.Forms.GroupBox groupBoxCondition2_PKV;
        private System.Windows.Forms.GroupBox groupBoxCondition3_PKV;
        private System.Windows.Forms.TextBox textBoxResult_PKV;
        private System.Windows.Forms.Label labelVarB_PKV;
        private System.Windows.Forms.TextBox textBoxVarX_PKV;
        private System.Windows.Forms.Label labelVarC_PKV;
        private System.Windows.Forms.Button buttonDone_PKV;
        private System.Windows.Forms.Button buttonHelp_PKV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_PKV;
        private System.Windows.Forms.TextBox textBoxTask_PKV;
    }
}

