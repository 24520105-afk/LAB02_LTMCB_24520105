namespace _24521840_NT106_Lab2
{
    partial class Lab2_Bai02
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.tb_char = new System.Windows.Forms.TextBox();
            this.Character = new System.Windows.Forms.Label();
            this.tb_word = new System.Windows.Forms.TextBox();
            this.Word = new System.Windows.Forms.Label();
            this.tb_line = new System.Windows.Forms.TextBox();
            this.Line = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.Label();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Bisque;
            this.btn_clear.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(31, 344);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(140, 71);
            this.btn_clear.TabIndex = 27;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tb_char
            // 
            this.tb_char.BackColor = System.Drawing.Color.White;
            this.tb_char.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_char.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_char.Location = new System.Drawing.Point(123, 284);
            this.tb_char.Margin = new System.Windows.Forms.Padding(2);
            this.tb_char.Name = "tb_char";
            this.tb_char.ReadOnly = true;
            this.tb_char.Size = new System.Drawing.Size(216, 26);
            this.tb_char.TabIndex = 26;
            // 
            // Character
            // 
            this.Character.AutoSize = true;
            this.Character.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Character.Location = new System.Drawing.Point(28, 284);
            this.Character.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(87, 18);
            this.Character.TabIndex = 25;
            this.Character.Text = "Char Count";
            // 
            // tb_word
            // 
            this.tb_word.BackColor = System.Drawing.Color.White;
            this.tb_word.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_word.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_word.Location = new System.Drawing.Point(123, 221);
            this.tb_word.Margin = new System.Windows.Forms.Padding(2);
            this.tb_word.Name = "tb_word";
            this.tb_word.ReadOnly = true;
            this.tb_word.Size = new System.Drawing.Size(216, 26);
            this.tb_word.TabIndex = 24;
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.Location = new System.Drawing.Point(28, 223);
            this.Word.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(91, 18);
            this.Word.TabIndex = 23;
            this.Word.Text = "Word Count";
            // 
            // tb_line
            // 
            this.tb_line.BackColor = System.Drawing.Color.White;
            this.tb_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_line.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_line.Location = new System.Drawing.Point(123, 158);
            this.tb_line.Margin = new System.Windows.Forms.Padding(2);
            this.tb_line.Name = "tb_line";
            this.tb_line.ReadOnly = true;
            this.tb_line.Size = new System.Drawing.Size(216, 26);
            this.tb_line.TabIndex = 22;
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line.Location = new System.Drawing.Point(28, 160);
            this.Line.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(83, 18);
            this.Line.TabIndex = 21;
            this.Line.Text = "Line Count";
            // 
            // tb_url
            // 
            this.tb_url.BackColor = System.Drawing.Color.White;
            this.tb_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_url.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_url.Location = new System.Drawing.Point(123, 96);
            this.tb_url.Margin = new System.Windows.Forms.Padding(2);
            this.tb_url.Name = "tb_url";
            this.tb_url.ReadOnly = true;
            this.tb_url.Size = new System.Drawing.Size(216, 26);
            this.tb_url.TabIndex = 20;
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(28, 98);
            this.URL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(39, 18);
            this.URL.TabIndex = 19;
            this.URL.Text = "URL";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.White;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(123, 36);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(216, 26);
            this.tb_name.TabIndex = 18;
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(28, 38);
            this.FileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(50, 18);
            this.FileName.TabIndex = 17;
            this.FileName.Text = "Name";
            // 
            // btn_openFile
            // 
            this.btn_openFile.BackColor = System.Drawing.Color.Chocolate;
            this.btn_openFile.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFile.Location = new System.Drawing.Point(199, 344);
            this.btn_openFile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(140, 71);
            this.btn_openFile.TabIndex = 16;
            this.btn_openFile.Text = "Open File";
            this.btn_openFile.UseVisualStyleBackColor = false;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // rtb_output
            // 
            this.rtb_output.BackColor = System.Drawing.Color.White;
            this.rtb_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_output.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_output.Location = new System.Drawing.Point(372, 36);
            this.rtb_output.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.ReadOnly = true;
            this.rtb_output.Size = new System.Drawing.Size(401, 379);
            this.rtb_output.TabIndex = 15;
            this.rtb_output.Text = "";
            // 
            // Lab2_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_char);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.tb_word);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.tb_line);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.rtb_output);
            this.Name = "Lab2_Bai02";
            this.Text = "Lab2_Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox tb_char;
        private System.Windows.Forms.Label Character;
        private System.Windows.Forms.TextBox tb_word;
        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.TextBox tb_line;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.RichTextBox rtb_output;
    }
}