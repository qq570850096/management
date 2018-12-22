namespace management
{
    partial class FrmLogin
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
            this.btnC = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.user_id = new System.Windows.Forms.Label();
            this.user_pwd = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(179, 168);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "取消";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(89, 168);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "登录";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(89, 52);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(89, 103);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(100, 20);
            this.txtPwd.TabIndex = 1;
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.Location = new System.Drawing.Point(40, 52);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(43, 13);
            this.user_id.TabIndex = 5;
            this.user_id.Text = "用户名";
            // 
            // user_pwd
            // 
            this.user_pwd.AutoSize = true;
            this.user_pwd.Location = new System.Drawing.Point(52, 106);
            this.user_pwd.Name = "user_pwd";
            this.user_pwd.Size = new System.Drawing.Size(31, 13);
            this.user_pwd.TabIndex = 6;
            this.user_pwd.Text = "密码";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(40, 173);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(31, 13);
            this.lblReg.TabIndex = 7;
            this.lblReg.TabStop = true;
            this.lblReg.Text = "注册";
            this.lblReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblReg_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.user_pwd);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnC);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label user_id;
        private System.Windows.Forms.Label user_pwd;
        private System.Windows.Forms.LinkLabel lblReg;
    }
}