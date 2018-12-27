using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


    }
}
