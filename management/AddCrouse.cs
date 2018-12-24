using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBSever;
using WeifenLuo.WinFormsUI.Docking;

namespace management
{
    public partial class AddCrouse : DockContent
    {
        public AddCrouse()
        {
            InitializeComponent();
        }

        private void AddCrouse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crouse crouse = new crouse();
            //学号
            crouse.C_Num = txtC_num.Text.Trim();
            //课程名称
            crouse.C_Name = txtC_name.Text;
            //学时
            crouse.C_Time = txt_C_time.Text;
            //学分
            crouse.C_Score = txtC_score.Text.Trim();
            //开设学年
            crouse.C_Year = txtC_year.Text;
            //开设学期
            crouse.C_Team = txtC_term.Text;
            string message = crouse.AddCrouse(crouse);
            MessageBox.Show(message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            crouse C = new crouse();

            //学号
            C.C_Num = txtC_num.Text.Trim();
            //课程名称
            C.C_Name = txtC_name.Text;
            //学时
            C.C_Time = txt_C_time.Text;
            //学分
            C.C_Score = txtC_score.Text.Trim();
            //开设学年
            C.C_Year = txtC_year.Text;
            //开设学期
            C.C_Team = txtC_term.Text;
            string message = C.upC(C);
            MessageBox.Show(message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtC_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                crouse SC = new crouse();
                //只要给课号赋值
                SC.C_Num = txtC_num.Text.Trim();
                SC = SC.SelectC(SC);

                txtC_name.Text = SC.C_Name;
                txt_C_time.Text = SC.C_Time;
                txtC_score.Text = SC.C_Score;
                txtC_year.Text = SC.C_Year;
                txtC_term.Text = SC.C_Team;
            }

        }


    }
}
