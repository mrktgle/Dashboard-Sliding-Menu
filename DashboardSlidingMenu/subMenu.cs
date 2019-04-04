using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace DashboardSlidingMenu
{
    public partial class subMenu : UserControl
    {
        int tab;
        ButtonControls ButtonControls = new ButtonControls();
        Routes Routes = new Routes();
        public subMenu()
        {
            InitializeComponent();
            if (Program.IsDesignMode()) return;
            PanelHider.Height = 23;
            VSReactive<int>.Subscribe("menu", tab => tabControl1.SelectedIndex = tab);
            ButtonControls.btn1 = 0;
        }

        private void subMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ButtonControls.button1 = button1.Text;
            ButtonControls.btn1 = 1;
            Routes.b1 = button1.Text;
        }
    }
}
