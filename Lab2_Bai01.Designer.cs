namespace _24521840_NT106_Lab2
{
    partial class Lab2_Bai01
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
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.Location = new System.Drawing.Point(87, 75);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(145, 56);
            this.btn_read.TabIndex = 0;
            this.btn_read.Text = "Đọc File";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_write
            // 
            this.btn_write.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_write.Location = new System.Drawing.Point(87, 191);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(145, 56);
            this.btn_write.TabIndex = 1;
            this.btn_write.Text = "Ghi File";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // rtb_output
            // 
            this.rtb_output.Location = new System.Drawing.Point(311, 75);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(364, 172);
            this.rtb_output.TabIndex = 2;
            this.rtb_output.Text = "";
            // 
            // Lab2_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.btn_read);
            this.Name = "Lab2_Bai01";
            this.Text = "Lab2_Bai01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.RichTextBox rtb_output;
    }
}