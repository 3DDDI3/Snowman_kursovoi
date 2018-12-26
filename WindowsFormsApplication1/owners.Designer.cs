namespace WindowsFormsApplication1
{
    partial class owners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(owners));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выставленнаяНедвижимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.недвижимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОНедвижимостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.владельцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОВладельцахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОКлиентахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОНедвижимостиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.договораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОДогогворахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаСоединенияСБазойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соединениеСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Поиск владельца";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(586, 370);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ф.И.О";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Azure;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 436);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(613, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Azure;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel3.Text = "toolStripLabel3";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.выставленнаяНедвижимостьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 92);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // выставленнаяНедвижимостьToolStripMenuItem
            // 
            this.выставленнаяНедвижимостьToolStripMenuItem.Name = "выставленнаяНедвижимостьToolStripMenuItem";
            this.выставленнаяНедвижимостьToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.выставленнаяНедвижимостьToolStripMenuItem.Text = "Выставленная недвижимость";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.недвижимостьToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.владельцыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.договораToolStripMenuItem,
            this.настройкаСоединенияСБазойToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // недвижимостьToolStripMenuItem
            // 
            this.недвижимостьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОНедвижимостиToolStripMenuItem});
            this.недвижимостьToolStripMenuItem.Name = "недвижимостьToolStripMenuItem";
            this.недвижимостьToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.недвижимостьToolStripMenuItem.Text = "Недвижимость";
            // 
            // информацияОНедвижимостиToolStripMenuItem
            // 
            this.информацияОНедвижимостиToolStripMenuItem.Name = "информацияОНедвижимостиToolStripMenuItem";
            this.информацияОНедвижимостиToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.информацияОНедвижимостиToolStripMenuItem.Text = "Информация о недвижимости";
            this.информацияОНедвижимостиToolStripMenuItem.Click += new System.EventHandler(this.информацияОНедвижимостиToolStripMenuItem_Click);
            // 
            // владельцыToolStripMenuItem
            // 
            this.владельцыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОВладельцахToolStripMenuItem});
            this.владельцыToolStripMenuItem.Name = "владельцыToolStripMenuItem";
            this.владельцыToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.владельцыToolStripMenuItem.Text = "Владельцы";
            // 
            // информацияОВладельцахToolStripMenuItem
            // 
            this.информацияОВладельцахToolStripMenuItem.Name = "информацияОВладельцахToolStripMenuItem";
            this.информацияОВладельцахToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.информацияОВладельцахToolStripMenuItem.Text = "Информация о владельцах";
            this.информацияОВладельцахToolStripMenuItem.Click += new System.EventHandler(this.информацияОВладельцахToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКлиентахToolStripMenuItem});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // информацияОКлиентахToolStripMenuItem
            // 
            this.информацияОКлиентахToolStripMenuItem.Name = "информацияОКлиентахToolStripMenuItem";
            this.информацияОКлиентахToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.информацияОКлиентахToolStripMenuItem.Text = "Информация о клиентах";
            this.информацияОКлиентахToolStripMenuItem.Click += new System.EventHandler(this.информацияОКлиентахToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОНедвижимостиToolStripMenuItem1});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // информацияОНедвижимостиToolStripMenuItem1
            // 
            this.информацияОНедвижимостиToolStripMenuItem1.Name = "информацияОНедвижимостиToolStripMenuItem1";
            this.информацияОНедвижимостиToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.информацияОНедвижимостиToolStripMenuItem1.Text = "Информация о недвижимости";
            this.информацияОНедвижимостиToolStripMenuItem1.Click += new System.EventHandler(this.информацияОНедвижимостиToolStripMenuItem1_Click);
            // 
            // договораToolStripMenuItem
            // 
            this.договораToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОДогогворахToolStripMenuItem});
            this.договораToolStripMenuItem.Name = "договораToolStripMenuItem";
            this.договораToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.договораToolStripMenuItem.Text = "Договоры";
            // 
            // информацияОДогогворахToolStripMenuItem
            // 
            this.информацияОДогогворахToolStripMenuItem.Name = "информацияОДогогворахToolStripMenuItem";
            this.информацияОДогогворахToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.информацияОДогогворахToolStripMenuItem.Text = "Информация о догогворах";
            this.информацияОДогогворахToolStripMenuItem.Click += new System.EventHandler(this.информацияОДогогворахToolStripMenuItem_Click);
            // 
            // настройкаСоединенияСБазойToolStripMenuItem
            // 
            this.настройкаСоединенияСБазойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.соединениеСБДToolStripMenuItem});
            this.настройкаСоединенияСБазойToolStripMenuItem.Name = "настройкаСоединенияСБазойToolStripMenuItem";
            this.настройкаСоединенияСБазойToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкаСоединенияСБазойToolStripMenuItem.Text = "Настройки";
            // 
            // соединениеСБДToolStripMenuItem
            // 
            this.соединениеСБДToolStripMenuItem.Name = "соединениеСБДToolStripMenuItem";
            this.соединениеСБДToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.соединениеСБДToolStripMenuItem.Text = "Соединение с БД";
            this.соединениеСБДToolStripMenuItem.Click += new System.EventHandler(this.соединениеСБДToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // owners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(613, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "owners";
            this.Text = "Владельцы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.owners_FormClosed);
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выставленнаяНедвижимостьToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem недвижимостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОНедвижимостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem владельцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОВладельцахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОКлиентахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОНедвижимостиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem договораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОДогогворахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаСоединенияСБазойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соединениеСБДToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}