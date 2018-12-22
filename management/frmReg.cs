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
    public partial class frmReg : Form
    {
        public frmReg()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string user_id = txtUser.Text.Trim();
            string user_pwd = txPwd.Text;
            string ip_addr = txtIp.Text.Trim();
            string mac_addr = txtMAC.Text.Trim();
            //可以对用户名的密码进行加密操作，增加安全性
            //user_pwd = AES.Test.AESEncrypt(user_pwd);
            //实例化Web服务对象
            userinfoService us = new userinfoService();
            string message=us.Register(user_id,user_pwd,ip_addr,mac_addr);
            MessageBox.Show(message,"信息提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
