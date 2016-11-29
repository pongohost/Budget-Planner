using Plibs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Budget_Planner
{
    public partial class MenuFRM : DockContent
    {
        public MainForm mf = null;
        public MenuFRM()
        {
            InitializeComponent();
        }
        public MenuFRM(Form dari)
        {
            mf = dari as MainForm;
            InitializeComponent();
            bantu.initFont();
            btn_mpp.Font = new Font(bantu.pfc.Families[0], 12, FontStyle.Regular);
            btn_meal.Font = new Font(bantu.pfc.Families[0], 12, FontStyle.Regular);
            //groupBox1.Font = new Font(bantu.pfc.Families[0], 16, FontStyle.Regular);
            //CreateHRD();
        }

        private void mpp_btn_Click(object sender, EventArgs e)
        {
            MppForm FN = new MppForm();
            FN.Show(this.mf.dockPanel_lay);
        }

        private void btn_hrdparam_Click(object sender, EventArgs e)
        {
            ParamForm FN = new ParamForm();
            FN.Show(this.mf.dockPanel_lay);
        }
    }
}
