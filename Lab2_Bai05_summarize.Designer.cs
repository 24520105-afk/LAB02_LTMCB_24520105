using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using _24521840_NT106_Lab2;

namespace _24521840_NT106_Lab2
{
    partial class Lab2_Bai05_summarize
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

        private Dictionary<string, Lab2_Bai05_Movie> movies;
        private Button btn_read_data;
        private Button btn_write_data;
        private RichTextBox txt_summary;
        private ProgressBar progressBar;
        private Label lbl_progress;


        private void InitializeComponent()
        {
            this.btn_read_data = new System.Windows.Forms.Button();
            this.btn_write_data = new System.Windows.Forms.Button();
            this.txt_summary = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_read_data
            // 
            this.btn_read_data.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_read_data.Location = new System.Drawing.Point(50, 30);
            this.btn_read_data.Name = "btn_read_data";
            this.btn_read_data.Size = new System.Drawing.Size(200, 50);
            this.btn_read_data.TabIndex = 0;
            this.btn_read_data.Text = "Đọc dữ liệu";
            this.btn_read_data.UseVisualStyleBackColor = true;
            this.btn_read_data.Click += new System.EventHandler(this.btn_read_data_Click);
            // 
            // btn_write_data
            // 
            this.btn_write_data.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_write_data.Location = new System.Drawing.Point(550, 30);
            this.btn_write_data.Name = "btn_write_data";
            this.btn_write_data.Size = new System.Drawing.Size(200, 50);
            this.btn_write_data.TabIndex = 1;
            this.btn_write_data.Text = "Ghi dữ liệu";
            this.btn_write_data.UseVisualStyleBackColor = true;
            this.btn_write_data.Click += new System.EventHandler(this.btn_write_data_Click);
            // 
            // txt_summary
            // 
            this.txt_summary.Font = new System.Drawing.Font("Consolas", 10F);
            this.txt_summary.Location = new System.Drawing.Point(50, 100);
            this.txt_summary.Name = "txt_summary";
            this.txt_summary.ReadOnly = true;
            this.txt_summary.Size = new System.Drawing.Size(700, 400);
            this.txt_summary.TabIndex = 2;
            this.txt_summary.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(130, 518);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(620, 23);
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible = false;
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbl_progress.Location = new System.Drawing.Point(50, 520);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(66, 16);
            this.lbl_progress.TabIndex = 3;
            this.lbl_progress.Text = "Tiến trình:";
            this.lbl_progress.Visible = false;
            // 
            // Lab2_Bai05_summarize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.txt_summary);
            this.Controls.Add(this.btn_write_data);
            this.Controls.Add(this.btn_read_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Lab2_Bai05_summarize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2_Bai05_summarize - Thống kê doanh thu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}