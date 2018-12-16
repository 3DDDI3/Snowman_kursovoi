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
    public partial class owners : Form
    {
        public owners()
        {
            InitializeComponent();
        }

        public void loadDataGridView()
        {
            dataGridView1.DataSource = new DataSet();
            PublicClasses.sql = "select * from owners where isDeleted=0";
            dataGridView1.DataSource = PublicClasses.executeSqlRequest().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Адрес";
            dataGridView1.Columns[5].HeaderText = "Телефон";
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            PublicClasses.sql = "select concat(surname,' ',left(name,1),' ',left(lastname,1)) from owners";
            comboBox1.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            loadDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                PublicClasses.sql = "select * from owners where concat(surname,' ',left(name,1),' ',left(lastname,1))='" + comboBox1.Text + "'";
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

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClientOwner addOwner= new addClientOwner("addOwner");
            this.Hide();
            addOwner.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClientOwner changeOwnersData = new addClientOwner("changeOwnersData");
            this.Hide();
            changeOwnersData.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublicClasses.deleteSelectedRow(dataGridView1, "clients", "isDeleted=1", "idClient");
            loadDataGridView();
        }
    }
}
