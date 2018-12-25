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

namespace management
{
    public partial class FrmStuSearch : DockContent
    {
        InterC ic = new InterC();
        public FrmStuSearch()
        {
            InitializeComponent();
        }

        private void FrmStuSearch_Load(object sender, EventArgs e)
        {
            DBSever.Course D = new DBSever.Course();
            DataTable dt = ic.SC();
            Crouse.DataSource = dt.DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBSever.Course D = new DBSever.Course();
            DataTable dt = ic.SC();
            Crouse.DataSource = dt.DefaultView;
        }


    }
}
