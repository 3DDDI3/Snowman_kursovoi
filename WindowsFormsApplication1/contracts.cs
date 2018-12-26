using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class contracts : Form
    {
        public contracts()
        {
            InitializeComponent();
        }

        public DateTime time;

        private void contracts_Load(object sender, EventArgs e)
        {
            PublicClasses.sql = "select * from showcontracts";
            dataGridView1.DataSource = PublicClasses.executeSqlRequest().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Сотрудник";
            dataGridView1.Columns[3].HeaderText = "Владелец";
            dataGridView1.Columns[4].HeaderText = "Клиент";
            dataGridView1.Columns[5].HeaderText = "Дата оформления";
            dataGridView1.Columns[6].HeaderText = "Начало периода";
            dataGridView1.Columns[7].HeaderText = "Конец периода";
            dataGridView1.Columns[8].HeaderText = "Цена";
            dataGridView1.Columns[9].HeaderText = "Выставлен на";
            dataGridView1.Columns[10].HeaderText = "Статус договора";
            PublicClasses.sql = "select concat(surname,' ', left(name,1),'.',left(lastname,1),'.') from persons where isDeleted=0";
            comboBox1.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select concat(surname,' ', left(name,1),'.',left(lastname,1),'.') from clients where isDeleted=0";
            comboBox2.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select concat(surname,' ', left(name,1),'.',left(lastname,1),'.') from owners where isDeleted=0";
            comboBox3.Items.AddRange(PublicClasses.loadStringsToCmbbox());
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (((e.RowIndex > -1) || (e.Button == MouseButtons.Right)) && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.Rows[e.RowIndex].Cells[0].Selected = true;
                PublicClasses.selectedRowIndex = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                dataGridView1.Rows[e.RowIndex].ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void информацияОНедвижимостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            property prty = new property();
            prty.Show();
            this.Close();
        }

        private void информацияОКлиентахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clients clnt = new clients();
            clnt.Show();
            this.Close();
        }

        private void информацияОВладельцахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            owners ownr = new owners();
            ownr.Show();
            this.Close();
        }

        private void информацияОСотрудникахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personal prsnl = new personal();
            prsnl.Show();
            this.Close();
        }

        private void соединениеСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbSettings dbsttgs = new dbSettings();
            dbsttgs.ShowDialog();
        }

        private void contracts_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1) { Application.Exit(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            toolStrip1.Items[0].Text = " Время: " + time.ToLongTimeString();
            toolStrip1.Items[2].Text = "Пользователь: " + PublicClasses.UserLogin;
            toolStrip1.Items[4].Text = "Соединения с базой: активно";
        }
    }
}
