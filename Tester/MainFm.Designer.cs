namespace Tester
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OKButt = new System.Windows.Forms.Button();
            this.CancelButt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PathButt = new System.Windows.Forms.Button();
            this.PathTestBox = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.OKButt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CancelButt, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 226);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OKButt
            // 
            this.OKButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OKButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OKButt.Image = global::Tester.Properties.Resources.agt_login;
            this.OKButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKButt.Location = new System.Drawing.Point(3, 3);
            this.OKButt.Name = "OKButt";
            this.OKButt.Size = new System.Drawing.Size(342, 39);
            this.OKButt.TabIndex = 0;
            this.OKButt.Text = "Начать";
            this.OKButt.UseVisualStyleBackColor = true;
            this.OKButt.Click += new System.EventHandler(this.OKButt_Click);
            // 
            // CancelButt
            // 
            this.CancelButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButt.Image = global::Tester.Properties.Resources.exit;
            this.CancelButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButt.Location = new System.Drawing.Point(351, 3);
            this.CancelButt.Name = "CancelButt";
            this.CancelButt.Size = new System.Drawing.Size(343, 39);
            this.CancelButt.TabIndex = 1;
            this.CancelButt.Text = "Выход";
            this.CancelButt.UseVisualStyleBackColor = true;
            this.CancelButt.Click += new System.EventHandler(this.CancelButt_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(697, 226);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(691, 140);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FNameBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Имя";
            // 
            // FNameBox
            // 
            this.FNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FNameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FNameBox.Location = new System.Drawing.Point(3, 22);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.PlaceholderText = "Введите имя";
            this.FNameBox.Size = new System.Drawing.Size(679, 26);
            this.FNameBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LNameBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(3, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фамилия";
            // 
            // LNameBox
            // 
            this.LNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LNameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LNameBox.Location = new System.Drawing.Point(3, 22);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.PlaceholderText = "Введите фамилию";
            this.LNameBox.Size = new System.Drawing.Size(679, 26);
            this.LNameBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PathButt);
            this.groupBox3.Controls.Add(this.PathTestBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(3, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(691, 74);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Месторасположение теста";
            // 
            // PathButt
            // 
            this.PathButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PathButt.Image = global::Tester.Properties.Resources.folder_sent_mail;
            this.PathButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PathButt.Location = new System.Drawing.Point(497, 25);
            this.PathButt.Name = "PathButt";
            this.PathButt.Size = new System.Drawing.Size(188, 39);
            this.PathButt.TabIndex = 1;
            this.PathButt.Text = "Обзор...";
            this.PathButt.UseVisualStyleBackColor = true;
            this.PathButt.Click += new System.EventHandler(this.PathButt_Click);
            // 
            // PathTestBox
            // 
            this.PathTestBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTestBox.Location = new System.Drawing.Point(6, 25);
            this.PathTestBox.Name = "PathTestBox";
            this.PathTestBox.PlaceholderText = "Выберите месторасположение теста";
            this.PathTestBox.Size = new System.Drawing.Size(485, 26);
            this.PathTestBox.TabIndex = 0;
            // 
            // MainFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 271);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button OKButt;
        private Button CancelButt;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox FNameBox;
        private TextBox LNameBox;
        private TextBox PathTestBox;
        private Button PathButt;
    }
}