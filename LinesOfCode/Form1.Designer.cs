namespace LinesOfCode
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLinesOfCode = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpLinesOfCode = new System.Windows.Forms.TabPage();
            this.tbpRename = new System.Windows.Forms.TabPage();
            this.txtRenameStartName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpLinesOfCode.SuspendLayout();
            this.tbpRename.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select a folder to calucate lines of code";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(580, 386);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnLinesOfCode
            // 
            this.btnLinesOfCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLinesOfCode.Location = new System.Drawing.Point(6, 316);
            this.btnLinesOfCode.Name = "btnLinesOfCode";
            this.btnLinesOfCode.Size = new System.Drawing.Size(117, 23);
            this.btnLinesOfCode.TabIndex = 2;
            this.btnLinesOfCode.Text = "Lines of code";
            this.btnLinesOfCode.UseVisualStyleBackColor = true;
            this.btnLinesOfCode.Click += new System.EventHandler(this.btnLinesOfCode_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(235, 38);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 3;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpLinesOfCode);
            this.tabControl1.Controls.Add(this.tbpRename);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 371);
            this.tabControl1.TabIndex = 4;
            // 
            // tbpLinesOfCode
            // 
            this.tbpLinesOfCode.Controls.Add(this.dataGridView1);
            this.tbpLinesOfCode.Controls.Add(this.label1);
            this.tbpLinesOfCode.Controls.Add(this.btnLinesOfCode);
            this.tbpLinesOfCode.Location = new System.Drawing.Point(4, 22);
            this.tbpLinesOfCode.Name = "tbpLinesOfCode";
            this.tbpLinesOfCode.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLinesOfCode.Size = new System.Drawing.Size(557, 345);
            this.tbpLinesOfCode.TabIndex = 0;
            this.tbpLinesOfCode.Text = "Lines of Code";
            this.tbpLinesOfCode.UseVisualStyleBackColor = true;
            // 
            // tbpRename
            // 
            this.tbpRename.Controls.Add(this.lblResult);
            this.tbpRename.Controls.Add(this.label2);
            this.tbpRename.Controls.Add(this.txtRenameStartName);
            this.tbpRename.Controls.Add(this.btnRename);
            this.tbpRename.Location = new System.Drawing.Point(4, 22);
            this.tbpRename.Name = "tbpRename";
            this.tbpRename.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRename.Size = new System.Drawing.Size(557, 345);
            this.tbpRename.TabIndex = 1;
            this.tbpRename.Text = "Rename files";
            this.tbpRename.UseVisualStyleBackColor = true;
            // 
            // txtRenameStartName
            // 
            this.txtRenameStartName.Location = new System.Drawing.Point(23, 38);
            this.txtRenameStartName.Name = "txtRenameStartName";
            this.txtRenameStartName.Size = new System.Drawing.Size(183, 20);
            this.txtRenameStartName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter starting name for the series";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(20, 101);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 386);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lines of Code Calculator";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpLinesOfCode.ResumeLayout(false);
            this.tbpLinesOfCode.PerformLayout();
            this.tbpRename.ResumeLayout(false);
            this.tbpRename.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLinesOfCode;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpLinesOfCode;
        private System.Windows.Forms.TabPage tbpRename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRenameStartName;
        private System.Windows.Forms.Label lblResult;
    }
}

