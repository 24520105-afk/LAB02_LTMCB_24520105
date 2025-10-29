namespace _24521840_NT106_Lab2
{
    partial class Lab2_Bai07
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
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tw_direc = new System.Windows.Forms.TreeView();
            this.ptb_view = new System.Windows.Forms.PictureBox();
            this.rtb_content = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_view)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tw_direc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ptb_view);
            this.splitContainer1.Panel2.Controls.Add(this.rtb_content);
            this.splitContainer1.Size = new System.Drawing.Size(675, 488);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // tw_direc
            // 
            this.tw_direc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tw_direc.Location = new System.Drawing.Point(0, 0);
            this.tw_direc.Margin = new System.Windows.Forms.Padding(2);
            this.tw_direc.Name = "tw_direc";
            this.tw_direc.Size = new System.Drawing.Size(225, 488);
            this.tw_direc.TabIndex = 0;
            this.tw_direc.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tw_direc_BeforeExpand);
            this.tw_direc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tw_direc_AfterSelect);
            // 
            // ptb_view
            // 
            this.ptb_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_view.Location = new System.Drawing.Point(0, 0);
            this.ptb_view.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_view.Name = "ptb_view";
            this.ptb_view.Size = new System.Drawing.Size(447, 488);
            this.ptb_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_view.TabIndex = 0;
            this.ptb_view.TabStop = false;
            this.ptb_view.Visible = false;
            // 
            // rtb_content
            // 
            this.rtb_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_content.Location = new System.Drawing.Point(0, 0);
            this.rtb_content.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_content.Name = "rtb_content";
            this.rtb_content.ReadOnly = true;
            this.rtb_content.Size = new System.Drawing.Size(447, 488);
            this.rtb_content.TabIndex = 1;
            this.rtb_content.Text = "";
            this.rtb_content.Visible = false;
            // 
            // Lab2_Bai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 488);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lab2_Bai07";
            this.Text = "Lab2_Bai07";
            this.Load += new System.EventHandler(this.Lab2_Bai07_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tw_direc;
        private System.Windows.Forms.PictureBox ptb_view;
        private System.Windows.Forms.RichTextBox rtb_content;
    }
}