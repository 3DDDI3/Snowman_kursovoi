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
    public partial class addClientOwner : Form
    {
        public addClientOwner(string formName)
        {
            InitializeComponent();
            if (formName == "addClient")
            {
                this.Text = "Добавление клиента";
                this.button1.Text = "Добавить клиента";
                this.button1.Click += addClient;
                this.button2.Click += closeClient;
            }
            if (formName == "addOwner")
            {
                this.Text = "Добавление владельца";
                this.button1.Text = "Добавить владедьца";
                this.button1.Click += addOwner;
                this.button2.Click += closeOwner;
            }
            if (formName == "changeOwnersData")
            {
                this.Text = "Изменение данных владельца";
                this.button1.Text = "Сохранить изменения";
                this.button1.Click += changeOwnersData;
                loadDatasToFields("owners", "idOwner");
                this.button2.Click += closeOwner;
            }
            if (formName == "changeClientsData")
            {
                this.Text = "Изменение данных клиента";
                this.button1.Text = "Сохранить изменения";
                this.button1.Click += changeClientsData;
                loadDatasToFields("clients", "idClient");
                this.button2.Click += closeClient;
            }
        }

        private void loadDatasToFields(string tableName, string columName)
        {
            PublicClasses.sql = "select surname from " + tableName + " where " + columName + "=" + PublicClasses.selectedRowIndex + "";
            textBox1.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0].ToString();
            PublicClasses.sql= "select name from " + tableName + " where " + columName + "=" + PublicClasses.selectedRowIndex + "";
            textBox2.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0].ToString();
            PublicClasses.sql = "select lastname from " + tableName + " where " + columName + "=" + PublicClasses.selectedRowIndex + "";
            textBox3.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0].ToString();
            PublicClasses.sql = "select adres from " + tableName + " where " + columName + "=" + PublicClasses.selectedRowIndex + "";
            textBox4.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0].ToString();
            PublicClasses.sql = "select phone from " + tableName + " where " + columName + "=" + PublicClasses.selectedRowIndex + "";
            textBox5.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0].ToString();
        }

        private void loadDataGridView(string tableName)
        {
            if (tableName == "owners")
            {
                owners owners = new owners();
                owners.dataGridView1.DataSource = null;
                PublicClasses.sql = "select * from owners where isDeleted=0";
                owners.dataGridView1.DataSource = PublicClasses.executeSqlRequest().Tables[0];
                owners.dataGridView1.Columns[0].Visible = false;
                owners.dataGridView1.Columns[6].Visible = false;
                owners.dataGridView1.Columns[1].HeaderText = "Фамилия";
                owners.dataGridView1.Columns[2].HeaderText = "Имя";
                owners.dataGridView1.Columns[3].HeaderText = "Отчество";
                owners.dataGridView1.Columns[4].HeaderText = "Адрес";
                owners.dataGridView1.Columns[5].HeaderText = "Телефон";
                owners.Show();
            }
            else
            {
                clients clients = new clients();
                clients.dataGridView1.DataSource = null;
                PublicClasses.sql = "select * from clients where isDeleted=0";
                clients.dataGridView1.DataSource = PublicClasses.executeSqlRequest().Tables[0];
                clients.dataGridView1.Columns[0].Visible = false;
                clients.dataGridView1.Columns[6].Visible = false;
                clients.dataGridView1.Columns[1].HeaderText = "Фамилия";
                clients.dataGridView1.Columns[2].HeaderText = "Имя";
                clients.dataGridView1.Columns[3].HeaderText = "Отчество";
                clients.dataGridView1.Columns[4].HeaderText = "Адрес";
                clients.dataGridView1.Columns[5].HeaderText = "Телефон";
                clients.Show();
            }
        }

        private void addOwner(object sender, EventArgs e) //добавление владельца
        {
            string columnsTable = "isDeleted,";
            string values = "0,";
            if (textBox1.Text != "") { columnsTable += "surname,"; values += "'" + textBox1.Text + "'" + ","; }
            if (textBox2.Text != "") { columnsTable += "name,"; values += "'" + textBox2.Text + "'" + ","; }
            if (textBox3.Text != "") { columnsTable += "lastname,"; values += "'" + textBox3.Text + "'" + ","; }
            if (textBox4.Text != "") { columnsTable += "adres,"; values += "'" + textBox4.Text + "'" + ","; }
            if (textBox5.Text != "") { columnsTable += "phone"; values += "'" + textBox5.Text + "'" + ""; }
            if (columnsTable != "isDeleted," && values != "0,")
            {
                PublicClasses.insertIntoTable("owners", columnsTable, values);
                MessageBox.Show("Клиент добавлен успешно", "Добавление клиента", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void closeOwner(object sender, EventArgs e) //добавление владельца
        {
            loadDataGridView("owners");
            this.Close();
        }

        private void closeClient(object sender, EventArgs e) //добавление владельца
        {
            loadDataGridView("clients");
            this.Close();
        }

        private void addClient(object sender, EventArgs e) //добавление клиента
        {
            string columnsTable = "isDeleted,";
            string values = "0,";
            if (textBox1.Text != "") { columnsTable += "surname,"; values += "'" + textBox1.Text + "'" + ","; }
            if (textBox2.Text != "") { columnsTable += "name,"; values += "'" + textBox2.Text + "'" + ","; }
            if (textBox3.Text != "") { columnsTable += "lastname,"; values += "'" + textBox3.Text + "'" + ","; }
            if (textBox4.Text != "") { columnsTable += "adres,"; values += "'" + textBox4.Text + "'" + ","; }
            if (textBox5.Text != "") { columnsTable += "phone"; values += "'" + textBox5.Text + "'" + ""; }
            if (columnsTable != "isDeleted," && values != "0,")
            {
                PublicClasses.insertIntoTable("clients", columnsTable, values);
                MessageBox.Show("Владелец добавлен успешно", "Добавление клиента", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void changeOwnersData(object sender, EventArgs e) //добавление клиента
        {
            string set = "";
            if (textBox1.Text != "") { set += "surname=" + "'" + textBox1.Text + "',"; }
            if (textBox2.Text != "") { set += "name=" + "'" + textBox2.Text + "',"; }
            if (textBox3.Text != "") { set += "lastname=" + "'" + textBox3.Text + "',"; }
            if (textBox4.Text != "") { set += "adres=" + "'" + textBox4.Text + "',"; }
            if (textBox5.Text != "") { set += "phone=" + "'" + textBox5.Text + "',"; }
            if (set != "")
            {
                PublicClasses.sql = "update owners set "+set.Remove(set.Length-1)+" where idOwner=" + PublicClasses.selectedRowIndex + "";
                MessageBox.Show(PublicClasses.sql);
                PublicClasses.executeSqlRequest();
                MessageBox.Show("Данные изменены успешно", "Изменение данных владельца", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadDataGridView("owners");
        }

        private void changeClientsData(object sender, EventArgs e) //добавление клиента
        {
            string set = "";
            if (textBox1.Text != "") { set += "surname=" + "'" + textBox1.Text + "',"; }
            if (textBox2.Text != "") { set += "name=" + "'" + textBox2.Text + "',"; }
            if (textBox3.Text != "") { set += "lastname=" + "'" + textBox3.Text + "',"; }
            if (textBox4.Text != "") { set += "adres=" + "'" + textBox4.Text + "',"; }
            if (textBox5.Text != "") { set += "phone=" + "'" + textBox5.Text + "',"; }
            if (set != "")
            {
                PublicClasses.sql = "update clients set "+set.Remove(set.Length-1)+" where idClient=" + PublicClasses.selectedRowIndex + "";
                MessageBox.Show(PublicClasses.sql);
                PublicClasses.executeSqlRequest();
                MessageBox.Show("Данные изменены успешно", "Изменение данных клиента", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
