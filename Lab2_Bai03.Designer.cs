namespace _24521840_NT106_Lab2
{
    partial class Lab2_Bai03
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
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.Wheat;
            this.btn_calculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.Location = new System.Drawing.Point(39, 189);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(115, 73);
            this.btn_calculate.TabIndex = 9;
            this.btn_calculate.Text = "Tính toán";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_read.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.Location = new System.Drawing.Point(39, 86);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(115, 73);
            this.btn_read.TabIndex = 8;
            this.btn_read.Text = "Đọc File";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // rtb_output
            // 
            this.rtb_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_output.Location = new System.Drawing.Point(368, 44);
            this.rtb_output.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(401, 254);
            this.rtb_output.TabIndex = 7;
            this.rtb_output.Text = "";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Orchid;
            this.btn_close.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(210, 189);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(115, 73);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_clear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(210, 86);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(115, 73);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Xóa";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Lab2_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.rtb_output);
            this.Name = "Lab2_Bai03";
            this.Text = "Lab2_Bai03";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_clear;
    }
}