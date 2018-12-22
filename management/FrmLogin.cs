using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBSever;
using AES;
namespace management
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        //登录
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Login();
        }
        //取消
        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReg frm = new frmReg();
            frm.ShowDialog();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)//判断用户是否按下回车键
            {
                Login();
            }
        }
        private void Login()
        {
            string user_id = txtUser.Text.Trim();
            string user_pwd = txtPwd.Text;
            //可以对用户名的密码进行加密操作，增加安全性
            //user_pwd = AES.Test.AESEncrypt(user_pwd);
            userinfoService us = new userinfoService();
            bool flag = us.Login(user_id, user_pwd);
            if (flag)
            {
                MessageBox.Show("登陆成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("登录失败，用户名或密码错误", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
