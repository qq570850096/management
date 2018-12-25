namespace management
{
    partial class AddCrouse
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
            this.txtC_num = new System.Windows.Forms.TextBox();
            this.txtC_score = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_C_time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC_year = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC_term = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "课号";
            // 
            // txtC_num
            // 
            this.txtC_num.Location = new System.Drawing.Point(165, 61);
            this.txtC_num.Name = "txtC_num";
            this.txtC_num.Size = new System.Drawing.Size(100, 20);
            this.txtC_num.TabIndex = 1;
            this.txtC_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtC_num_KeyDown);
            // 
            // txtC_score
            // 
            this.txtC_score.Location = new System.Drawing.Point(165, 178);
            this.txtC_score.Name = "txtC_score";
            this.txtC_score.Size = new System.Drawing.Size(100, 20);
            this.txtC_score.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "课程名称";
            // 
            // txtC_name
            // 
            this.txtC_name.Location = new System.Drawing.Point(165, 100);
            this.txtC_name.Name = "txtC_name";
            this.txtC_name.Size = new System.Drawing.Size(100, 20);
            this.txtC_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "学时";
            // 
            // txt_C_time
            // 
            this.txt_C_time.Location = new System.Drawing.Point(165, 139);
            this.txt_C_time.Name = "txt_C_time";
            this.txt_C_time.Size = new System.Drawing.Size(100, 20);
            this.txt_C_time.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "学分";
            // 
            // txtC_year
            // 
            this.txtC_year.Location = new System.Drawing.Point(165, 225);
            this.txtC_year.Name = "txtC_year";
            this.txtC_year.Size = new System.Drawing.Size(100, 20);
            this.txtC_year.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "开设学年";
            // 
            // txtC_term
            // 
            this.txtC_term.Location = new System.Drawing.Point(165, 263);
            this.txtC_term.Name = "txtC_term";
            this.txtC_term.Size = new System.Drawing.Size(100, 20);
            this.txtC_term.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "开设学期";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(237, 400);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 13;
            this.DelBtn.Text = "删除";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(162, 400);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(69, 23);
            this.changeBtn.TabIndex = 14;
            this.changeBtn.Text = "修改";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 336);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "任课教师";
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Location = new System.Drawing.Point(112, 301);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(61, 17);
            this.RB1.TabIndex = 20;
            this.RB1.TabStop = true;
            this.RB1.Text = "必修课";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(179, 301);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(61, 17);
            this.RB2.TabIndex = 21;
            this.RB2.TabStop = true;
            this.RB2.Text = "选修课";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Location = new System.Drawing.Point(251, 301);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(61, 17);
            this.RB3.TabIndex = 22;
            this.RB3.TabStop = true;
            this.RB3.Text = "实践课";
            this.RB3.UseVisualStyleBackColor = true;
            // 
            // AddCrouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 464);
            this.Controls.Add(this.RB3);
            this.Controls.Add(this.RB2);
            this.Controls.Add(this.RB1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtC_term);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtC_year);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_C_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtC_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtC_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtC_num);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "AddCrouse";
            this.Text = "AddCrouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtC_num;
        private System.Windows.Forms.TextBox txtC_score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtC_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_C_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtC_year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtC_term;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB3;
    }
}