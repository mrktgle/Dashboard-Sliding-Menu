using System;

namespace DashboardSlidingMenu
{
    partial class frmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.lblUplay = new System.Windows.Forms.Label();
            this.pbLogoMainMenu = new System.Windows.Forms.PictureBox();
            this.tab3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbLogoTitle = new System.Windows.Forms.PictureBox();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelHider = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Tab0Button2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tab0Button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Tab1Button2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tab1Button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Tab2Button2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tab2Button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.PanelSubMenu = new System.Windows.Forms.Panel();
            this.lblDashBoard = new System.Windows.Forms.Label();
            this.pbLogoDashboard = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMainMenu)).BeginInit();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTitle)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.PanelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.panelMainMenu.Controls.Add(this.lblUplay);
            this.panelMainMenu.Controls.Add(this.pbLogoMainMenu);
            this.panelMainMenu.Controls.Add(this.tab3);
            this.panelMainMenu.Controls.Add(this.tab2);
            this.panelMainMenu.Controls.Add(this.tab1);
            this.bunifuTransition1.SetDecoration(this.panelMainMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(200, 535);
            this.panelMainMenu.TabIndex = 0;
            // 
            // lblUplay
            // 
            this.lblUplay.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblUplay, BunifuAnimatorNS.DecorationType.None);
            this.lblUplay.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(234)))));
            this.lblUplay.Location = new System.Drawing.Point(81, 59);
            this.lblUplay.Name = "lblUplay";
            this.lblUplay.Size = new System.Drawing.Size(65, 23);
            this.lblUplay.TabIndex = 7;
            this.lblUplay.Text = "Uplay";
            // 
            // pbLogoMainMenu
            // 
            this.bunifuTransition1.SetDecoration(this.pbLogoMainMenu, BunifuAnimatorNS.DecorationType.None);
            this.pbLogoMainMenu.Image = global::DashboardSlidingMenu.Properties.Resources.Uplay_48px;
            this.pbLogoMainMenu.Location = new System.Drawing.Point(33, 48);
            this.pbLogoMainMenu.Name = "pbLogoMainMenu";
            this.pbLogoMainMenu.Size = new System.Drawing.Size(42, 41);
            this.pbLogoMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoMainMenu.TabIndex = 4;
            this.pbLogoMainMenu.TabStop = false;
            // 
            // tab3
            // 
            this.tab3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.tab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab3.BorderRadius = 0;
            this.tab3.ButtonText = "           Logout";
            this.tab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab3, BunifuAnimatorNS.DecorationType.None);
            this.tab3.DisabledColor = System.Drawing.Color.Gray;
            this.tab3.Iconcolor = System.Drawing.Color.Transparent;
            this.tab3.Iconimage = global::DashboardSlidingMenu.Properties.Resources.Logout_52px;
            this.tab3.Iconimage_right = null;
            this.tab3.Iconimage_right_Selected = null;
            this.tab3.Iconimage_Selected = null;
            this.tab3.IconMarginLeft = 0;
            this.tab3.IconMarginRight = 0;
            this.tab3.IconRightVisible = true;
            this.tab3.IconRightZoom = 0D;
            this.tab3.IconVisible = true;
            this.tab3.IconZoom = 50D;
            this.tab3.IsTab = false;
            this.tab3.Location = new System.Drawing.Point(0, 222);
            this.tab3.Name = "tab3";
            this.tab3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab3.OnHoverTextColor = System.Drawing.Color.White;
            this.tab3.selected = false;
            this.tab3.Size = new System.Drawing.Size(200, 48);
            this.tab3.TabIndex = 2;
            this.tab3.Tag = "2";
            this.tab3.Text = "           Logout";
            this.tab3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab3.Textcolor = System.Drawing.Color.White;
            this.tab3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab3.Click += new System.EventHandler(this.sidemenu_Click);
            // 
            // tab2
            // 
            this.tab2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab2.BorderRadius = 0;
            this.tab2.ButtonText = "           Settings";
            this.tab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab2, BunifuAnimatorNS.DecorationType.None);
            this.tab2.DisabledColor = System.Drawing.Color.Gray;
            this.tab2.Iconcolor = System.Drawing.Color.Transparent;
            this.tab2.Iconimage = global::DashboardSlidingMenu.Properties.Resources.Settings_50px;
            this.tab2.Iconimage_right = null;
            this.tab2.Iconimage_right_Selected = null;
            this.tab2.Iconimage_Selected = null;
            this.tab2.IconMarginLeft = 0;
            this.tab2.IconMarginRight = 0;
            this.tab2.IconRightVisible = true;
            this.tab2.IconRightZoom = 0D;
            this.tab2.IconVisible = true;
            this.tab2.IconZoom = 50D;
            this.tab2.IsTab = false;
            this.tab2.Location = new System.Drawing.Point(0, 172);
            this.tab2.Name = "tab2";
            this.tab2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab2.OnHoverTextColor = System.Drawing.Color.White;
            this.tab2.selected = false;
            this.tab2.Size = new System.Drawing.Size(200, 48);
            this.tab2.TabIndex = 1;
            this.tab2.Tag = "1";
            this.tab2.Text = "           Settings";
            this.tab2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab2.Textcolor = System.Drawing.Color.White;
            this.tab2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2.Click += new System.EventHandler(this.sidemenu_Click);
            // 
            // tab1
            // 
            this.tab1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab1.BorderRadius = 0;
            this.tab1.ButtonText = "           Home";
            this.tab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab1, BunifuAnimatorNS.DecorationType.None);
            this.tab1.DisabledColor = System.Drawing.Color.Gray;
            this.tab1.Iconcolor = System.Drawing.Color.Transparent;
            this.tab1.Iconimage = global::DashboardSlidingMenu.Properties.Resources.Menu_50px;
            this.tab1.Iconimage_right = null;
            this.tab1.Iconimage_right_Selected = null;
            this.tab1.Iconimage_Selected = null;
            this.tab1.IconMarginLeft = 0;
            this.tab1.IconMarginRight = 0;
            this.tab1.IconRightVisible = true;
            this.tab1.IconRightZoom = 0D;
            this.tab1.IconVisible = true;
            this.tab1.IconZoom = 50D;
            this.tab1.IsTab = false;
            this.tab1.Location = new System.Drawing.Point(0, 122);
            this.tab1.Name = "tab1";
            this.tab1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab1.OnHoverTextColor = System.Drawing.Color.White;
            this.tab1.selected = false;
            this.tab1.Size = new System.Drawing.Size(200, 48);
            this.tab1.TabIndex = 0;
            this.tab1.Tag = "0";
            this.tab1.Text = "           Home";
            this.tab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab1.Textcolor = System.Drawing.Color.White;
            this.tab1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.Click += new System.EventHandler(this.sidemenu_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.PanelHeader.Controls.Add(this.btnExit);
            this.PanelHeader.Controls.Add(this.btnMaximize);
            this.PanelHeader.Controls.Add(this.btnMinimize);
            this.PanelHeader.Controls.Add(this.lblTitle);
            this.PanelHeader.Controls.Add(this.pbLogoTitle);
            this.bunifuTransition1.SetDecoration(this.PanelHeader, BunifuAnimatorNS.DecorationType.None);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(430, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(555, 31);
            this.PanelHeader.TabIndex = 1;
            this.PanelHeader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Image = global::DashboardSlidingMenu.Properties.Resources.Close_Window_52px;
            this.btnExit.ImageActive = global::DashboardSlidingMenu.Properties.Resources.Close_Window2_52px;
            this.btnExit.Location = new System.Drawing.Point(517, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 27);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 8;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximize.Image = global::DashboardSlidingMenu.Properties.Resources.Maximize_Window_52px;
            this.btnMaximize.ImageActive = global::DashboardSlidingMenu.Properties.Resources.Maximize_Window2_52px;
            this.btnMaximize.Location = new System.Drawing.Point(482, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(33, 27);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 9;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Zoom = 8;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Image = global::DashboardSlidingMenu.Properties.Resources.Minimize_Window_50px;
            this.btnMinimize.ImageActive = global::DashboardSlidingMenu.Properties.Resources.Minimize_Window2_50px;
            this.btnMinimize.Location = new System.Drawing.Point(445, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 8;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(44, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 22);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "(Title of the System)";
            this.lblTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDoubleClick);
            // 
            // pbLogoTitle
            // 
            this.bunifuTransition1.SetDecoration(this.pbLogoTitle, BunifuAnimatorNS.DecorationType.None);
            this.pbLogoTitle.Image = global::DashboardSlidingMenu.Properties.Resources.Google_Play_50px;
            this.pbLogoTitle.Location = new System.Drawing.Point(4, 2);
            this.pbLogoTitle.Name = "pbLogoTitle";
            this.pbLogoTitle.Size = new System.Drawing.Size(42, 27);
            this.pbLogoTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoTitle.TabIndex = 3;
            this.pbLogoTitle.TabStop = false;
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.PanelHider);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.PanelSubMenu);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 535);
            this.panel1.TabIndex = 2;
            // 
            // PanelHider
            // 
            this.PanelHider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuTransition1.SetDecoration(this.PanelHider, BunifuAnimatorNS.DecorationType.None);
            this.PanelHider.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHider.Location = new System.Drawing.Point(0, 106);
            this.PanelHider.Name = "PanelHider";
            this.PanelHider.Size = new System.Drawing.Size(230, 1);
            this.PanelHider.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.bunifuTransition1.SetDecoration(this.tabControl1, BunifuAnimatorNS.DecorationType.None);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 106);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(230, 429);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage1.Controls.Add(this.Tab0Button2);
            this.tabPage1.Controls.Add(this.Tab0Button1);
            this.bunifuTransition1.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(222, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "0";
            // 
            // Tab0Button2
            // 
            this.Tab0Button2.Activecolor = System.Drawing.Color.Silver;
            this.Tab0Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tab0Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab0Button2.BorderRadius = 0;
            this.Tab0Button2.ButtonText = "    System Analyst";
            this.Tab0Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Tab0Button2, BunifuAnimatorNS.DecorationType.None);
            this.Tab0Button2.DisabledColor = System.Drawing.Color.Gray;
            this.Tab0Button2.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab0Button2.Iconimage = ((System.Drawing.Image)(resources.GetObject("Tab0Button2.Iconimage")));
            this.Tab0Button2.Iconimage_right = null;
            this.Tab0Button2.Iconimage_right_Selected = null;
            this.Tab0Button2.Iconimage_Selected = null;
            this.Tab0Button2.IconMarginLeft = 0;
            this.Tab0Button2.IconMarginRight = 0;
            this.Tab0Button2.IconRightVisible = false;
            this.Tab0Button2.IconRightZoom = 0D;
            this.Tab0Button2.IconVisible = false;
            this.Tab0Button2.IconZoom = 80D;
            this.Tab0Button2.IsTab = false;
            this.Tab0Button2.Location = new System.Drawing.Point(1, 43);
            this.Tab0Button2.Name = "Tab0Button2";
            this.Tab0Button2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tab0Button2.OnHovercolor = System.Drawing.Color.LightGray;
            this.Tab0Button2.OnHoverTextColor = System.Drawing.Color.White;
            this.Tab0Button2.selected = false;
            this.Tab0Button2.Size = new System.Drawing.Size(221, 39);
            this.Tab0Button2.TabIndex = 3;
            this.Tab0Button2.Text = "    System Analyst";
            this.Tab0Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab0Button2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tab0Button2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Tab0Button2.Click += new System.EventHandler(this.Tab0Button2_Click);
            // 
            // Tab0Button1
            // 
            this.Tab0Button1.Activecolor = System.Drawing.Color.Silver;
            this.Tab0Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tab0Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab0Button1.BorderRadius = 0;
            this.Tab0Button1.ButtonText = "    General";
            this.Tab0Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Tab0Button1, BunifuAnimatorNS.DecorationType.None);
            this.Tab0Button1.DisabledColor = System.Drawing.Color.Gray;
            this.Tab0Button1.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab0Button1.Iconimage = global::DashboardSlidingMenu.Properties.Resources.Deviation_52px;
            this.Tab0Button1.Iconimage_right = null;
            this.Tab0Button1.Iconimage_right_Selected = null;
            this.Tab0Button1.Iconimage_Selected = null;
            this.Tab0Button1.IconMarginLeft = 0;
            this.Tab0Button1.IconMarginRight = 0;
            this.Tab0Button1.IconRightVisible = false;
            this.Tab0Button1.IconRightZoom = 0D;
            this.Tab0Button1.IconVisible = false;
            this.Tab0Button1.IconZoom = 70D;
            this.Tab0Button1.IsTab = false;
            this.Tab0Button1.Location = new System.Drawing.Point(1, 2);
            this.Tab0Button1.Name = "Tab0Button1";
            this.Tab0Button1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tab0Button1.OnHovercolor = System.Drawing.Color.LightGray;
            this.Tab0Button1.OnHoverTextColor = System.Drawing.Color.White;
            this.Tab0Button1.selected = false;
            this.Tab0Button1.Size = new System.Drawing.Size(221, 39);
            this.Tab0Button1.TabIndex = 2;
            this.Tab0Button1.Text = "    General";
            this.Tab0Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab0Button1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tab0Button1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Tab0Button1.Click += new System.EventHandler(this.Tab0Button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage2.Controls.Add(this.Tab1Button2);
            this.tabPage2.Controls.Add(this.Tab1Button1);
            this.bunifuTransition1.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(222, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1";
            // 
            // Tab1Button2
            // 
            this.Tab1Button2.Activecolor = System.Drawing.Color.DimGray;
            this.Tab1Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tab1Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab1Button2.BorderRadius = 0;
            this.Tab1Button2.ButtonText = "    Backup and restore database";
            this.Tab1Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Tab1Button2, BunifuAnimatorNS.DecorationType.None);
            this.Tab1Button2.DisabledColor = System.Drawing.Color.Gray;
            this.Tab1Button2.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab1Button2.Iconimage = ((System.Drawing.Image)(resources.GetObject("Tab1Button2.Iconimage")));
            this.Tab1Button2.Iconimage_right = null;
            this.Tab1Button2.Iconimage_right_Selected = null;
            this.Tab1Button2.Iconimage_Selected = null;
            this.Tab1Button2.IconMarginLeft = 0;
            this.Tab1Button2.IconMarginRight = 0;
            this.Tab1Button2.IconRightVisible = false;
            this.Tab1Button2.IconRightZoom = 0D;
            this.Tab1Button2.IconVisible = false;
            this.Tab1Button2.IconZoom = 70D;
            this.Tab1Button2.IsTab = false;
            this.Tab1Button2.Location = new System.Drawing.Point(1, 43);
            this.Tab1Button2.Name = "Tab1Button2";
            this.Tab1Button2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tab1Button2.OnHovercolor = System.Drawing.Color.DarkGray;
            this.Tab1Button2.OnHoverTextColor = System.Drawing.Color.White;
            this.Tab1Button2.selected = false;
            this.Tab1Button2.Size = new System.Drawing.Size(219, 39);
            this.Tab1Button2.TabIndex = 7;
            this.Tab1Button2.Text = "    Backup and restore database";
            this.Tab1Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab1Button2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tab1Button2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Tab1Button1
            // 
            this.Tab1Button1.Activecolor = System.Drawing.Color.DimGray;
            this.Tab1Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tab1Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab1Button1.BorderRadius = 0;
            this.Tab1Button1.ButtonText = "    Change Password";
            this.Tab1Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Tab1Button1, BunifuAnimatorNS.DecorationType.None);
            this.Tab1Button1.DisabledColor = System.Drawing.Color.Gray;
            this.Tab1Button1.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab1Button1.Iconimage = global::DashboardSlidingMenu.Properties.Resources.Password_52px;
            this.Tab1Button1.Iconimage_right = null;
            this.Tab1Button1.Iconimage_right_Selected = null;
            this.Tab1Button1.Iconimage_Selected = null;
            this.Tab1Button1.IconMarginLeft = 0;
            this.Tab1Button1.IconMarginRight = 0;
            this.Tab1Button1.IconRightVisible = false;
            this.Tab1Button1.IconRightZoom = 0D;
            this.Tab1Button1.IconVisible = false;
            this.Tab1Button1.IconZoom = 70D;
            this.Tab1Button1.IsTab = false;
            this.Tab1Button1.Location = new System.Drawing.Point(1, 2);
            this.Tab1Button1.Name = "Tab1Button1";
            this.Tab1Button1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tab1Button1.OnHovercolor = System.Drawing.Color.DarkGray;
            this.Tab1Button1.OnHoverTextColor = System.Drawing.Color.White;
            this.Tab1Button1.selected = false;
            this.Tab1Button1.Size = new System.Drawing.Size(221, 39);
            this.Tab1Button1.TabIndex = 6;
            this.Tab1Button1.Text = "    Change Password";
            this.Tab1Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab1Button1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tab1Button1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage3.Controls.Add(this.Tab2Button2);
            this.tabPage3.Controls.Add(this.Tab2Button1);
            this.bunifuTransition1.SetDecoration(this.tabPage3, BunifuAnimatorNS.DecorationType.None);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(222, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2";
            // 
            // Tab2Button2
            // 
            this.Tab2Button2.Activecolor = System.Drawing.Color.DimGray;
            this.Tab2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tab2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab2Button2.BorderRadius = 0;
            this.Tab2Button2.ButtonText = "    Exit";
            this.Tab2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Tab2Button2, BunifuAnimatorNS.DecorationType.None);
            this.Tab2Button2.DisabledColor = System.Drawing.Color.Gray;
            this.Tab2Button2.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab2Button2.Iconimage = global::DashboardSlidingMenu.Properties.Resources.Exit_50px;
            this.Tab2Button2.Iconimage_right = null;
            this.Tab2Button2.Iconimage_right_Selected = null;
            this.Tab2Button2.Iconimage_Selected = null;
            this.Tab2Button2.IconMarginLeft = 0;
            this.Tab2Button2.IconMarginRight = 0;
            this.Tab2Button2.IconRightVisible = false;
            this.Tab2Button2.IconRightZoom = 0D;
            this.Tab2Button2.IconVisible = false;
            this.Tab2Button2.IconZoom = 70D;
            this.Tab2Button2.IsTab = false;
            this.Tab2Button2.Location = new System.Drawing.Point(1, 43);
            this.Tab2Button2.Name = "Tab2Button2";
            this.Tab2Button2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tab2Button2.OnHovercolor = System.Drawing.Color.DarkGray;
            this.Tab2Button2.OnHoverTextColor = System.Drawing.Color.White;
            this.Tab2Button2.selected = false;
            this.Tab2Button2.Size = new System.Drawing.Size(221, 39);
            this.Tab2Button2.TabIndex = 7;
            this.Tab2Button2.Text = "    Exit";
            this.Tab2Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab2Button2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tab2Button2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // Tab2Button1
            // 
            this.Tab2Button1.Activecolor = System.Drawing.Color.DimGray;
            this.Tab2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tab2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab2Button1.BorderRadius = 0;
            this.Tab2Button1.ButtonText = "    Info";
            this.Tab2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Tab2Button1, BunifuAnimatorNS.DecorationType.None);
            this.Tab2Button1.DisabledColor = System.Drawing.Color.Gray;
            this.Tab2Button1.Iconcolor = System.Drawing.Color.Transparent;
            this.Tab2Button1.Iconimage = global::DashboardSlidingMenu.Properties.Resources.Info_52px;
            this.Tab2Button1.Iconimage_right = null;
            this.Tab2Button1.Iconimage_right_Selected = null;
            this.Tab2Button1.Iconimage_Selected = null;
            this.Tab2Button1.IconMarginLeft = 0;
            this.Tab2Button1.IconMarginRight = 0;
            this.Tab2Button1.IconRightVisible = false;
            this.Tab2Button1.IconRightZoom = 0D;
            this.Tab2Button1.IconVisible = false;
            this.Tab2Button1.IconZoom = 70D;
            this.Tab2Button1.IsTab = false;
            this.Tab2Button1.Location = new System.Drawing.Point(1, 0);
            this.Tab2Button1.Name = "Tab2Button1";
            this.Tab2Button1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Tab2Button1.OnHovercolor = System.Drawing.Color.DarkGray;
            this.Tab2Button1.OnHoverTextColor = System.Drawing.Color.White;
            this.Tab2Button1.selected = false;
            this.Tab2Button1.Size = new System.Drawing.Size(221, 39);
            this.Tab2Button1.TabIndex = 6;
            this.Tab2Button1.Text = "    Info";
            this.Tab2Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab2Button1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tab2Button1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // tabPage4
            // 
            this.bunifuTransition1.SetDecoration(this.tabPage4, BunifuAnimatorNS.DecorationType.None);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(222, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.bunifuTransition1.SetDecoration(this.tabPage5, BunifuAnimatorNS.DecorationType.None);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(222, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "4";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.bunifuTransition1.SetDecoration(this.tabPage6, BunifuAnimatorNS.DecorationType.None);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(222, 400);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "5";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.bunifuTransition1.SetDecoration(this.tabPage7, BunifuAnimatorNS.DecorationType.None);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(222, 400);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "6";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.bunifuTransition1.SetDecoration(this.tabPage8, BunifuAnimatorNS.DecorationType.None);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(222, 400);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "7";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.bunifuTransition1.SetDecoration(this.tabPage9, BunifuAnimatorNS.DecorationType.None);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(222, 400);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "8";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // PanelSubMenu
            // 
            this.PanelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PanelSubMenu.Controls.Add(this.lblDashBoard);
            this.PanelSubMenu.Controls.Add(this.pbLogoDashboard);
            this.bunifuTransition1.SetDecoration(this.PanelSubMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelSubMenu.Name = "PanelSubMenu";
            this.PanelSubMenu.Size = new System.Drawing.Size(230, 106);
            this.PanelSubMenu.TabIndex = 0;
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblDashBoard, BunifuAnimatorNS.DecorationType.None);
            this.lblDashBoard.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.lblDashBoard.Location = new System.Drawing.Point(70, 59);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(112, 23);
            this.lblDashBoard.TabIndex = 6;
            this.lblDashBoard.Text = "Dashboard";
            // 
            // pbLogoDashboard
            // 
            this.bunifuTransition1.SetDecoration(this.pbLogoDashboard, BunifuAnimatorNS.DecorationType.None);
            this.pbLogoDashboard.Image = global::DashboardSlidingMenu.Properties.Resources.Uplay_48px;
            this.pbLogoDashboard.Location = new System.Drawing.Point(22, 48);
            this.pbLogoDashboard.Name = "pbLogoDashboard";
            this.pbLogoDashboard.Size = new System.Drawing.Size(42, 41);
            this.pbLogoDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoDashboard.TabIndex = 5;
            this.pbLogoDashboard.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelMainMenu;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.PanelSubMenu;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = this.lblTitle;
            this.bunifuDragControl4.Vertical = true;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 535);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMainMenu);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMainMenu)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTitle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.PanelSubMenu.ResumeLayout(false);
            this.PanelSubMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Timer MouseDetect;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.PictureBox pbLogoTitle;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelSubMenu;
        private System.Windows.Forms.PictureBox pbLogoMainMenu;
        private System.Windows.Forms.Label lblDashBoard;
        private System.Windows.Forms.PictureBox pbLogoDashboard;
        private System.Windows.Forms.Label lblUplay;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        public Bunifu.Framework.UI.BunifuFlatButton tab1;
        public Bunifu.Framework.UI.BunifuFlatButton tab3;
        public Bunifu.Framework.UI.BunifuFlatButton tab2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel PanelHider;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private Bunifu.Framework.UI.BunifuFlatButton Tab0Button2;
        private Bunifu.Framework.UI.BunifuFlatButton Tab0Button1;
        private Bunifu.Framework.UI.BunifuFlatButton Tab1Button2;
        private Bunifu.Framework.UI.BunifuFlatButton Tab1Button1;
        private Bunifu.Framework.UI.BunifuFlatButton Tab2Button2;
        private Bunifu.Framework.UI.BunifuFlatButton Tab2Button1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl4;
    }
}