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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show(dockPanel,DockState.DockLeft);
            dockPanel.DockLeftPortion = 240;
            FrmHome home = new FrmHome();
            home.Show(dockPanel);
        }

        private void 学生查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStuSearch SSearch = new FrmStuSearch();
            SSearch.Show(dockPanel);
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCrouse AC = new AddCrouse();
            AC.Show(dockPanel);
        }

        
    }
}
