namespace TestCreator
{
    partial class MainFm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewTestMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTestMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsTestMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTestMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusBar = new System.Windows.Forms.StatusStrip();
            this.NameTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.PathTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu.SuspendLayout();
            this.MainStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.MdiWindowListItem = this.FileMenu;
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1008, 27);
            this.MainMenu.TabIndex = 1;
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTestMenu,
            this.OpenTestMenu,
            this.toolStripSeparator1,
            this.SaveMenu,
            this.toolStripSeparator2,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(58, 23);
            this.FileMenu.Text = "&Файл";
            // 
            // NewTestMenu
            // 
            this.NewTestMenu.Image = global::TestCreator.Properties.Resources.new_window;
            this.NewTestMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewTestMenu.Name = "NewTestMenu";
            this.NewTestMenu.Size = new System.Drawing.Size(169, 24);
            this.NewTestMenu.Text = "Новый тест";
            this.NewTestMenu.Click += new System.EventHandler(this.NewTestMenu_Click);
            // 
            // OpenTestMenu
            // 
            this.OpenTestMenu.Image = global::TestCreator.Properties.Resources.fileopen;
            this.OpenTestMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenTestMenu.Name = "OpenTestMenu";
            this.OpenTestMenu.Size = new System.Drawing.Size(169, 24);
            this.OpenTestMenu.Text = "Открыть тест";
            this.OpenTestMenu.Click += new System.EventHandler(this.OpenTestMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // SaveMenu
            // 
            this.SaveMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsTestMenu,
            this.SaveTestMenu});
            this.SaveMenu.Enabled = false;
            this.SaveMenu.Image = global::TestCreator.Properties.Resources.save_all;
            this.SaveMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.Size = new System.Drawing.Size(169, 24);
            this.SaveMenu.Text = "Сохранить...";
            // 
            // SaveAsTestMenu
            // 
            this.SaveAsTestMenu.Image = global::TestCreator.Properties.Resources.save_all;
            this.SaveAsTestMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveAsTestMenu.Name = "SaveAsTestMenu";
            this.SaveAsTestMenu.Size = new System.Drawing.Size(188, 24);
            this.SaveAsTestMenu.Text = "Сохранить как...";
            this.SaveAsTestMenu.Click += new System.EventHandler(this.SaveAsTestMenu_Click);
            // 
            // SaveTestMenu
            // 
            this.SaveTestMenu.Enabled = false;
            this.SaveTestMenu.Image = global::TestCreator.Properties.Resources.save_all;
            this.SaveTestMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveTestMenu.Name = "SaveTestMenu";
            this.SaveTestMenu.Size = new System.Drawing.Size(188, 24);
            this.SaveTestMenu.Text = "Сохранить";
            this.SaveTestMenu.Click += new System.EventHandler(this.SaveTestMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Image = global::TestCreator.Properties.Resources.exit;
            this.ExitMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(169, 24);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameTool,
            this.PathTool});
            this.MainStatusBar.Location = new System.Drawing.Point(0, 454);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Size = new System.Drawing.Size(1008, 28);
            this.MainStatusBar.TabIndex = 3;
            this.MainStatusBar.Text = "statusStrip1";
            // 
            // NameTool
            // 
            this.NameTool.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.NameTool.Name = "NameTool";
            this.NameTool.Size = new System.Drawing.Size(158, 23);
            this.NameTool.Text = "Открытых тестов нет";
            // 
            // PathTool
            // 
            this.PathTool.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.PathTool.Name = "PathTool";
            this.PathTool.Size = new System.Drawing.Size(835, 23);
            this.PathTool.Spring = true;
            this.PathTool.Text = "Открытых тестов нет";
            this.PathTool.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 482);
            this.Controls.Add(this.MainStatusBar);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание тестов";
            this.MdiChildActivate += new System.EventHandler(this.MainFm_MdiChildActivate);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainStatusBar.ResumeLayout(false);
            this.MainStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem NewTestMenu;
        private ToolStripMenuItem OpenTestMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem SaveMenu;
        private ToolStripMenuItem SaveAsTestMenu;
        private ToolStripMenuItem SaveTestMenu;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ExitMenu;
        private StatusStrip MainStatusBar;
        private ToolStripStatusLabel NameTool;
        private ToolStripStatusLabel PathTool;
    }
}