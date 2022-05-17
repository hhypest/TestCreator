namespace TestCreator
{
    partial class NewTestFm
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
            this.OKButt = new System.Windows.Forms.Button();
            this.CancelButt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MultiRadio = new System.Windows.Forms.RadioButton();
            this.OneRadio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.OKButt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CancelButt, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 133);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OKButt
            // 
            this.OKButt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OKButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKButt.Image = global::TestCreator.Properties.Resources.ok;
            this.OKButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKButt.Location = new System.Drawing.Point(3, 3);
            this.OKButt.Name = "OKButt";
            this.OKButt.Size = new System.Drawing.Size(211, 39);
            this.OKButt.TabIndex = 0;
            this.OKButt.Text = "ОК";
            this.OKButt.UseVisualStyleBackColor = true;
            this.OKButt.Click += new System.EventHandler(this.OKButt_Click);
            // 
            // CancelButt
            // 
            this.CancelButt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButt.Image = global::TestCreator.Properties.Resources.no;
            this.CancelButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButt.Location = new System.Drawing.Point(220, 3);
            this.CancelButt.Name = "CancelButt";
            this.CancelButt.Size = new System.Drawing.Size(211, 39);
            this.CancelButt.TabIndex = 1;
            this.CancelButt.Text = "Отмена";
            this.CancelButt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(434, 133);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Название нового теста";
            // 
            // NameBox
            // 
            this.NameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameBox.Location = new System.Drawing.Point(3, 22);
            this.NameBox.Name = "NameBox";
            this.NameBox.PlaceholderText = "Введите название теста";
            this.NameBox.Size = new System.Drawing.Size(422, 26);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MultiRadio);
            this.groupBox2.Controls.Add(this.OneRadio);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(3, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Допускается ли несколько верных вариантов ответа в тесте";
            // 
            // MultiRadio
            // 
            this.MultiRadio.AutoSize = true;
            this.MultiRadio.Checked = true;
            this.MultiRadio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MultiRadio.Location = new System.Drawing.Point(9, 25);
            this.MultiRadio.Name = "MultiRadio";
            this.MultiRadio.Size = new System.Drawing.Size(44, 23);
            this.MultiRadio.TabIndex = 1;
            this.MultiRadio.TabStop = true;
            this.MultiRadio.Tag = "0";
            this.MultiRadio.Text = "Да";
            this.MultiRadio.UseVisualStyleBackColor = true;
            this.MultiRadio.CheckedChanged += new System.EventHandler(this.MultiRadio_CheckedChanged);
            // 
            // OneRadio
            // 
            this.OneRadio.AutoSize = true;
            this.OneRadio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OneRadio.Location = new System.Drawing.Point(371, 25);
            this.OneRadio.Name = "OneRadio";
            this.OneRadio.Size = new System.Drawing.Size(51, 23);
            this.OneRadio.TabIndex = 0;
            this.OneRadio.Tag = "1";
            this.OneRadio.Text = "Нет";
            this.OneRadio.UseVisualStyleBackColor = true;
            this.OneRadio.CheckedChanged += new System.EventHandler(this.OneRadio_CheckedChanged);
            // 
            // NewTestFm
            // 
            this.AcceptButton = this.OKButt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButt;
            this.ClientSize = new System.Drawing.Size(434, 178);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewTestFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ввод данных";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button OKButt;
        private Button CancelButt;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox NameBox;
        private RadioButton MultiRadio;
        private RadioButton OneRadio;
    }
}