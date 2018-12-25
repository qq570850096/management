namespace management
{
    partial class FrmStuSearch
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
            this.Crouse = new System.Windows.Forms.DataGridView();
            this.C_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Crouse)).BeginInit();
            this.SuspendLayout();
            // 
            // Crouse
            // 
            this.Crouse.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Crouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Crouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_num,
            this.C_name,
            this.C_time,
            this.C_score,
            this.C_year,
            this.C_term});
            this.Crouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.Crouse.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Crouse.Location = new System.Drawing.Point(0, 0);
            this.Crouse.Name = "Crouse";
            this.Crouse.RowTemplate.Height = 23;
            this.Crouse.Size = new System.Drawing.Size(537, 311);
            this.Crouse.TabIndex = 0;
            // 
            // C_num
            // 
            this.C_num.DataPropertyName = "C_Num";
            this.C_num.HeaderText = "课号";
            this.C_num.Name = "C_num";
            this.C_num.ToolTipText = "课号";
            // 
            // C_name
            // 
            this.C_name.DataPropertyName = "C_Name";
            this.C_name.HeaderText = "课程名称";
            this.C_name.Name = "C_name";
            this.C_name.ToolTipText = "课程名称";
            // 
            // C_time
            // 
            this.C_time.DataPropertyName = "C_Time";
            this.C_time.HeaderText = "学时";
            this.C_time.Name = "C_time";
            this.C_time.ToolTipText = "学时";
            // 
            // C_score
            // 
            this.C_score.DataPropertyName = "C_Score";
            this.C_score.HeaderText = "学分";
            this.C_score.Name = "C_score";
            this.C_score.ToolTipText = "学分";
            // 
            // C_year
            // 
            this.C_year.DataPropertyName = "C_Year";
            this.C_year.HeaderText = "开设学年";
            this.C_year.Name = "C_year";
            this.C_year.ToolTipText = "开设学年";
            // 
            // C_term
            // 
            this.C_term.DataPropertyName = "C_Team";
            this.C_term.HeaderText = "开设学期";
            this.C_term.Name = "C_term";
            this.C_term.ToolTipText = "开设学期";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 343);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "查看课程性质";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(317, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "保存";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmStuSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 490);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Crouse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmStuSearch";
            this.Text = "FrmStuSearch";
            this.Load += new System.EventHandler(this.FrmStuSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Crouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Crouse;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_term;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

    }
}