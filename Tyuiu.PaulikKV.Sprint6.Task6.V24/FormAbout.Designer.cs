﻿
namespace Tyuiu.PaulikKV.Sprint6.Task6.V24
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBoxInfo_PKV = new System.Windows.Forms.TextBox();
            this.buttonClose_PKV = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_PKV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PKV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInfo_PKV
            // 
            this.textBoxInfo_PKV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_PKV.Location = new System.Drawing.Point(178, 13);
            this.textBoxInfo_PKV.Multiline = true;
            this.textBoxInfo_PKV.Name = "textBoxInfo_PKV";
            this.textBoxInfo_PKV.ReadOnly = true;
            this.textBoxInfo_PKV.Size = new System.Drawing.Size(282, 137);
            this.textBoxInfo_PKV.TabIndex = 0;
            this.textBoxInfo_PKV.Text = resources.GetString("textBoxInfo_PKV.Text");
            // 
            // buttonClose_PKV
            // 
            this.buttonClose_PKV.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonClose_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose_PKV.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonClose_PKV.FlatAppearance.BorderSize = 2;
            this.buttonClose_PKV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonClose_PKV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose_PKV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClose_PKV.Location = new System.Drawing.Point(385, 165);
            this.buttonClose_PKV.Name = "buttonClose_PKV";
            this.buttonClose_PKV.Size = new System.Drawing.Size(75, 23);
            this.buttonClose_PKV.TabIndex = 1;
            this.buttonClose_PKV.Text = "Ok";
            this.buttonClose_PKV.UseVisualStyleBackColor = false;
            this.buttonClose_PKV.Click += new System.EventHandler(this.buttonClose_PKV_Click);
            // 
            // pictureBoxAvatar_PKV
            // 
            this.pictureBoxAvatar_PKV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_PKV.Image")));
            this.pictureBoxAvatar_PKV.Location = new System.Drawing.Point(6, 13);
            this.pictureBoxAvatar_PKV.Name = "pictureBoxAvatar_PKV";
            this.pictureBoxAvatar_PKV.Size = new System.Drawing.Size(166, 176);
            this.pictureBoxAvatar_PKV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_PKV.TabIndex = 2;
            this.pictureBoxAvatar_PKV.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 200);
            this.Controls.Add(this.pictureBoxAvatar_PKV);
            this.Controls.Add(this.buttonClose_PKV);
            this.Controls.Add(this.textBoxInfo_PKV);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PKV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo_PKV;
        private System.Windows.Forms.Button buttonClose_PKV;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_PKV;
    }
}