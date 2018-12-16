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
    public partial class detailedDescription : Form
    {
        public detailedDescription()
        {
            InitializeComponent();
        }

        public void loadDataGridView() //пользовательская функция для вывода dataGridView
        {
            property form2 = new property();
            form2.dataGridView1.DataSource = null;
            PublicClasses.sql = "select idProperty, concat(type.type, ' ', typeproperty.typeProperty) as 'Тип Недвижимости', cities.city as 'Город', area.area as 'Область', district.district as 'Район', undergroundstations.undergroundStation as 'ст. Метро', if(property.buyRent=1,'Продажy','Арендy') as 'Выставлен на'" +
                  "from property " +
                  "left join type on property.type = type.idType " +
                  "left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty " +
                  "left join cities on property.idCity = cities.idCity " +
                  "left join area on property.idArea = area.idArea " +
                  "left join district on property.idDistrict = district.idDistrict " +
                  "left join undergroundstations on property.idUndergroundStation = undergroundstations.idUndergroundStation " +
                  "where isRemoveBuyRent<>1";
            form2.dataGridView1.DataSource = PublicClasses.executeSqlRequest().Tables[0];
            form2.dataGridView1.Columns[0].Visible = false;
            form2.dataGridView1.Columns[1].HeaderText = "Тип недвижимости";
            form2.dataGridView1.Columns[2].HeaderText = "Город";
            form2.dataGridView1.Columns[3].HeaderText = "Область";
            form2.dataGridView1.Columns[4].HeaderText = "Район";
            form2.dataGridView1.Columns[5].HeaderText = "Ст. метро";
            form2.dataGridView1.Columns[6].HeaderText = "Выставлен на";
            form2.Show();
        }
        public void loadFormFields(int idProperty, int rowIndex)
        {
            PublicClasses.sql = "select distinct(concat(type.type,' ',typeproperty.typeProperty)) from type left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty";
            comboBox5.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select city from cities";
            comboBox1.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select area from area";
            comboBox2.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select district from district";
            comboBox3.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select undergroundStation from undergroundstations";
            comboBox4.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select concat(surname,' ',left(name,1),'. ',left(lastname,1),'.') from owners";
            comboBox6.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            PublicClasses.sql = "select concat(type.type, ' ', typeproperty.typeProperty), cities.city, area.area, district.district, undergroundstations.undergroundStation, if(property.buyRent=1,'Продажу','Аренду'), concat(surname,' ',left(name,1),'. ',left(lastname,1),'.'), price, isLoggia, isFloor, countFloor, countRoom, description " +
               "from property left join type on property.type = type.idType " +
               "left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty " +
               "left join cities on property.idCity = cities.idCity " +
               "left join area on property.idArea = area.idArea " +
               "left join district on property.idDistrict = district.idDistrict " +
               "left join undergroundstations on property.idUndergroundStation = undergroundstations.idUndergroundStation " +
               "left join owners on property.idOwner=owners.idOwner " +
               "where property.idProperty=" + idProperty + "";
            if(idProperty==-1)
            {
                PublicClasses.sql = PublicClasses.sql.Remove(PublicClasses.sql.IndexOf("where"));
            }
            comboBox5.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[0].ToString();
            comboBox1.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[1].ToString();
            comboBox2.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[2].ToString();
            comboBox3.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[3].ToString();
            comboBox4.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[4].ToString();
            comboBox6.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[6].ToString();
            textBox1.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[7].ToString();
            if (!string.IsNullOrEmpty(PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[8].ToString())) { checkBox1.Checked = true; }
            textBox3.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[9].ToString();
            textBox4.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[10].ToString();
            textBox2.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[11].ToString();
            if (PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[5].ToString() == "Аренду") { radioButton1.Checked = true; }
            else { radioButton2.Checked = true; }
            richTextBox1.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[12].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadDataGridView();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //кнопка Редактировать данные
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            checkBox1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            richTextBox1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e) //сохранение изменений
        {
            if (string.IsNullOrEmpty(comboBox5.Text) || string.IsNullOrEmpty(comboBox6.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                if (string.IsNullOrEmpty(textBox1.Text)) { errorProvider1.SetError(label11, "Поле не должно быть пустым"); }
                if (string.IsNullOrEmpty(comboBox5.Text)) { errorProvider1.SetError(comboBox5, "Поле не должно быть пустым"); }
                if (string.IsNullOrEmpty(comboBox6.Text)) { errorProvider1.SetError(comboBox6, "Поле не должно быть пустым"); }
            }
            else
            {
                string set = "";
                if (comboBox1.Text != "")
                {
                    PublicClasses.sql = "select * from cities where city='" + comboBox1.Text + "'";
                    int idCity = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    set += "idCity=" + idCity + ",";
                }
                if (comboBox2.Text != "")
                {
                    PublicClasses.sql = "select * from area where Area='" + comboBox2.Text + "'";
                    int idArea = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    set += "idArea=" + idArea + ",";
                }
                if (comboBox3.Text != "")
                {
                    PublicClasses.sql = "select * from district where district='" + comboBox3.Text + "'";
                    int idDistrict = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    set += "idDistrict=" +idDistrict+ ",";
                }
                if (comboBox4.Text != "")
                {
                    PublicClasses.sql = "select * from undergroundstations where undergroundStation='" + comboBox4.Text + "'";
                    int idUndergroundStation = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    set += "idUndergroundStation=" + idUndergroundStation + ",";
                }
                if (comboBox5.Text != "")
                {
                    PublicClasses.sql = "select type.idType, concat(type.type,' ',typeproperty.typeProperty) from type left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty where concat(type.type,' ',typeproperty.typeProperty)='" + comboBox5.Text + "'";
                    int idType = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    set += "type=" + idType + ",";
                }
                if (comboBox6.Text != "")
                {
                    PublicClasses.sql = "select * from owners where concat(surname,' ',left(name,1),'. ',left(lastname,1),'.')='" + comboBox6.Text + "'";
                    int idOwner = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    set += "idOwner=" + idOwner + ",";
                }
                if (textBox2.Text != "") { set += "countRoom=" + textBox2.Text + ","; }
                if (textBox3.Text != "") { set += "isFloor=" + textBox3.Text + ","; }
                if (textBox4.Text != "") { set += "countFloor=" + textBox4.Text + ","; }
                if (textBox1.Text != "") { set += "price=" + textBox1.Text.Replace(",",".") + ","; }
                if (checkBox1.Checked) { set += "isLoggia=1,"; }
                if (radioButton1.Checked) { set += "buyRent=0,"; }
                if (radioButton2.Checked) { set += "buyRent=1,"; }
                try
                {
                    PublicClasses.sql = "update property set " + set.Remove(set.Length - 1) + " where idProperty=" + PublicClasses.selectedRowIndex + "";
                    PublicClasses.executeSqlRequest();
                    MessageBox.Show("Изменения успешно занесены.", "Изменение данных недвижимости", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex) { MessageBox.Show("Что-то пошло не так. Поробуйте еще раз.", "Изменение данных недвижимости", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void button3_Click(object sender, EventArgs e) //снятие блокировки с полей 
        {
            PublicClasses.sql = "update property set isRemoveBuyRent=1 where idProperty=" + PublicClasses.selectedRowIndex + "";
            PublicClasses.executeSqlRequest();
            MessageBox.Show("Недвижимость снята с продажи.", "Снятие недвижимости с продажи", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form7_Load(object sender, EventArgs e) //вставка данных в поля
        {
            loadFormFields(PublicClasses.selectedRowIndex,0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (PublicClasses.rowIndex > 0)
            {
                PublicClasses.rowIndex--;
            }
            loadFormFields(-1, PublicClasses.rowIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PublicClasses.sql = "select * from property";
            if (PublicClasses.rowIndex < PublicClasses.executeSqlRequest().Tables[0].Rows.Count-1)
            {
                PublicClasses.rowIndex++;
            }
            loadFormFields(-1, PublicClasses.rowIndex);
        }
    }
}
