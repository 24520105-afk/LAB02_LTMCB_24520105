namespace _24521840_NT106_Lab2
{
    partial class Lab2_Bai05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.clb_choose_seat = new System.Windows.Forms.CheckedListBox();
            this.tb_output = new System.Windows.Forms.RichTextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_summarize = new System.Windows.Forms.Button();
            this.cb_list_film = new System.Windows.Forms.ComboBox();
            this.cb_list_room = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn phòng chiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn ghế ngồi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thông tin vé";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(187, 43);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(194, 26);
            this.tb_name.TabIndex = 5;
            // 
            // clb_choose_seat
            // 
            this.clb_choose_seat.FormattingEnabled = true;
            this.clb_choose_seat.Location = new System.Drawing.Point(187, 142);
            this.clb_choose_seat.Name = "clb_choose_seat";
            this.clb_choose_seat.Size = new System.Drawing.Size(194, 94);
            this.clb_choose_seat.TabIndex = 8;
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(187, 243);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(194, 96);
            this.tb_output.TabIndex = 9;
            this.tb_output.Text = "";
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.Location = new System.Drawing.Point(448, 43);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(92, 51);
            this.btn_read.TabIndex = 10;
            this.btn_read.Text = "Đọc file dữ liệu phim";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(448, 107);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(92, 51);
            this.btn_confirm.TabIndex = 11;
            this.btn_confirm.Text = "Xác nhận đặt vé";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_summarize
            // 
            this.btn_summarize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_summarize.Location = new System.Drawing.Point(448, 174);
            this.btn_summarize.Name = "btn_summarize";
            this.btn_summarize.Size = new System.Drawing.Size(92, 51);
            this.btn_summarize.TabIndex = 12;
            this.btn_summarize.Text = "Tổng kết ";
            this.btn_summarize.UseVisualStyleBackColor = true;
            this.btn_summarize.Click += new System.EventHandler(this.btn_summarize_Click);
            // 
            // cb_list_film
            // 
            this.cb_list_film.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_list_film.FormattingEnabled = true;
            this.cb_list_film.Location = new System.Drawing.Point(187, 74);
            this.cb_list_film.Name = "cb_list_film";
            this.cb_list_film.Size = new System.Drawing.Size(194, 27);
            this.cb_list_film.TabIndex = 13;
            // 
            // cb_list_room
            // 
            this.cb_list_room.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_list_room.FormattingEnabled = true;
            this.cb_list_room.Location = new System.Drawing.Point(187, 107);
            this.cb_list_room.Name = "cb_list_room";
            this.cb_list_room.Size = new System.Drawing.Size(194, 27);
            this.cb_list_room.TabIndex = 14;
            // 
            // Lab2_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.cb_list_room);
            this.Controls.Add(this.cb_list_film);
            this.Controls.Add(this.btn_summarize);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.clb_choose_seat);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab2_Bai05";
            this.Text = "Lab2_Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.CheckedListBox clb_choose_seat;
        private System.Windows.Forms.RichTextBox tb_output;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_summarize;
        private System.Windows.Forms.ComboBox cb_list_film;
        private System.Windows.Forms.ComboBox cb_list_room;
    }
}