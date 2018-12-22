using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace management
{
    public partial class FrmMenu : DockContent
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmStuSearch SSearch = new FrmStuSearch();//实例化子窗体
            OpenForm(SSearch);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddCrouse AC = new AddCrouse();
            OpenForm(AC);
        }
        private void OpenForm(DockContent frm)
        {
            FrmMain main = (FrmMain)this.Parent.Parent.Parent.Parent;//获取父窗体的父窗体
            string name = frm.Name;
            foreach (Form item in main.MdiChildren)
            {
                if (item.Name == name)
                {
                    item.Activate();
                    return;
                }
            }

            main.IsMdiContainer = true;//设置父窗体为容器窗体
            frm.MdiParent = main;//设置子窗体的父窗体
            frm.Show(main.dockPanel);//打开子窗体
        }
    }
}
