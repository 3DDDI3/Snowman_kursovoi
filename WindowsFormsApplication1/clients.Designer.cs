namespace WindowsFormsApplication1
{
    partial class clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clients));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьЗаключенныеСделкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.недвижимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.купитьарендоватьНедвижимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.информацияОВладельцахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОДоговорахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиСоединенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настроитьСоединениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ф.И.О";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(586, 383);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКлиентаToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.показатьЗаключенныеСделкиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(245, 92);
            // 
            // добавитьКлиентаToolStripMenuItem
            // 
            this.добавитьКлиентаToolStripMenuItem.Name = "добавитьКлиентаToolStripMenuItem";
            this.добавитьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.добавитьКлиентаToolStripMenuItem.Text = "Добавить";
            this.добавитьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьКлиентаToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // показатьЗаключенныеСделкиToolStripMenuItem
            // 
            this.показатьЗаключенныеСделкиToolStripMenuItem.Name = "показатьЗаключенныеСделкиToolStripMenuItem";
            this.показатьЗаключенныеСделкиToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.показатьЗаключенныеСделкиToolStripMenuItem.Text = "Показать заключенные сделки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Поиск клиента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 451);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(613, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
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
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
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
            this.toolStripLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel3.LinkColor = System.Drawing.Color.White;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel3.Text = "toolStripLabel3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.недвижимостьToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.договрыToolStripMenuItem,
            this.настройкиСоединенияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // недвижимостьToolStripMenuItem
            // 
            this.недвижимостьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.купитьарендоватьНедвижимостьToolStripMenuItem});
            this.недвижимостьToolStripMenuItem.Name = "недвижимостьToolStripMenuItem";
            this.недвижимостьToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.недвижимостьToolStripMenuItem.Text = "Недвижимость";
            // 
            // купитьарендоватьНедвижимостьToolStripMenuItem
            // 
            this.купитьарендоватьНедвижимостьToolStripMenuItem.Name = "купитьарендоватьНедвижимостьToolStripMenuItem";
            this.купитьарендоватьНедвижимостьToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.купитьарендоватьНедвижимостьToolStripMenuItem.Text = "Информация о недвижимости";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОВладельцахToolStripMenuItem});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.клиентыToolStripMenuItem.Text = "Владельцы";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // информацияОВладельцахToolStripMenuItem
            // 
            this.информацияОВладельцахToolStripMenuItem.Name = "информацияОВладельцахToolStripMenuItem";
            this.информацияОВладельцахToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.информацияОВладельцахToolStripMenuItem.Text = "Информация о владельцах";
            // 
            // договрыToolStripMenuItem
            // 
            this.договрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОДоговорахToolStripMenuItem});
            this.договрыToolStripMenuItem.Name = "договрыToolStripMenuItem";
            this.договрыToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.договрыToolStripMenuItem.Text = "Договоры";
            // 
            // информацияОДоговорахToolStripMenuItem
            // 
            this.информацияОДоговорахToolStripMenuItem.Name = "информацияОДоговорахToolStripMenuItem";
            this.информацияОДоговорахToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.информацияОДоговорахToolStripMenuItem.Text = "Информация о договорах";
            // 
            // настройкиСоединенияToolStripMenuItem
            // 
            this.настройкиСоединенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настроитьСоединениеToolStripMenuItem});
            this.настройкиСоединенияToolStripMenuItem.Name = "настройкиСоединенияToolStripMenuItem";
            this.настройкиСоединенияToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.настройкиСоединенияToolStripMenuItem.Text = "Настройки соединения";
            // 
            // настроитьСоединениеToolStripMenuItem
            // 
            this.настроитьСоединениеToolStripMenuItem.Name = "настроитьСоединениеToolStripMenuItem";
            this.настроитьСоединениеToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.настроитьСоединениеToolStripMenuItem.Text = "Настроить соединение";
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(613, 476);
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
            this.Name = "clients";
            this.Text = "Клиенты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.clients_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьЗаключенныеСделкиToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem недвижимостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem купитьарендоватьНедвижимостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem информацияОВладельцахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОДоговорахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиСоединенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настроитьСоединениеToolStripMenuItem;
    }
}