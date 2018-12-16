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
    public partial class clients : Form
    {
        public clients()
        {
            InitializeComponent();
        }

        public DateTime time = new DateTime();

        public void loadDataGridView()
        {
            dataGridView1.DataSource = null;
            PublicClasses.sql = "select * from clients where isDeleted=0";
            dataGridView1.DataSource = PublicClasses.executeSqlRequest().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Адрес";
            dataGridView1.Columns[5].HeaderText = "Телефон";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            PublicClasses.sql = "select concat(surname,' ',left(name,1),' ',left(lastname,1)) from clients";
            comboBox1.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            loadDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                PublicClasses.sql = "select * from clients where concat(surname,' ',left(name,1),' ',left(lastname,1))='" + comboBox1.Text + "'";
                dataGridView1.DataSource = PublicClasses.executeSqlRequest().Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Фамилия";
                dataGridView1.Columns[2].HeaderText = "Имя";
                dataGridView1.Columns[3].HeaderText = "Отчество";
                dataGridView1.Columns[4].HeaderText = "Адрес";
                dataGridView1.Columns[5].HeaderText = "Телефон";
            }
            else { errorProvider1.SetError(comboBox1, "Поле не должно быть пустым"); }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.RowIndex > -1) || (e.Button == MouseButtons.Right))
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.Rows[e.RowIndex].Cells[0].Selected = true;
                PublicClasses.selectedRowIndex = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                dataGridView1.Rows[e.RowIndex].ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublicClasses.deleteSelectedRow(dataGridView1, "clients", "isDeleted=1", "idClient");
            MessageBox.Show("Клиент успешно удален", "Удаление клиента", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClientOwner addClient = new addClientOwner("addClient");
            this.Hide();
            addClient.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClientOwner changeClientsData = new addClientOwner("changeClientsData");
            this.Hide();
            changeClientsData.ShowDialog();
        }

        private void clients_FormClosed(object sender, FormClosedEventArgs e)
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
