namespace management
{
    partial class frmReg
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
            this.user_pwd = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.Label();
            this.txPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // user_pwd
            // 
            this.user_pwd.AutoSize = true;
            this.user_pwd.Location = new System.Drawing.Point(38, 65);
            this.user_pwd.Name = "user_pwd";
            this.user_pwd.Size = new System.Drawing.Size(31, 13);
            this.user_pwd.TabIndex = 13;
            this.user_pwd.Text = "密码";
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.Location = new System.Drawing.Point(36, 28);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(43, 13);
            this.user_id.TabIndex = 12;
            this.user_id.Text = "用户名";
            // 
            // txPwd
            // 
            this.txPwd.Location = new System.Drawing.Point(87, 65);
            this.txPwd.Name = "txPwd";
            this.txPwd.PasswordChar = '*';
            this.txPwd.Size = new System.Drawing.Size(100, 20);
            this.txPwd.TabIndex = 11;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(87, 28);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 10;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(41, 195);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 9;
            this.btnReg.Text = "注册";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(146, 195);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 8;
            this.btnC.Text = "取消";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "限制MAC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "限制IP";
            // 
            // txtMAC
            // 
            this.txtMAC.Location = new System.Drawing.Point(87, 140);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(100, 20);
            this.txtMAC.TabIndex = 15;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(87, 103);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 20);
            this.txtIp.TabIndex = 14;
            // 
            // frmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMAC);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.user_pwd);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.txPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnC);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "frmReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_pwd;
        private System.Windows.Forms.Label user_id;
        private System.Windows.Forms.TextBox txPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.TextBox txtIp;
    }
}