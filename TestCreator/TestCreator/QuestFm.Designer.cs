namespace TestCreator
{
    partial class QuestFm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OkButt = new System.Windows.Forms.Button();
            this.CancelButt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AskBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveAllButt = new System.Windows.Forms.Button();
            this.RemoveButt = new System.Windows.Forms.Button();
            this.AddButt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.VariantList = new System.Windows.Forms.ListView();
            this.colVariant = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.OkButt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CancelButt, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 245);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OkButt
            // 
            this.OkButt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OkButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OkButt.Image = global::TestCreator.Properties.Resources.ok;
            this.OkButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkButt.Location = new System.Drawing.Point(3, 3);
            this.OkButt.Name = "OkButt";
            this.OkButt.Size = new System.Drawing.Size(535, 39);
            this.OkButt.TabIndex = 0;
            this.OkButt.Text = "OK";
            this.OkButt.UseVisualStyleBackColor = true;
            this.OkButt.Click += new System.EventHandler(this.OkButt_Click);
            // 
            // CancelButt
            // 
            this.CancelButt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButt.Image = global::TestCreator.Properties.Resources.no;
            this.CancelButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButt.Location = new System.Drawing.Point(544, 3);
            this.CancelButt.Name = "CancelButt";
            this.CancelButt.Size = new System.Drawing.Size(535, 39);
            this.CancelButt.TabIndex = 1;
            this.CancelButt.Text = "Отмена";
            this.CancelButt.UseVisualStyleBackColor = true;
            this.CancelButt.Click += new System.EventHandler(this.CancelButt_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1082, 245);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(535, 239);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AskBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите вопрос";
            // 
            // AskBox
            // 
            this.AskBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AskBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AskBox.Location = new System.Drawing.Point(3, 22);
            this.AskBox.Name = "AskBox";
            this.AskBox.PlaceholderText = "Введите вопрос [не более 32 000 символов]";
            this.AskBox.Size = new System.Drawing.Size(523, 26);
            this.AskBox.TabIndex = 0;
            this.AskBox.TextChanged += new System.EventHandler(this.AskBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoveAllButt);
            this.groupBox2.Controls.Add(this.RemoveButt);
            this.groupBox2.Controls.Add(this.AddButt);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(3, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // RemoveAllButt
            // 
            this.RemoveAllButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveAllButt.Image = global::TestCreator.Properties.Resources.cnrdelete_all1;
            this.RemoveAllButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveAllButt.Location = new System.Drawing.Point(6, 115);
            this.RemoveAllButt.Name = "RemoveAllButt";
            this.RemoveAllButt.Size = new System.Drawing.Size(517, 39);
            this.RemoveAllButt.TabIndex = 2;
            this.RemoveAllButt.Text = "Очистить всё";
            this.RemoveAllButt.UseVisualStyleBackColor = true;
            this.RemoveAllButt.Click += new System.EventHandler(this.RemoveAllButt_Click);
            // 
            // RemoveButt
            // 
            this.RemoveButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveButt.Image = global::TestCreator.Properties.Resources.editdelete;
            this.RemoveButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveButt.Location = new System.Drawing.Point(6, 70);
            this.RemoveButt.Name = "RemoveButt";
            this.RemoveButt.Size = new System.Drawing.Size(517, 39);
            this.RemoveButt.TabIndex = 1;
            this.RemoveButt.Text = "Удалить вариант";
            this.RemoveButt.UseVisualStyleBackColor = true;
            this.RemoveButt.Click += new System.EventHandler(this.RemoveButt_Click);
            // 
            // AddButt
            // 
            this.AddButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButt.Image = global::TestCreator.Properties.Resources.kedit;
            this.AddButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButt.Location = new System.Drawing.Point(6, 25);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(517, 39);
            this.AddButt.TabIndex = 0;
            this.AddButt.Text = "Добавить вариант";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VariantList);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(544, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(535, 239);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Варианты ответов";
            // 
            // VariantList
            // 
            this.VariantList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VariantList.CheckBoxes = true;
            this.VariantList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colVariant});
            this.VariantList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariantList.FullRowSelect = true;
            this.VariantList.GridLines = true;
            this.VariantList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.VariantList.LabelEdit = true;
            this.VariantList.Location = new System.Drawing.Point(3, 22);
            this.VariantList.Name = "VariantList";
            this.VariantList.Size = new System.Drawing.Size(529, 214);
            this.VariantList.TabIndex = 0;
            this.VariantList.UseCompatibleStateImageBehavior = false;
            this.VariantList.View = System.Windows.Forms.View.Details;
            this.VariantList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.VariantList_ItemChecked);
            // 
            // colVariant
            // 
            this.colVariant.Text = "";
            this.colVariant.Width = 525;
            // 
            // QuestFm
            // 
            this.AcceptButton = this.OkButt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButt;
            this.ClientSize = new System.Drawing.Size(1082, 290);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuestFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button OkButt;
        private Button CancelButt;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox AskBox;
        private Button RemoveAllButt;
        private Button RemoveButt;
        private Button AddButt;
        private ListView VariantList;
        private ColumnHeader colVariant;
    }
}