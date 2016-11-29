using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Budget_Planner
{
    public partial class MainForm : Form
    {
        MenuFRM menu = null;
        public MainForm()
        {
            InitializeComponent();
            menu = new MenuFRM(this);
            menu.Show(dockPanel_lay, DockState.DockLeftAutoHide);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection fontt = new PrivateFontCollection();
            fontt.AddFontFile("Resources/Lato-Light.ttf");
            //label1.Font = new Font(fontt.Families[0], 16, FontStyle.Italic);
        }
    }
}
