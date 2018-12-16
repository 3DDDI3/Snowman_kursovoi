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
            //PublicClasses.sql="select idProperty"
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string where = "";
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                PublicClasses.sql = "select idPerson from persons where concat(surname,' ', left(name,1),'.',left(lastname,1),'.')=" + comboBox1.Text;
                int idPerson = Convert.ToInt16(PublicClasses.executeSqlRequest());
                where += "idPerson=" + idPerson+",";
            }
            if (!string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                PublicClasses.sql = "select idClient from clients where concat(surname,' ', left(name,1),'.',left(lastname,1),'.')=" + comboBox2.Text;
                int idClient = Convert.ToInt16(PublicClasses.executeSqlRequest());
                where += "idClient=" + idClient + ",";
            }
            if (!string.IsNullOrWhiteSpace(comboBox3.Text))
            {
                PublicClasses.sql = "select idOwner from owners where concat(surname,' ', left(name,1),'.',left(lastname,1),'.')=" + comboBox3.Text;
                int idOwner = Convert.ToInt16(PublicClasses.executeSqlRequest());
                where += "idOwner=" + idOwner + ",";
            }
            where+="date between " + dateTimePicker1.Value.ToShortDateString() + " and " + dateTimePicker2.Value.ToShortDateString()+",";
            if(!string.IsNullOrWhiteSpace(comboBox4.Text))
            {
                if(comboBox4.Text=="Договор не подтвержден") { where += "status=0"; }
                if(comboBox4.Text=="Договор подтвержден") { where += "status=1"; }
            }
            PublicClasses.sql = "select * from showcontracts where" + where;
            MessageBox.Show(PublicClasses.sql);*/
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
    }
}
