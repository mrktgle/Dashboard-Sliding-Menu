using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace DashboardSlidingMenu
{
    public partial class frmBase : Form
    {
        bool menuExpand = false;
        Routes Routes = new Routes();

        public frmBase()
        {
            InitializeComponent();
            if (Program.IsDesignMode()) return;
            PanelHider.Height = 22;
            VSReactive<int>.Subscribe("menu", tab => tabControl1.SelectedIndex = tab);
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_CAPTION = 0x00C00000;
                CreateParams baseParams = base.CreateParams;
                //Get rid of caption
                baseParams.Style = baseParams.Style & ~WS_CAPTION;
                return baseParams;
            }
        }

        protected void ReallyCenterToScreen()
        {
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }

        private void PanelHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Maximized;
                }
                else
                {
                    WindowState = FormWindowState.Normal;
                    ReallyCenterToScreen();
                }
            }
        }

        private void lblTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Maximized;
                }
                else
                {
                    WindowState = FormWindowState.Normal;
                    ReallyCenterToScreen();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                ReallyCenterToScreen();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!bunifuTransition1.IsCompleted) return;
            if (panelMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!menuExpand)
                {
                    pbLogoMainMenu.Location = new Point(33, 48);
                    lblUplay.Location = new Point(81, 59);
                    menuExpand = true;
                    panelMainMenu.Width = 200;
                }
            }
            else
            {
                if (menuExpand)
                {
                    pbLogoMainMenu.Location = new Point(3, 48);
                    menuExpand = false;
                    panelMainMenu.Visible = false;
                    panelMainMenu.Width = 50;
                    bunifuTransition1.Show(panelMainMenu);
                }
            }
        }

        public void PanelMainMenuHider()
        {
            pbLogoMainMenu.Location = new Point(3, 48);
            //panelMainMenu.Visible = false;
            panelMainMenu.Width = 50;
            bunifuTransition1.Show(panelMainMenu);
        }

        private void sidemenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu",int.Parse(((Control)sender).Tag.ToString()));
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            frmBase frmBase = this;
            BBaseForm bBaseForm = new BBaseForm();
            bBaseForm.MdiParent = this;
            bBaseForm.Show();
            Tab0Button1.IconVisible = true;
            Tab0Button2.IconVisible = true;
            Tab0Button1.IconZoom = 70;
            Tab0Button2.IconZoom = 80;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tab0Button1.IconVisible = true;
            Tab0Button2.IconVisible = true;
            Tab1Button1.IconVisible = true;
            Tab1Button2.IconVisible = true;
            Tab2Button1.IconVisible = true;
            Tab2Button2.IconVisible = true;

            Tab0Button1.IconZoom = 70;
            Tab0Button2.IconZoom = 80;
            Tab1Button1.IconZoom = 70;
            Tab1Button2.IconZoom = 70;
            Tab2Button1.IconZoom = 70;
            Tab2Button2.IconZoom = 70;
        }

        public void DisposeAllInActiveForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                    frm.Close();
                }
            }
        }

        private void Tab0Button1_Click(object sender, EventArgs e)
        {
            DisposeAllInActiveForms();
            frmBase frmBase = this;
            Routes.Access(Tab0Button1.Text, ref frmBase);
            PanelMainMenuHider();
        }

        private void Tab0Button2_Click(object sender, EventArgs e)
        {
            DisposeAllInActiveForms();
            frmBase frmBase = this;
            Routes.Access(Tab0Button2.Text, ref frmBase);
            PanelMainMenuHider();
        }


    }
}
