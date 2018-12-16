using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class property : Form
    {
        public DateTime time = new DateTime();
        public property()
        {
            InitializeComponent();
        }

        public string searchValue = "where ";
        public void loadDataGridView() //пользовательская функция для вывода dataGridView
        {
            PublicClasses.sql = "";
            dataGridView1.DataSource = new DataSet();
            if (searchValue == "where ")
            {
                PublicClasses.sql = "select idProperty, concat(type.type, ' ', typeproperty.typeProperty) as 'Тип Недвижимости', cities.city as 'Город', areas.area as 'Область', district.district as 'Район', undergroundstations.undergroundStation as 'ст. Метро', if(property.buyRent=1,'Продажy','Арендy') as 'Выставлен на', price "+
                  "from property " +
                  "left join type on property.type = type.idType " +
                  "left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty " +
                  "left join cities on property.idCity = cities.idCity " +
                  "left join areas on property.idArea = areas.idArea " +
                  "left join district on property.idDistrict = district.idDistrict " +
                  "left join undergroundstations on property.idUndergroundStation = undergroundstations.idUndergroundStation where isRemoveBuyRent<>1";
            }
            else
            {
                PublicClasses.sql = "select idProperty, concat(type.type, ' ', typeproperty.typeProperty) as 'Тип Недвижимости', cities.city as 'Город', areas.area as 'Область', district.district as 'Район', undergroundstations.undergroundStation as 'ст. Метро', if(property.buyRent=1,'Продажy','Арендy') as 'Выставлен на', price " +
                "from property " +
                "left join type on property.type = type.idType " +
                "left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty " +
                "left join cities on property.idCity = cities.idCity " +
                "left join areas on property.idArea = areas.idArea " +
                "left join district on property.idDistrict = district.idDistrict " +
                "left join undergroundstations on property.idUndergroundStation = undergroundstations.idUndergroundStation " + searchValue.Remove(searchValue.Length - 4) + " and isRemoveBuyRent<>1";
            }
            dataGridView1.DataSource = PublicClasses.executeSqlRequest().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Тип недвижимости";
            dataGridView1.Columns[2].HeaderText = "Город";
            dataGridView1.Columns[3].HeaderText = "Область";
            dataGridView1.Columns[4].HeaderText = "Район";
            dataGridView1.Columns[5].HeaderText = "Ст. метро";
            dataGridView1.Columns[6].HeaderText = "Выставлен на";
            dataGridView1.Columns[7].HeaderText = "Цена";
        }

        private void Form2_Load(object sender, EventArgs e) //загрузка формы
        {
            if (PublicClasses.privelege == 1)
            {
                contextMenuStrip1.Items[0].Visible = false;
                contextMenuStrip1.Items[1].Visible = false;
                contextMenuStrip1.Items[2].Visible = false;
                contextMenuStrip1.Items[3].Visible = false;
                contextMenuStrip1.Items[5].Visible = false;
            }
            time = DateTime.Now;
            toolStrip1.Items[0].Text = " Время: " + time.ToLongTimeString();
            toolStrip1.Items[1].Text = "Пользователь: " + PublicClasses.UserLogin;
            PublicClasses.sql = "select distinct(concat(type.type,' ',typeproperty.typeProperty)) from type left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty";
            comboBox1.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select city from cities";
            comboBox2.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select area from areas";
            comboBox3.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select district from district";
            comboBox4.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select undergroundStation from undergroundstations";
            comboBox5.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select idProperty, concat(type.type, ' ', typeproperty.typeProperty) as 'Тип Недвижимости', cities.city as 'Город', areas.area as 'Область', district.district as 'Район', undergroundstations.undergroundStation as 'ст. Метро', if(property.buyRent=1,'Продажу','Аренду') as 'Выставлен на', price " +
               "from property " +
               "left join type on property.type = type.idType " +
               "left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty " +
               "left join cities on property.idCity = cities.idCity " +
               "left join areas on property.idArea = areas.idArea " +
               "left join district on property.idDistrict = district.idDistrict " +
               "left join undergroundstations on property.idUndergroundStation = undergroundstations.idUndergroundStation " +
               "where isRemoveBuyRent<>1";
            dataGridView1.DataSource = PublicClasses.executeSqlRequest().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Тип недвижимости";
            dataGridView1.Columns[2].HeaderText = "Город";
            dataGridView1.Columns[3].HeaderText = "Область";
            dataGridView1.Columns[4].HeaderText = "Район";
            dataGridView1.Columns[5].HeaderText = "Ст. метро";
            dataGridView1.Columns[6].HeaderText = "Выставлен на";
            dataGridView1.Columns[7].HeaderText = "Цена";
        }

            private void timer1_Tick(object sender, EventArgs e) //таймер
        {
            time = DateTime.Now;
            toolStrip1.Items[0].Text = " Время: "+time.ToLongTimeString();
            toolStrip1.Items[2].Text = "Пользователь: "+PublicClasses.UserLogin;
            toolStrip1.Items[4].Text = "Соединения с базой: активно";
        }

        private void button2_Click(object sender, EventArgs e) //кнопка очистка формы
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Value = 0;
        }

        private void соединениеСБДToolStripMenuItem_Click(object sender, EventArgs e) //пунт меню
        {
            dbSettings form5 = new dbSettings();
            form5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) // поиск недвижимости
        {
            searchValue = "where ";
            if (comboBox1.Text != "") { searchValue += "concat(type.type, ' ', typeproperty.typeProperty)=" + "'" + comboBox1.Text + "' and "; }
            if (comboBox2.Text != "") { searchValue += "city=" + "'" + comboBox2.Text + "' and "; }
            if (comboBox3.Text != "") { searchValue += "areas=" + "'" + comboBox3.Text + "' and "; }
            if (comboBox4.Text != "") { searchValue += "district=" + "'" + comboBox4.Text + "' and "; }
            if (comboBox5.Text != "") { searchValue += "undergroundestation=" + "'" + comboBox5.Text + "' and "; }
            if (radioButton1.Checked) { searchValue += "buyRent=0 and "; }
            if (radioButton2.Checked) { searchValue += "buyRent=1 and "; }
            if (numericUpDown1.Value != 0) { searchValue += "  countRoom=" + numericUpDown1.Value; }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (textBox1.Text == "" && textBox2.Text != "") { searchValue += "price<" + Convert.ToInt16(textBox2.Text) + " and "; }
                if (textBox2.Text == "" && textBox1.Text != "") { searchValue += "price>" + Convert.ToInt16(textBox1.Text) + " and "; }
            }
            else
            {
                if (textBox1.Text != "") { searchValue += "price between " + textBox1.Text + " and "; }
                if (textBox2.Text != "") { searchValue += textBox2.Text; }
            }
            if (searchValue == "where ") { MessageBox.Show("Вы не заполнили ни одного поля", "Поиск недвижимости", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                label10.Visible = true;
                if (PublicClasses.executeSqlRequest().Tables[0].Rows.Count != 0)
                {
                    loadDataGridView();
                }
                else MessageBox.Show("Не удалось найти недвижимость по вашим требованиям.", "Поиск недвижимости", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) //пункт меню
        {
            this.Hide();
            detailedDescription form7 = new detailedDescription();
            form7.ShowDialog();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e) //пункт меню
        {
            this.Hide();
            addProperty form6 = new addProperty();
            form6.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e) //пункт меню
        {
            this.Hide();
            detailedDescription form7 = new detailedDescription();
            form7.ShowDialog();
            
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublicClasses.deleteSelectedRow(dataGridView1, "property", "isRemoveBuyRent=1", "idProperty");
            loadDataGridView();
        }

        private void подробнаяИнфорацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailedDescription form7 = new detailedDescription();
            form7.ShowDialog();
            this.Close();
        }

        private void инфомацияОКлиентахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clients clients = new clients();
            clients.Show();
            this.Close();
        }

        private void информацияОВладельцахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            owners owners = new owners();
            owners.Show();
            this.Close();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (((e.RowIndex > -1) || (e.Button == MouseButtons.Right))&&e.RowIndex<dataGridView1.Rows.Count-1)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.Rows[e.RowIndex].Cells[0].Selected = true;
                PublicClasses.selectedRowIndex=Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                PublicClasses.rowIndex = dataGridView1.Rows[e.RowIndex].Index;
                dataGridView1.Rows[e.RowIndex].ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void добавитьВладельцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClientOwner addOwner = new addClientOwner("addOwner");
            addOwner.ShowDialog();
            this.Close();
        }

        private void купитьНедвижимостьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*if (PublicClasses.privelege == 1)
            {
                PublicClasses.sql = "insert into contracts(idContract,idProperty,idPerson,idClient,date) values(" + values.Remove(values.Length - 1) + ",0" + ")";
                PublicClasses.executeSqlRequest();
                MessageBox.Show("Недвижимость успешно добавлена", "Добавление недвижимости", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void информацияОСотрудникахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personal personal = new personal();
            personal.Show();
            this.Close();
        }

        private void информацияОДоговорахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contracts contracts = new contracts();
            contracts.Show();
            this.Close();
        }

        private void property_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1) { Application.Exit(); }
        }
    }
}
