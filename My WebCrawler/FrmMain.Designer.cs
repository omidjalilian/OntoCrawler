namespace My_WebCrawler
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerMem = new System.Windows.Forms.Timer(this.components);
            this.imageListPercentage = new System.Windows.Forms.ImageList(this.components);
            this.timerConnectInfo = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemState = new System.Windows.Forms.MenuItem();
            this.menuItemPlay = new System.Windows.Forms.MenuItem();
            this.menuItemPause = new System.Windows.Forms.MenuItem();
            this.menuItemStop = new System.Windows.Forms.MenuItem();
            this.menuItemOptions = new System.Windows.Forms.MenuItem();
            this.menuItemFileMatches = new System.Windows.Forms.MenuItem();
            this.menuItemConnections = new System.Windows.Forms.MenuItem();
            this.buttonGo = new System.Windows.Forms.Button();
            this.comboBoxWeb = new System.Windows.Forms.ComboBox();
            this.toolBarMain = new System.Windows.Forms.ToolBar();
            this.toolBarButtonContinue = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonPause = new System.Windows.Forms.ToolBarButton();
            this.toolBarButtonStop = new System.Windows.Forms.ToolBarButton();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.statusBarPanelInfo = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelURLs = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelFiles = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelByteCount = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelErrors = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelCPU = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelMem = new System.Windows.Forms.StatusBarPanel();
            this.tabControlRightView = new System.Windows.Forms.TabControl();
            this.tabPageThreads = new System.Windows.Forms.TabPage();
            this.listViewThreads = new System.Windows.Forms.ListView();
            this.columnHeaderTHreadID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderThreadDepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderThreadAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderThreadURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderThreadBytes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderThreadPersentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageRequests = new System.Windows.Forms.TabPage();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listViewRequests = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageErrors = new System.Windows.Forms.TabPage();
            this.textBoxErrorDescription = new System.Windows.Forms.TextBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.listViewErrors = new System.Windows.Forms.ListView();
            this.columnHeaderErrorID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderErrorItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderErrorDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelURLs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelByteCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelMem)).BeginInit();
            this.tabControlRightView.SuspendLayout();
            this.tabPageThreads.SuspendLayout();
            this.tabPageRequests.SuspendLayout();
            this.tabPageErrors.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList4
            // 
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
            this.imageList4.TransparentColor = System.Drawing.Color.Teal;
            this.imageList4.Images.SetKeyName(0, "");
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "");
            this.imageList3.Images.SetKeyName(1, "");
            this.imageList3.Images.SetKeyName(2, "");
            this.imageList3.Images.SetKeyName(3, "");
            this.imageList3.Images.SetKeyName(4, "");
            this.imageList3.Images.SetKeyName(5, "");
            this.imageList3.Images.SetKeyName(6, "");
            this.imageList3.Images.SetKeyName(7, "");
            this.imageList3.Images.SetKeyName(8, "");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Teal;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // timerMem
            // 
            this.timerMem.Enabled = true;
            this.timerMem.Interval = 2000;
            this.timerMem.Tick += new System.EventHandler(this.timerMem_Tick);
            // 
            // imageListPercentage
            // 
            this.imageListPercentage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPercentage.ImageStream")));
            this.imageListPercentage.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPercentage.Images.SetKeyName(0, "");
            this.imageListPercentage.Images.SetKeyName(1, "");
            this.imageListPercentage.Images.SetKeyName(2, "");
            this.imageListPercentage.Images.SetKeyName(3, "");
            this.imageListPercentage.Images.SetKeyName(4, "");
            this.imageListPercentage.Images.SetKeyName(5, "");
            this.imageListPercentage.Images.SetKeyName(6, "");
            this.imageListPercentage.Images.SetKeyName(7, "");
            this.imageListPercentage.Images.SetKeyName(8, "");
            this.imageListPercentage.Images.SetKeyName(9, "");
            this.imageListPercentage.Images.SetKeyName(10, "");
            // 
            // timerConnectInfo
            // 
            this.timerConnectInfo.Enabled = true;
            this.timerConnectInfo.Interval = 15000;
            this.timerConnectInfo.Tick += new System.EventHandler(this.timerConnectInfo_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Address:";
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemState,
            this.menuItemOptions});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemExit});
            this.menuItemFile.Text = "&File";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 0;
            this.menuItemExit.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemState
            // 
            this.menuItemState.Index = 1;
            this.menuItemState.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemPlay,
            this.menuItemPause,
            this.menuItemStop});
            this.menuItemState.Text = "State";
            // 
            // menuItemPlay
            // 
            this.menuItemPlay.Index = 0;
            this.menuItemPlay.Text = "Play";
            this.menuItemPlay.Click += new System.EventHandler(this.menuItemPlay_Click);
            // 
            // menuItemPause
            // 
            this.menuItemPause.Index = 1;
            this.menuItemPause.Text = "Pause";
            this.menuItemPause.Click += new System.EventHandler(this.menuItemPause_Click);
            // 
            // menuItemStop
            // 
            this.menuItemStop.Index = 2;
            this.menuItemStop.Text = "Stop";
            this.menuItemStop.Click += new System.EventHandler(this.menuItemStop_Click);
            // 
            // menuItemOptions
            // 
            this.menuItemOptions.Index = 2;
            this.menuItemOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFileMatches,
            this.menuItemConnections});
            this.menuItemOptions.Text = "&Options";
            // 
            // menuItemFileMatches
            // 
            this.menuItemFileMatches.Index = 0;
            this.menuItemFileMatches.Text = "&MIME types...";
            this.menuItemFileMatches.Click += new System.EventHandler(this.menuItemFileMatches_Click);
            // 
            // menuItemConnections
            // 
            this.menuItemConnections.Index = 1;
            this.menuItemConnections.Text = "&Connections...";
            this.menuItemConnections.Click += new System.EventHandler(this.menuItemConnections_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGo.ImageIndex = 0;
            this.buttonGo.ImageList = this.imageList1;
            this.buttonGo.Location = new System.Drawing.Point(932, 51);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(60, 34);
            this.buttonGo.TabIndex = 17;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // comboBoxWeb
            // 
            this.comboBoxWeb.AllowDrop = true;
            this.comboBoxWeb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxWeb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxWeb.ItemHeight = 20;
            this.comboBoxWeb.Location = new System.Drawing.Point(93, 54);
            this.comboBoxWeb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxWeb.MaxDropDownItems = 20;
            this.comboBoxWeb.Name = "comboBoxWeb";
            this.comboBoxWeb.Size = new System.Drawing.Size(828, 28);
            this.comboBoxWeb.TabIndex = 16;
            this.comboBoxWeb.Tag = "Settings";
            this.comboBoxWeb.Text = "http://www.football3.ir";
            // 
            // toolBarMain
            // 
            this.toolBarMain.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarMain.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButtonContinue,
            this.toolBarButtonPause,
            this.toolBarButtonStop});
            this.toolBarMain.ButtonSize = new System.Drawing.Size(16, 16);
            this.toolBarMain.DropDownArrows = true;
            this.toolBarMain.ImageList = this.imageList2;
            this.toolBarMain.Location = new System.Drawing.Point(0, 0);
            this.toolBarMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolBarMain.Name = "toolBarMain";
            this.toolBarMain.ShowToolTips = true;
            this.toolBarMain.Size = new System.Drawing.Size(1020, 28);
            this.toolBarMain.TabIndex = 19;
            // 
            // toolBarButtonContinue
            // 
            this.toolBarButtonContinue.Enabled = false;
            this.toolBarButtonContinue.ImageIndex = 0;
            this.toolBarButtonContinue.Name = "toolBarButtonContinue";
            this.toolBarButtonContinue.ToolTipText = "Coninue parsing process";
            // 
            // toolBarButtonPause
            // 
            this.toolBarButtonPause.Enabled = false;
            this.toolBarButtonPause.ImageIndex = 1;
            this.toolBarButtonPause.Name = "toolBarButtonPause";
            this.toolBarButtonPause.ToolTipText = "Pause parsing process";
            // 
            // toolBarButtonStop
            // 
            this.toolBarButtonStop.ImageIndex = 2;
            this.toolBarButtonStop.Name = "toolBarButtonStop";
            this.toolBarButtonStop.ToolTipText = "Stop parsing process";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 448);
            this.statusBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanelInfo,
            this.statusBarPanelURLs,
            this.statusBarPanelFiles,
            this.statusBarPanelByteCount,
            this.statusBarPanelErrors,
            this.statusBarPanelCPU,
            this.statusBarPanelMem});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(1020, 34);
            this.statusBar.TabIndex = 20;
            this.statusBar.Text = "Ready";
            // 
            // statusBarPanelInfo
            // 
            this.statusBarPanelInfo.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarPanelInfo.Name = "statusBarPanelInfo";
            this.statusBarPanelInfo.ToolTipText = "View total parsed uris";
            this.statusBarPanelInfo.Width = 708;
            // 
            // statusBarPanelURLs
            // 
            this.statusBarPanelURLs.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanelURLs.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanelURLs.Name = "statusBarPanelURLs";
            this.statusBarPanelURLs.ToolTipText = "View unique hits count";
            this.statusBarPanelURLs.Width = 10;
            // 
            // statusBarPanelFiles
            // 
            this.statusBarPanelFiles.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanelFiles.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanelFiles.Name = "statusBarPanelFiles";
            this.statusBarPanelFiles.ToolTipText = "View total hits count";
            this.statusBarPanelFiles.Width = 10;
            // 
            // statusBarPanelByteCount
            // 
            this.statusBarPanelByteCount.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanelByteCount.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanelByteCount.Name = "statusBarPanelByteCount";
            this.statusBarPanelByteCount.ToolTipText = "View total bytes of parsed items";
            this.statusBarPanelByteCount.Width = 10;
            // 
            // statusBarPanelErrors
            // 
            this.statusBarPanelErrors.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanelErrors.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanelErrors.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanelErrors.Icon")));
            this.statusBarPanelErrors.Name = "statusBarPanelErrors";
            this.statusBarPanelErrors.ToolTipText = "View errors count";
            this.statusBarPanelErrors.Width = 47;
            // 
            // statusBarPanelCPU
            // 
            this.statusBarPanelCPU.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanelCPU.Icon")));
            this.statusBarPanelCPU.Name = "statusBarPanelCPU";
            this.statusBarPanelCPU.ToolTipText = "CPU usage";
            this.statusBarPanelCPU.Width = 110;
            // 
            // statusBarPanelMem
            // 
            this.statusBarPanelMem.Name = "statusBarPanelMem";
            this.statusBarPanelMem.ToolTipText = "Available memory";
            // 
            // tabControlRightView
            // 
            this.tabControlRightView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlRightView.Controls.Add(this.tabPageThreads);
            this.tabControlRightView.Controls.Add(this.tabPageRequests);
            this.tabControlRightView.Controls.Add(this.tabPageErrors);
            this.tabControlRightView.ImageList = this.imageList3;
            this.tabControlRightView.Location = new System.Drawing.Point(0, 95);
            this.tabControlRightView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlRightView.Name = "tabControlRightView";
            this.tabControlRightView.SelectedIndex = 0;
            this.tabControlRightView.ShowToolTips = true;
            this.tabControlRightView.Size = new System.Drawing.Size(1020, 349);
            this.tabControlRightView.TabIndex = 21;
            this.tabControlRightView.Tag = "Main Tab";
            // 
            // tabPageThreads
            // 
            this.tabPageThreads.Controls.Add(this.listViewThreads);
            this.tabPageThreads.ImageIndex = 6;
            this.tabPageThreads.Location = new System.Drawing.Point(4, 29);
            this.tabPageThreads.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageThreads.Name = "tabPageThreads";
            this.tabPageThreads.Size = new System.Drawing.Size(1012, 316);
            this.tabPageThreads.TabIndex = 3;
            this.tabPageThreads.Text = "Threads";
            this.tabPageThreads.ToolTipText = "View working threads status";
            // 
            // listViewThreads
            // 
            this.listViewThreads.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewThreads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTHreadID,
            this.columnHeaderThreadDepth,
            this.columnHeaderThreadAction,
            this.columnHeaderThreadURL,
            this.columnHeaderThreadBytes,
            this.columnHeaderThreadPersentage});
            this.listViewThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewThreads.FullRowSelect = true;
            this.listViewThreads.GridLines = true;
            this.listViewThreads.HideSelection = false;
            this.listViewThreads.Location = new System.Drawing.Point(0, 0);
            this.listViewThreads.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewThreads.MultiSelect = false;
            this.listViewThreads.Name = "listViewThreads";
            this.listViewThreads.Size = new System.Drawing.Size(1012, 316);
            this.listViewThreads.SmallImageList = this.imageList3;
            this.listViewThreads.TabIndex = 0;
            this.listViewThreads.UseCompatibleStateImageBehavior = false;
            this.listViewThreads.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTHreadID
            // 
            this.columnHeaderTHreadID.Text = "ID";
            this.columnHeaderTHreadID.Width = 40;
            // 
            // columnHeaderThreadDepth
            // 
            this.columnHeaderThreadDepth.Text = "Depth";
            this.columnHeaderThreadDepth.Width = 43;
            // 
            // columnHeaderThreadAction
            // 
            this.columnHeaderThreadAction.Text = "Action";
            // 
            // columnHeaderThreadURL
            // 
            this.columnHeaderThreadURL.Text = "Uri";
            this.columnHeaderThreadURL.Width = 300;
            // 
            // columnHeaderThreadBytes
            // 
            this.columnHeaderThreadBytes.Text = "Bytes";
            this.columnHeaderThreadBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderThreadBytes.Width = 70;
            // 
            // columnHeaderThreadPersentage
            // 
            this.columnHeaderThreadPersentage.Text = "%";
            this.columnHeaderThreadPersentage.Width = 40;
            // 
            // tabPageRequests
            // 
            this.tabPageRequests.Controls.Add(this.textBoxRequest);
            this.tabPageRequests.Controls.Add(this.splitter1);
            this.tabPageRequests.Controls.Add(this.listViewRequests);
            this.tabPageRequests.ImageIndex = 8;
            this.tabPageRequests.Location = new System.Drawing.Point(4, 29);
            this.tabPageRequests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageRequests.Name = "tabPageRequests";
            this.tabPageRequests.Size = new System.Drawing.Size(1012, 316);
            this.tabPageRequests.TabIndex = 5;
            this.tabPageRequests.Text = "Requests";
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRequest.Location = new System.Drawing.Point(0, 237);
            this.textBoxRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRequest.Multiline = true;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRequest.Size = new System.Drawing.Size(1012, 79);
            this.textBoxRequest.TabIndex = 5;
            this.textBoxRequest.WordWrap = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 232);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1012, 5);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // listViewRequests
            // 
            this.listViewRequests.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewRequests.FullRowSelect = true;
            this.listViewRequests.GridLines = true;
            this.listViewRequests.HideSelection = false;
            this.listViewRequests.Location = new System.Drawing.Point(0, 0);
            this.listViewRequests.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewRequests.MultiSelect = false;
            this.listViewRequests.Name = "listViewRequests";
            this.listViewRequests.Size = new System.Drawing.Size(1012, 232);
            this.listViewRequests.TabIndex = 3;
            this.listViewRequests.UseCompatibleStateImageBehavior = false;
            this.listViewRequests.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Request";
            this.columnHeader3.Width = 400;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 0;
            // 
            // tabPageErrors
            // 
            this.tabPageErrors.Controls.Add(this.textBoxErrorDescription);
            this.tabPageErrors.Controls.Add(this.splitter3);
            this.tabPageErrors.Controls.Add(this.listViewErrors);
            this.tabPageErrors.ImageIndex = 7;
            this.tabPageErrors.Location = new System.Drawing.Point(4, 29);
            this.tabPageErrors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageErrors.Name = "tabPageErrors";
            this.tabPageErrors.Size = new System.Drawing.Size(1012, 316);
            this.tabPageErrors.TabIndex = 4;
            this.tabPageErrors.Text = "Errors";
            this.tabPageErrors.ToolTipText = "View reported errors";
            // 
            // textBoxErrorDescription
            // 
            this.textBoxErrorDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxErrorDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxErrorDescription.Location = new System.Drawing.Point(0, 237);
            this.textBoxErrorDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxErrorDescription.Multiline = true;
            this.textBoxErrorDescription.Name = "textBoxErrorDescription";
            this.textBoxErrorDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxErrorDescription.Size = new System.Drawing.Size(1012, 79);
            this.textBoxErrorDescription.TabIndex = 2;
            this.textBoxErrorDescription.WordWrap = false;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 232);
            this.splitter3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1012, 5);
            this.splitter3.TabIndex = 1;
            this.splitter3.TabStop = false;
            // 
            // listViewErrors
            // 
            this.listViewErrors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderErrorID,
            this.columnHeaderDate,
            this.columnHeaderErrorItem,
            this.columnHeaderErrorDescription});
            this.listViewErrors.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewErrors.FullRowSelect = true;
            this.listViewErrors.GridLines = true;
            this.listViewErrors.HideSelection = false;
            this.listViewErrors.Location = new System.Drawing.Point(0, 0);
            this.listViewErrors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewErrors.MultiSelect = false;
            this.listViewErrors.Name = "listViewErrors";
            this.listViewErrors.Size = new System.Drawing.Size(1012, 232);
            this.listViewErrors.TabIndex = 0;
            this.listViewErrors.UseCompatibleStateImageBehavior = false;
            this.listViewErrors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderErrorID
            // 
            this.columnHeaderErrorID.Text = "ID";
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 160;
            // 
            // columnHeaderErrorItem
            // 
            this.columnHeaderErrorItem.Text = "Error";
            this.columnHeaderErrorItem.Width = 343;
            // 
            // columnHeaderErrorDescription
            // 
            this.columnHeaderErrorDescription.Text = "Description";
            this.columnHeaderErrorDescription.Width = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 482);
            this.Controls.Add(this.tabControlRightView);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolBarMain);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.comboBoxWeb);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Menu = this.mainMenu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelURLs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelByteCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelMem)).EndInit();
            this.tabControlRightView.ResumeLayout(false);
            this.tabPageThreads.ResumeLayout(false);
            this.tabPageRequests.ResumeLayout(false);
            this.tabPageRequests.PerformLayout();
            this.tabPageErrors.ResumeLayout(false);
            this.tabPageErrors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timerMem;
        private System.Windows.Forms.ImageList imageListPercentage;
        private System.Windows.Forms.Timer timerConnectInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.MenuItem menuItemOptions;
        private System.Windows.Forms.MenuItem menuItemFileMatches;
        private System.Windows.Forms.MenuItem menuItemConnections;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.ComboBox comboBoxWeb;
        private System.Windows.Forms.MenuItem menuItemState;
        private System.Windows.Forms.MenuItem menuItemPlay;
        private System.Windows.Forms.MenuItem menuItemPause;
        private System.Windows.Forms.MenuItem menuItemStop;
        private System.Windows.Forms.ToolBar toolBarMain;
        private System.Windows.Forms.ToolBarButton toolBarButtonContinue;
        private System.Windows.Forms.ToolBarButton toolBarButtonPause;
        private System.Windows.Forms.ToolBarButton toolBarButtonStop;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.StatusBarPanel statusBarPanelInfo;
        private System.Windows.Forms.StatusBarPanel statusBarPanelURLs;
        private System.Windows.Forms.StatusBarPanel statusBarPanelFiles;
        private System.Windows.Forms.StatusBarPanel statusBarPanelByteCount;
        private System.Windows.Forms.StatusBarPanel statusBarPanelErrors;
        private System.Windows.Forms.StatusBarPanel statusBarPanelCPU;
        private System.Windows.Forms.StatusBarPanel statusBarPanelMem;
        private System.Windows.Forms.TabControl tabControlRightView;
        private System.Windows.Forms.TabPage tabPageThreads;
        private System.Windows.Forms.ListView listViewThreads;
        private System.Windows.Forms.ColumnHeader columnHeaderTHreadID;
        private System.Windows.Forms.ColumnHeader columnHeaderThreadDepth;
        private System.Windows.Forms.ColumnHeader columnHeaderThreadAction;
        private System.Windows.Forms.ColumnHeader columnHeaderThreadURL;
        private System.Windows.Forms.ColumnHeader columnHeaderThreadBytes;
        private System.Windows.Forms.ColumnHeader columnHeaderThreadPersentage;
        private System.Windows.Forms.TabPage tabPageRequests;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView listViewRequests;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabPageErrors;
        private System.Windows.Forms.TextBox textBoxErrorDescription;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.ListView listViewErrors;
        private System.Windows.Forms.ColumnHeader columnHeaderErrorID;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderErrorItem;
        private System.Windows.Forms.ColumnHeader columnHeaderErrorDescription;

    }
}

