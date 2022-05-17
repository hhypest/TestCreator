namespace Tester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestFm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AskLabel = new System.Windows.Forms.Label();
            this.NextButt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.NameTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.QuestList = new System.Windows.Forms.ListView();
            this.colVariant = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 512);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AskLabel);
            this.groupBox1.Controls.Add(this.NextButt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вопрос";
            // 
            // AskLabel
            // 
            this.AskLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AskLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AskLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AskLabel.Location = new System.Drawing.Point(3, 22);
            this.AskLabel.Name = "AskLabel";
            this.AskLabel.Size = new System.Drawing.Size(1066, 186);
            this.AskLabel.TabIndex = 1;
            // 
            // NextButt
            // 
            this.NextButt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NextButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextButt.Image = global::Tester.Properties.Resources._2rightarrow;
            this.NextButt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NextButt.Location = new System.Drawing.Point(3, 208);
            this.NextButt.Name = "NextButt";
            this.NextButt.Size = new System.Drawing.Size(1066, 39);
            this.NextButt.TabIndex = 0;
            this.NextButt.Text = "Следующий вопрос";
            this.NextButt.UseVisualStyleBackColor = true;
            this.NextButt.Click += new System.EventHandler(this.NextButt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StatusBar);
            this.groupBox2.Controls.Add(this.QuestList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(3, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1072, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Варианты ответов";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameTool,
            this.CountTool});
            this.StatusBar.Location = new System.Drawing.Point(3, 225);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1066, 22);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            // 
            // NameTool
            // 
            this.NameTool.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.NameTool.Name = "NameTool";
            this.NameTool.Size = new System.Drawing.Size(4, 17);
            // 
            // CountTool
            // 
            this.CountTool.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.CountTool.Name = "CountTool";
            this.CountTool.Size = new System.Drawing.Size(1047, 17);
            this.CountTool.Spring = true;
            this.CountTool.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QuestList
            // 
            this.QuestList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestList.CheckBoxes = true;
            this.QuestList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colVariant});
            this.QuestList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestList.FullRowSelect = true;
            this.QuestList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.QuestList.Location = new System.Drawing.Point(3, 22);
            this.QuestList.Name = "QuestList";
            this.QuestList.Size = new System.Drawing.Size(1066, 225);
            this.QuestList.TabIndex = 0;
            this.QuestList.UseCompatibleStateImageBehavior = false;
            this.QuestList.View = System.Windows.Forms.View.List;
            // 
            // colVariant
            // 
            this.colVariant.Text = "";
            this.colVariant.Width = 600;
            // 
            // TestFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button NextButt;
        private Label AskLabel;
        private ListView QuestList;
        private ColumnHeader colVariant;
        private StatusStrip StatusBar;
        private ToolStripStatusLabel NameTool;
        private ToolStripStatusLabel CountTool;
    }
}