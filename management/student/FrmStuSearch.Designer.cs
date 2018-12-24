﻿namespace management
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
            this.Crouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crouse.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Crouse.Location = new System.Drawing.Point(0, 0);
            this.Crouse.Name = "Crouse";
            this.Crouse.Size = new System.Drawing.Size(537, 490);
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
            this.C_score.DataPropertyName = "(C_Score";
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
            this.C_term.DataPropertyName = "C_Term";
            this.C_term.HeaderText = "开设学期";
            this.C_term.Name = "C_term";
            this.C_term.ToolTipText = "开设学期";
            // 
            // FrmStuSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 490);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn C_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_term;

    }
}