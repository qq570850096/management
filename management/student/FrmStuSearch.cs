using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using DBSever;
using System.Data;
using System.Data.SqlClient;

namespace management
{
    public partial class FrmStuSearch : DockContent
    {
        InterC ic = new InterC();
        DataClasses1DataContext DC = new DataClasses1DataContext();
        
        DataSet mydataBaseSet = new System.Data.DataSet();
        
        SqlDataAdapter adapter=new SqlDataAdapter();
        DBConn conn = new DBConn();
        BindingSource BS = new BindingSource();
        
        public FrmStuSearch()
        {
            InitializeComponent();
        }

        private void FrmStuSearch_Load(object sender, EventArgs e)
        {  
            
            mydataBaseSet = ic.DS();
            for (int i = 0; i < mydataBaseSet.Tables.Count; i++)
            {
                listBox1.Items.Add(mydataBaseSet.Tables[i].TableName);
            }
            
            listBox1.SelectedIndex = 0;
            Crouse.AllowUserToDeleteRows = false;
            Crouse.AllowUserToAddRows = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var b = (from c in DC.Course select c.C_Num).Union(from d in DC.CNatu select d.C_Num);

            

            
            
            //BS.DataSource = b;
            //Crouse.DataSource = BS;
            DataTable selected = new System.Data.DataTable();
            
            int index = listBox1.SelectedIndex;
            selected = mydataBaseSet.Tables[index];
            string QS = "select * from " + selected.TableName;
            adapter = new SqlDataAdapter(QS, conn.OpenConn());
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            //adapter.Fill(selected);
            BS.DataSource = selected;
            Crouse.DataSource = BS;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DBSever.Course D = new DBSever.Course();
            DataTable dt = ic.SC();
            Crouse.DataSource = dt.DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BS.AddNew();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Crouse.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先单机最左边的空白咧选择要删除的行，可以按住ctrl同时选中多行");

            }
            else
            {
                if (MessageBox.Show("请确定要删除吗?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    for (int i = Crouse.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        BS.RemoveAt(Crouse.SelectedRows[i].Index);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                BS.EndEdit();
                adapter.Update(mydataBaseSet.Tables[listBox1.SelectedIndex]);
                MessageBox.Show("保存成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "保存失败");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var query = from p in DC.Course
                            where p.C_Class == "必修"
                            select new { 课程号 = p.C_Num, 课程名称 = p.C_Name, 学分=p.C_Score, 课程类别=p.C_Class };
                BS.DataSource = query;
                Crouse.DataSource = BS;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                var query = from p in DC.Course
                            where p.C_Class == "辅修"
                            select new { 课程号 = p.C_Num, 课程名称 = p.C_Name, 学分 = p.C_Score, 课程类别 = p.C_Class };
                BS.DataSource = query;
                Crouse.DataSource = BS;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var query = from p in DC.Course
                        join q in DC.SC on p.C_Num equals q.C_Num
                        select new { 课程号 = p.C_Num, 课程名称 = p.C_Name, 课程类别 = p.C_Class, 学生号 = q.S_Num, 成绩 =q.Grade};
            var query1=from p in DC.Student
                       join qq in query on p.S_Num equals qq.学生号
                       where qq.课程名称 == textBox1.Text.Trim()
                       select new { 课程号 = qq.课程号, 课程名称 = qq.课程名称, 课程类别 = qq.课程类别, 学生号 = qq.学生号,学生姓名=p.S_Name, 成绩 = qq.成绩 };
            if (query1 != null)
            {
                BS.DataSource = query1;
                Crouse.DataSource = BS;
            }
            else
            {
                MessageBox.Show("没有查询到有此课程的选课信息，请检查是否输入有误");
            }
        }

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    var query1 = from p in DC.Course
        //                 join q in DC.CNatu on p.C_Num equals q.C_Num
        //                 select new  { 课程号 = p.C_Num , 课程名称 = p.C_Name, 性质码= q.CNat_Num ,课程性质=q.CNat_Name};
        //    this.Crouse.DataSource = query1;
        //}


    }
}
