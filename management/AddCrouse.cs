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
        InterC ic = new InterC();
        DataClasses1DataContext DC = new DataClasses1DataContext();
        public AddCrouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterC C = new InterC();
            CNatu CN = new CNatu();
            DBSever.Course crouse = new DBSever.Course();
            //学号
            crouse.C_Num = txtC_num.Text.Trim();
            //课程名称
            crouse.C_Name = txtC_name.Text;
            //学时
            crouse.C_Time = Convert.ToInt16(txt_C_time.Text);
            //学分
            crouse.C_Score =Convert.ToInt16(txtC_score.Text.Trim());
            //开设学年
            crouse.C_Year = txtC_year.Text;
            //开设学期
            crouse.C_Team = txtC_term.Text;
            if (RB1.Checked == true)
            { 
                CN.CNat_Num = 1;
                CN.CNat_Name = "必修课";
                CN.C_Num = crouse.C_Num;
            }
            if(RB2.Checked==true)
            {
                CN.CNat_Num = 2;
                CN.CNat_Name = "选修课";
                CN.C_Num = crouse.C_Num;
            }
            
            if (RB3.Checked == true)
            {
                CN.CNat_Num = 3;
                CN.CNat_Name = "实践课";
                CN.C_Num = crouse.C_Num;
            }
           string message = C.AddC(crouse);
            DC.CNatu.InsertOnSubmit(CN);
            DC.SubmitChanges();
            MessageBox.Show(message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void changeBtn_Click(object sender, EventArgs e)
        {
            InterC ic = new InterC();
            CNatu CN = new CNatu();
            DBSever.Course C = new DBSever.Course();

            //学号
            C.C_Num = txtC_num.Text.Trim();
            //课程名称
            C.C_Name = txtC_name.Text;
            //学时
            C.C_Time = Convert.ToInt16(txt_C_time.Text);
            //学分
            C.C_Score = Convert.ToInt16(txtC_score.Text.Trim());
            //开设学年
            C.C_Year = txtC_year.Text;
            //开设学期
            C.C_Team = txtC_term.Text;

            if (RB1.Checked == true)
            {
                CN.CNat_Num = 1;
                CN.CNat_Name = "必修课";
                CN.C_Num = C.C_Num;
            }
            if (RB2.Checked == true)
            {
                CN.CNat_Num = 2;
                CN.CNat_Name = "选修课";
                CN.C_Num = C.C_Num;
            }

            if (RB3.Checked == true)
            {
                CN.CNat_Num = 3;
                CN.CNat_Name = "实践课";
                CN.C_Num = C.C_Num;
            }
            string message = ic.upC(C);
            DC.CNatu.InsertOnSubmit(CN);
            DC.SubmitChanges();
            MessageBox.Show(message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtC_num_KeyDown(object sender, KeyEventArgs e)
        {
            InterC ic=new InterC();
            if (e.KeyData == Keys.Return)
            {
                DBSever.Course SC = new DBSever.Course();
                 //只要给课号赋值
                 SC.C_Num = txtC_num.Text.Trim();
                 SC = ic.SelectC(SC);

                 txtC_name.Text = SC.C_Name;
                 txt_C_time.Text = SC.C_Time.ToString();
                 txtC_score.Text = SC.C_Score.ToString();
                 txtC_year.Text = SC.C_Year;
                 txtC_term.Text = SC.C_Team;
            }

        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            InterC ic = new InterC();
            DBSever.Course SC = new DBSever.Course();
            //只要给课号赋值
            SC.C_Num = txtC_num.Text.Trim();
            string message = ic.Del(SC);
            MessageBox.Show(message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




    }
}
