namespace TestCreator
{
    partial class TestFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestFm));
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.CountTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.GuidTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.TestMenu = new System.Windows.Forms.MenuStrip();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewAskMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditAskMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveAskMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.imList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AskTree = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AnswerList = new System.Windows.Forms.ListView();
            this.colname = new System.Windows.Forms.ColumnHeader();
            this.colstate = new System.Windows.Forms.ColumnHeader();
            this.StatusBar.SuspendLayout();
            this.TestMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountTool,
            this.GuidTool});
            this.StatusBar.Location = new System.Drawing.Point(0, 278);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1117, 28);
            this.StatusBar.TabIndex = 0;
            // 
            // CountTool
            // 
            this.CountTool.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.CountTool.Name = "CountTool";
            this.CountTool.Size = new System.Drawing.Size(201, 23);
            this.CountTool.Text = "Количество вопросов - <0>";
            // 
            // GuidTool
            // 
            this.GuidTool.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.GuidTool.Name = "GuidTool";
            this.GuidTool.Size = new System.Drawing.Size(901, 23);
            this.GuidTool.Spring = true;
            this.GuidTool.Text = "Нет выбранных вопросов";
            this.GuidTool.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TestMenu
            // 
            this.TestMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TestMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditMenu,
            this.DopMenu});
            this.TestMenu.Location = new System.Drawing.Point(0, 0);
            this.TestMenu.Name = "TestMenu";
            this.TestMenu.Size = new System.Drawing.Size(1117, 27);
            this.TestMenu.TabIndex = 1;
            this.TestMenu.Text = "menuStrip1";
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewAskMenu,
            this.EditAskMenu,
            this.toolStripSeparator1,
            this.RemoveAskMenu,
            this.RemoveAllMenu});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(69, 23);
            this.EditMenu.Text = "&Правка";
            // 
            // NewAskMenu
            // 
            this.NewAskMenu.Image = global::TestCreator.Properties.Resources.xedit;
            this.NewAskMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewAskMenu.Name = "NewAskMenu";
            this.NewAskMenu.Size = new System.Drawing.Size(229, 24);
            this.NewAskMenu.Text = "Новый вопрос";
            this.NewAskMenu.Click += new System.EventHandler(this.NewAskMenu_Click);
            // 
            // EditAskMenu
            // 
            this.EditAskMenu.Image = global::TestCreator.Properties.Resources.kedit;
            this.EditAskMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditAskMenu.Name = "EditAskMenu";
            this.EditAskMenu.Size = new System.Drawing.Size(229, 24);
            this.EditAskMenu.Text = "Редактировать вопрос";
            this.EditAskMenu.Click += new System.EventHandler(this.EditAskMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // RemoveAskMenu
            // 
            this.RemoveAskMenu.Image = global::TestCreator.Properties.Resources.editdelete;
            this.RemoveAskMenu.Name = "RemoveAskMenu";
            this.RemoveAskMenu.Size = new System.Drawing.Size(229, 24);
            this.RemoveAskMenu.Text = "Удалить вопрос";
            this.RemoveAskMenu.Click += new System.EventHandler(this.RemoveAskMenu_Click);
            // 
            // RemoveAllMenu
            // 
            this.RemoveAllMenu.Image = global::TestCreator.Properties.Resources.cnrdelete_all1;
            this.RemoveAllMenu.Name = "RemoveAllMenu";
            this.RemoveAllMenu.Size = new System.Drawing.Size(229, 24);
            this.RemoveAllMenu.Text = "Удалить все вопросы";
            this.RemoveAllMenu.Click += new System.EventHandler(this.RemoveAllMenu_Click);
            // 
            // DopMenu
            // 
            this.DopMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PropertyMenu,
            this.toolStripSeparator3});
            this.DopMenu.Name = "DopMenu";
            this.DopMenu.Size = new System.Drawing.Size(129, 23);
            this.DopMenu.Text = "&Дополнительно";
            // 
            // PropertyMenu
            // 
            this.PropertyMenu.Image = global::TestCreator.Properties.Resources.exec;
            this.PropertyMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PropertyMenu.Name = "PropertyMenu";
            this.PropertyMenu.Size = new System.Drawing.Size(182, 24);
            this.PropertyMenu.Text = "Свойства теста";
            this.PropertyMenu.Click += new System.EventHandler(this.PropertyMenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // imList
            // 
            this.imList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imList.ImageStream")));
            this.imList.TransparentColor = System.Drawing.Color.Transparent;
            this.imList.Images.SetKeyName(0, "clean.png");
            this.imList.Images.SetKeyName(1, "xapp.png");
            this.imList.Images.SetKeyName(2, "help_index.png");
            this.imList.Images.SetKeyName(3, "kcmdf.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1117, 251);
            this.splitContainer1.SplitterDistance = 424;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AskTree);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список вопросов";
            // 
            // AskTree
            // 
            this.AskTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AskTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AskTree.FullRowSelect = true;
            this.AskTree.ImageKey = "help_index.png";
            this.AskTree.ImageList = this.imList;
            this.AskTree.Location = new System.Drawing.Point(3, 22);
            this.AskTree.Name = "AskTree";
            this.AskTree.SelectedImageKey = "kcmdf.png";
            this.AskTree.ShowLines = false;
            this.AskTree.ShowPlusMinus = false;
            this.AskTree.ShowRootLines = false;
            this.AskTree.Size = new System.Drawing.Size(418, 226);
            this.AskTree.TabIndex = 0;
            this.AskTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AskTree_AfterSelect);
            this.AskTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.AskTree_NodeMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AnswerList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 251);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Варианты ответов";
            // 
            // AnswerList
            // 
            this.AnswerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colname,
            this.colstate});
            this.AnswerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswerList.FullRowSelect = true;
            this.AnswerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AnswerList.Location = new System.Drawing.Point(3, 22);
            this.AnswerList.MultiSelect = false;
            this.AnswerList.Name = "AnswerList";
            this.AnswerList.Size = new System.Drawing.Size(682, 226);
            this.AnswerList.SmallImageList = this.imList;
            this.AnswerList.TabIndex = 0;
            this.AnswerList.UseCompatibleStateImageBehavior = false;
            this.AnswerList.View = System.Windows.Forms.View.Details;
            // 
            // colname
            // 
            this.colname.Text = "Вариант ответа";
            this.colname.Width = 350;
            // 
            // colstate
            // 
            this.colstate.Text = "Да\\Нет";
            this.colstate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TestFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 306);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.TestMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TestMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestFm";
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.TestMenu.ResumeLayout(false);
            this.TestMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip StatusBar;
        private MenuStrip TestMenu;
        private ImageList imList;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStripStatusLabel CountTool;
        private ToolStripStatusLabel GuidTool;
        private TreeView AskTree;
        private ListView AnswerList;
        private ColumnHeader colname;
        private ColumnHeader colstate;
        private ToolStripMenuItem EditMenu;
        private ToolStripMenuItem NewAskMenu;
        private ToolStripMenuItem EditAskMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem RemoveAskMenu;
        private ToolStripMenuItem RemoveAllMenu;
        private ToolStripMenuItem DopMenu;
        private ToolStripMenuItem PropertyMenu;
        private ToolStripSeparator toolStripSeparator3;
    }
}