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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
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
