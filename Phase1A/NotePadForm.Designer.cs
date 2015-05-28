namespace ManagersNotepadAppication
{
    partial class NotePadForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePadForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAddMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDeleteCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDeleteMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.hierarchicalTree = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textEditor = new System.Windows.Forms.RichTextBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.sizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fontScriptComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.underlineButton = new System.Windows.Forms.ToolStripButton();
            this.alignLeftButton = new System.Windows.Forms.ToolStripButton();
            this.alignCenterButton = new System.Windows.Forms.ToolStripButton();
            this.alignRightButton = new System.Windows.Forms.ToolStripButton();
            this.colorDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.blackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maroonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oliveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tealMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuchshiaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aquaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulletsButton = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddCategory,
            this.toolStripAddMessage,
            this.toolStripDeleteCategory,
            this.toolStripDeleteMessage});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 92);
            // 
            // toolStripAddCategory
            // 
            this.toolStripAddCategory.Name = "toolStripAddCategory";
            this.toolStripAddCategory.Size = new System.Drawing.Size(158, 22);
            this.toolStripAddCategory.Text = "Add Category";
            this.toolStripAddCategory.Click += new System.EventHandler(this.toolStripAddCategory_Click);
            // 
            // toolStripAddMessage
            // 
            this.toolStripAddMessage.Name = "toolStripAddMessage";
            this.toolStripAddMessage.Size = new System.Drawing.Size(158, 22);
            this.toolStripAddMessage.Text = "Add Message";
            this.toolStripAddMessage.Click += new System.EventHandler(this.toolStripAddMessage_Click);
            // 
            // toolStripDeleteCategory
            // 
            this.toolStripDeleteCategory.Name = "toolStripDeleteCategory";
            this.toolStripDeleteCategory.Size = new System.Drawing.Size(158, 22);
            this.toolStripDeleteCategory.Text = "Delete Category";
            this.toolStripDeleteCategory.Click += new System.EventHandler(this.toolStripDeleteCategory_Click);
            // 
            // toolStripDeleteMessage
            // 
            this.toolStripDeleteMessage.Name = "toolStripDeleteMessage";
            this.toolStripDeleteMessage.Size = new System.Drawing.Size(158, 22);
            this.toolStripDeleteMessage.Text = "Delete Message";
            this.toolStripDeleteMessage.Click += new System.EventHandler(this.toolStripDeleteMessage_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(781, 400);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(781, 425);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.hierarchicalTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(781, 400);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.TabIndex = 1;
            // 
            // hierarchicalTree
            // 
            this.hierarchicalTree.AllowDrop = true;
            this.hierarchicalTree.ContextMenuStrip = this.contextMenuStrip1;
            this.hierarchicalTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hierarchicalTree.FullRowSelect = true;
            this.hierarchicalTree.HotTracking = true;
            this.hierarchicalTree.LabelEdit = true;
            this.hierarchicalTree.Location = new System.Drawing.Point(0, 0);
            this.hierarchicalTree.Name = "hierarchicalTree";
            treeNode1.ContextMenuStrip = this.contextMenuStrip1;
            treeNode1.Name = "Root";
            treeNode1.Text = "Root";
            this.hierarchicalTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.hierarchicalTree.Size = new System.Drawing.Size(348, 400);
            this.hierarchicalTree.TabIndex = 0;
            this.hierarchicalTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.hierarchicalTree_AfterLabelEdit);
            this.hierarchicalTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.hierarchicalTree_ItemDrag);
            this.hierarchicalTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.hierarchicalTree_AfterSelect);
            this.hierarchicalTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.hierarchicalTree_NodeMouseClick);
            this.hierarchicalTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.hierarchicalTree_NodeMouseDoubleClick);
            this.hierarchicalTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.hierarchicalTree_DragDrop);
            this.hierarchicalTree.DragEnter += new System.Windows.Forms.DragEventHandler(this.hierarchicalTree_DragEnter);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textEditor);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer2.Size = new System.Drawing.Size(429, 400);
            this.splitContainer2.SplitterDistance = 192;
            this.splitContainer2.TabIndex = 0;
            // 
            // textEditor
            // 
            this.textEditor.Cursor = System.Windows.Forms.Cursors.Default;
            this.textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditor.HideSelection = false;
            this.textEditor.Location = new System.Drawing.Point(0, 0);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(429, 192);
            this.textEditor.TabIndex = 0;
            this.textEditor.Text = "";
            this.textEditor.TextChanged += new System.EventHandler(this.textEditor_TextChanged);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(429, 204);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            this.propertyGrid1.Click += new System.EventHandler(this.propertyGrid1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.newToolStripButton,
            this.openToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton,
            this.fontComboBox,
            this.sizeComboBox,
            this.fontScriptComboBox3,
            this.boldButton,
            this.italicButton,
            this.underlineButton,
            this.alignLeftButton,
            this.alignCenterButton,
            this.alignRightButton,
            this.colorDropDownButton1,
            this.bulletsButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(610, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Visible = false;
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Visible = false;
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // fontComboBox
            // 
            this.fontComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fontComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fontComboBox.MaxDropDownItems = 5;
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(100, 25);
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(75, 25);
            this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged);
            // 
            // fontScriptComboBox3
            // 
            this.fontScriptComboBox3.Items.AddRange(new object[] {
            "Arabic",
            "Baltic",
            "Central European",
            "Cyrillic",
            "Greek",
            "Hebrew",
            "Turkish",
            "Vietnamese",
            "Western"});
            this.fontScriptComboBox3.Name = "fontScriptComboBox3";
            this.fontScriptComboBox3.Size = new System.Drawing.Size(100, 25);
            // 
            // boldButton
            // 
            this.boldButton.CheckOnClick = true;
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldButton.Image = global::ManagersNotepadAppication.Properties.Resources.ToolStripBold;
            this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(23, 22);
            this.boldButton.Text = "toolStripButton1";
            this.boldButton.ToolTipText = "Bold";
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.CheckOnClick = true;
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicButton.Image = ((System.Drawing.Image)(resources.GetObject("italicButton.Image")));
            this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(23, 22);
            this.italicButton.Text = "toolStripButton2";
            this.italicButton.ToolTipText = "Italic";
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.CheckOnClick = true;
            this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineButton.Image")));
            this.underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(23, 22);
            this.underlineButton.Text = "toolStripButton3";
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // alignLeftButton
            // 
            this.alignLeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("alignLeftButton.Image")));
            this.alignLeftButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignLeftButton.Name = "alignLeftButton";
            this.alignLeftButton.Size = new System.Drawing.Size(23, 22);
            this.alignLeftButton.Text = "alignLeftButton";
            this.alignLeftButton.Click += new System.EventHandler(this.alignLeftButton_Click);
            // 
            // alignCenterButton
            // 
            this.alignCenterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignCenterButton.Image = ((System.Drawing.Image)(resources.GetObject("alignCenterButton.Image")));
            this.alignCenterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignCenterButton.Name = "alignCenterButton";
            this.alignCenterButton.Size = new System.Drawing.Size(23, 22);
            this.alignCenterButton.Text = "Align Center";
            this.alignCenterButton.ToolTipText = "Align Center";
            this.alignCenterButton.Click += new System.EventHandler(this.alignCenterButton_Click);
            // 
            // alignRightButton
            // 
            this.alignRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignRightButton.Image = ((System.Drawing.Image)(resources.GetObject("alignRightButton.Image")));
            this.alignRightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignRightButton.Name = "alignRightButton";
            this.alignRightButton.Size = new System.Drawing.Size(23, 22);
            this.alignRightButton.Text = "Align Right";
            this.alignRightButton.Click += new System.EventHandler(this.alignRightButton_Click);
            // 
            // colorDropDownButton1
            // 
            this.colorDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackMenuItem,
            this.maroonMenuItem,
            this.greenMenuItem,
            this.oliveMenuItem,
            this.navyMenuItem,
            this.purpleMenuItem,
            this.tealMenuItem,
            this.grayToolStripMenuItem,
            this.redMenuItem,
            this.limeMenuItem,
            this.yellowMenuItem,
            this.blueMenuItem,
            this.fuchshiaMenuItem,
            this.aquaMenuItem,
            this.whiteMenuItem});
            this.colorDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("colorDropDownButton1.Image")));
            this.colorDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorDropDownButton1.Name = "colorDropDownButton1";
            this.colorDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.colorDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // blackMenuItem
            // 
            this.blackMenuItem.Image = global::ManagersNotepadAppication.Properties.Resources.ToolStripBold;
            this.blackMenuItem.Name = "blackMenuItem";
            this.blackMenuItem.Size = new System.Drawing.Size(121, 22);
            this.blackMenuItem.Text = "Black";
            this.blackMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // maroonMenuItem
            // 
            this.maroonMenuItem.Name = "maroonMenuItem";
            this.maroonMenuItem.Size = new System.Drawing.Size(121, 22);
            this.maroonMenuItem.Text = "Maroon";
            this.maroonMenuItem.Click += new System.EventHandler(this.maroonMenuItem_Click);
            // 
            // greenMenuItem
            // 
            this.greenMenuItem.Name = "greenMenuItem";
            this.greenMenuItem.Size = new System.Drawing.Size(121, 22);
            this.greenMenuItem.Text = "Green";
            this.greenMenuItem.Click += new System.EventHandler(this.greenMenuItem_Click);
            // 
            // oliveMenuItem
            // 
            this.oliveMenuItem.Name = "oliveMenuItem";
            this.oliveMenuItem.Size = new System.Drawing.Size(121, 22);
            this.oliveMenuItem.Text = "Olive";
            this.oliveMenuItem.Click += new System.EventHandler(this.oliveMenuItem_Click);
            // 
            // navyMenuItem
            // 
            this.navyMenuItem.Name = "navyMenuItem";
            this.navyMenuItem.Size = new System.Drawing.Size(121, 22);
            this.navyMenuItem.Text = "Navy";
            this.navyMenuItem.Click += new System.EventHandler(this.navyMenuItem_Click);
            // 
            // purpleMenuItem
            // 
            this.purpleMenuItem.Name = "purpleMenuItem";
            this.purpleMenuItem.Size = new System.Drawing.Size(121, 22);
            this.purpleMenuItem.Text = "Purple";
            this.purpleMenuItem.Click += new System.EventHandler(this.purpleMenuItem_Click);
            // 
            // tealMenuItem
            // 
            this.tealMenuItem.Name = "tealMenuItem";
            this.tealMenuItem.Size = new System.Drawing.Size(121, 22);
            this.tealMenuItem.Text = "Teal";
            this.tealMenuItem.Click += new System.EventHandler(this.tealMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // redMenuItem
            // 
            this.redMenuItem.Name = "redMenuItem";
            this.redMenuItem.Size = new System.Drawing.Size(121, 22);
            this.redMenuItem.Text = "Red";
            this.redMenuItem.Click += new System.EventHandler(this.redMenuItem_Click);
            // 
            // limeMenuItem
            // 
            this.limeMenuItem.Name = "limeMenuItem";
            this.limeMenuItem.Size = new System.Drawing.Size(121, 22);
            this.limeMenuItem.Text = "Lime ";
            this.limeMenuItem.Click += new System.EventHandler(this.limeMenuItem_Click);
            // 
            // yellowMenuItem
            // 
            this.yellowMenuItem.Name = "yellowMenuItem";
            this.yellowMenuItem.Size = new System.Drawing.Size(121, 22);
            this.yellowMenuItem.Text = "Yellow";
            this.yellowMenuItem.Click += new System.EventHandler(this.yellowMenuItem_Click);
            // 
            // blueMenuItem
            // 
            this.blueMenuItem.Name = "blueMenuItem";
            this.blueMenuItem.Size = new System.Drawing.Size(121, 22);
            this.blueMenuItem.Text = "Blue ";
            this.blueMenuItem.Click += new System.EventHandler(this.blueMenuItem_Click);
            // 
            // fuchshiaMenuItem
            // 
            this.fuchshiaMenuItem.Name = "fuchshiaMenuItem";
            this.fuchshiaMenuItem.Size = new System.Drawing.Size(121, 22);
            this.fuchshiaMenuItem.Text = "Fuchshia";
            this.fuchshiaMenuItem.Click += new System.EventHandler(this.fuchshiaMenuItem_Click);
            // 
            // aquaMenuItem
            // 
            this.aquaMenuItem.Name = "aquaMenuItem";
            this.aquaMenuItem.Size = new System.Drawing.Size(121, 22);
            this.aquaMenuItem.Text = "Aqua";
            this.aquaMenuItem.Click += new System.EventHandler(this.aquaMenuItem_Click);
            // 
            // whiteMenuItem
            // 
            this.whiteMenuItem.Name = "whiteMenuItem";
            this.whiteMenuItem.Size = new System.Drawing.Size(121, 22);
            this.whiteMenuItem.Text = "White";
            this.whiteMenuItem.Click += new System.EventHandler(this.whiteMenuItem_Click);
            // 
            // bulletsButton
            // 
            this.bulletsButton.Checked = true;
            this.bulletsButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bulletsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bulletsButton.Image = ((System.Drawing.Image)(resources.GetObject("bulletsButton.Image")));
            this.bulletsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bulletsButton.Name = "bulletsButton";
            this.bulletsButton.Size = new System.Drawing.Size(23, 22);
            this.bulletsButton.Text = "Bullets";
            this.bulletsButton.Click += new System.EventHandler(this.bulletsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 425);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Manager\'s Notepad Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddCategory;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddMessage;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeleteCategory;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeleteMessage;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView hierarchicalTree;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox textEditor;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripComboBox sizeComboBox;
        private System.Windows.Forms.ToolStripComboBox fontScriptComboBox3;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton underlineButton;
        private System.Windows.Forms.ToolStripButton alignLeftButton;
        private System.Windows.Forms.ToolStripButton alignCenterButton;
        private System.Windows.Forms.ToolStripButton alignRightButton;
        private System.Windows.Forms.ToolStripComboBox fontComboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripDropDownButton colorDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem blackMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maroonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oliveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tealMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuchshiaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aquaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteMenuItem;
        private System.Windows.Forms.ToolStripButton bulletsButton;
       
    }
}

