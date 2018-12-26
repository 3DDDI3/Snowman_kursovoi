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
    public partial class personal : Form
    {
        public personal()
        {
            InitializeComponent();
        }

        public string searchValue = "";
        public DateTime time;

        private void loadDataGridView()
        {
            if (searchValue == "")
            {
                PublicClasses.sql = "select idPerson, persons.idSpecial,  surname, name, lastname, special, dateReceipt from persons left join specials on persons.idSpecial=specials.idSpecial where isDeleted=0";
                dataGridView1.DataSource = PublicClasses.executeSqlRequest().Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].HeaderText = "Фамилия";
                dataGridView1.Columns[3].HeaderText = "Имя";
                dataGridView1.Columns[4].HeaderText = "Отчество";
                dataGridView1.Columns[5].HeaderText = "Должность";
                dataGridView1.Columns[6].HeaderText = "Дата приема";
            }
            else
            {
                PublicClasses.sql = "select idPerson, persons.idSpecial,  surname, name, lastname, special, dateReceipt from persons left join specials on persons.idSpecial=specials.idSpecial where isDeleted=0 and "+searchValue.Remove(searchValue.Length-3)+"";
                dataGridView1.DataSource = PublicClasses.executeSqlRequest().Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].HeaderText = "Фамилия";
                dataGridView1.Columns[3].HeaderText = "Имя";
                dataGridView1.Columns[4].HeaderText = "Отчество";
                dataGridView1.Columns[5].HeaderText = "Должность";
                dataGridView1.Columns[6].HeaderText = "Дата приема";
            }
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

        private void personal_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            PublicClasses.sql = "select concat(surname,' ', left(name,1),'.',left(lastname,1),'.') from persons where isDeleted=0";
            comboBox1.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select special from specials";
            comboBox2.Items.AddRange(PublicClasses.loadStringsToCmbbox());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchValue = "";
            PublicClasses.sql = "select idSpecial from specials where special='" + comboBox2.Text + "'";
            int idSpecial = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
            MessageBox.Show(idSpecial.ToString());
            if (comboBox1.Text != "") { searchValue += "concat(surname,' ', left(name,1),'.',left(lastname,1),'.')='" + comboBox1.Text + "' and"; }
            if (comboBox2.Text != "") { searchValue += "persons.idSpecial='" + idSpecial + "' and"; }
            loadDataGridView();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPerson addPerson = new addPerson("addPerson");
            this.Close();
            addPerson.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPerson changePersonsData = new addPerson("changePersonsData");
            this.Close();
            changePersonsData.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            toolStrip1.Items[0].Text = " Время: " + time.ToLongTimeString();
            toolStrip1.Items[2].Text = "Пользователь: " + PublicClasses.UserLogin;
            toolStrip1.Items[4].Text = "Соединения с базой: активно";
        }

        private void personal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1) { Application.Exit(); }
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

        private void информацияОДогворахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contracts cntrct = new contracts();
            cntrct.Show();
            this.Close();
        }

        private void соединениеСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbSettings dbsttngst = new dbSettings();
            dbsttngst.ShowDialog();
        }
    }
}
