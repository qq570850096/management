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
        public FrmStuSearch()
        {
            InitializeComponent();
        }

        private void FrmStuSearch_Load(object sender, EventArgs e)
        {
            crouse C = new crouse();
            DataTable dt = C.SC();
            Crouse.DataSource = dt.DefaultView;
        }


    }
}
