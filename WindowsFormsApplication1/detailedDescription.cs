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
        public detailedDescription(string inString)
        {
            InitializeComponent();
            switch(inString)
            {
                case "withdrawFromSale":
                    {
                        this.Load += withdrawFromSaleLoad;
                        button2.Click += formClose;
                        break;
                    }
                case "showOrChangeDetailedDescription":
                    {
                        this.Load += showOrChangeDetailedDescriptionLoad;
                        button2.Click += formClose;
                        break;
                    }
            }
        }

        public void loadDataGridView() //пользовательская функция для вывода dataGridView
        {
            property form2 = new property();
            form2.dataGridView1.DataSource = null;
            PublicClasses.sql = "select idProperty, concat(type.type, ' ', typeproperty.typeProperty) as 'Тип Недвижимости', cities.city as 'Город', areas.area as 'Область', district.district as 'Район', undergroundstations.undergroundStation as 'ст. Метро', if(property.buyRent=1,'Продажy','Арендy') as 'Выставлен на' " +
                  "from property " +
                  "left join type on property.type = type.idType " +
                  "left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty " +
                  "left join cities on property.idCity = cities.idCity " +
                  "left join areas on property.idArea = areas.idArea " +
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
            PublicClasses.sql = "select cities.city, areas.area, district.district, undergroundstations.undergroundStation, concat(type.type, ' ', typeproperty.typeProperty), countRoom, isFloor, countFloor,  isLoggia, if(property.buyRent=1,'Продажу','Аренду'), price, concat(surname,' ',left(name,1),'. ',left(lastname,1),'.'), description " +
                "from property left join type on property.type = type.idType " +
                "left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty " +
                "left join cities on property.idCity = cities.idCity " +
                "left join areas on property.idArea = areas.idArea " +
                "left join district on property.idDistrict = district.idDistrict " +
                "left join undergroundstations on property.idUndergroundStation = undergroundstations.idUndergroundStation " +
                "left join owners on property.idOwner = owners.idOwner " +
                "where property.idProperty ="+idProperty;
            if (idProperty > -1)
            {
                comboBox1.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0].ToString();
                comboBox2.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[1].ToString();
                comboBox3.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[2].ToString();
                comboBox4.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[3].ToString();
                comboBox5.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[4].ToString();
                textBox2.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[5].ToString();
                textBox3.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[6].ToString();
                textBox4.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[7].ToString();
                if (Convert.ToBoolean(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[8]) == true) { checkBox1.Checked = true; }
                if (PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[9].ToString() == "Продажу") { radioButton2.Checked = true; }
                else { radioButton1.Checked = true; }
                textBox1.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[10].ToString();
                comboBox6.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[11].ToString();
                richTextBox1.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[12].ToString();
            }
            else
            {
                PublicClasses.sql = PublicClasses.sql.Remove(PublicClasses.sql.IndexOf("where"));
                comboBox1.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[0].ToString();
                comboBox2.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[1].ToString();
                comboBox3.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[2].ToString();
                comboBox4.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[3].ToString();
                comboBox5.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[4].ToString();
                textBox2.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[5].ToString();
                textBox3.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[6].ToString();
                textBox4.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[7].ToString();
                if (Convert.ToBoolean(PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[8]) == true) { checkBox1.Checked = true; }
                if (PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[9].ToString() == "Продажу") { radioButton2.Checked = true; }
                else { radioButton1.Checked = true; }
                textBox1.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[10].ToString();
                comboBox6.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[11].ToString();
                richTextBox1.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[rowIndex].ItemArray[12].ToString();
            }
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
            bool l = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { errorProvider1.SetError(label11, "Поле не должно быть пустым"); l = false; } else { l = true; }
            if (string.IsNullOrWhiteSpace(comboBox5.Text)) { errorProvider1.SetError(comboBox5, "Поле не должно быть пустым"); l = false; } else { l = true; }
            if (string.IsNullOrWhiteSpace(comboBox6.Text)) { errorProvider1.SetError(comboBox6, "Поле не должно быть пустым"); l = false; } else { l = true; }
            if(l)
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
                    PublicClasses.sql = "select * from areas where area='" + comboBox2.Text + "'";
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
                catch(Exception ex) { MessageBox.Show(ex.Message, "Изменение данных недвижимости", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void button3_Click(object sender, EventArgs e) //снятие блокировки с полей 
        {
            PublicClasses.sql = "update property set isRemoveBuyRent=1 where idProperty=" + PublicClasses.selectedRowIndex + "";
            PublicClasses.executeSqlRequest();
            MessageBox.Show("Недвижимость снята с продажи.", "Снятие недвижимости с продажи", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void withdrawFromSaleLoad(object sender, EventArgs e) //снятие с продажи
        {
            button5.Visible = false;
            button6.Visible = false;
            loadFormFields(PublicClasses.selectedRowIndex,PublicClasses.rowIndex);
        }

        private void showOrChangeDetailedDescriptionLoad(object sender, EventArgs e) //изменение данных недвижимости
        {
            loadFormFields(PublicClasses.selectedRowIndex, PublicClasses.rowIndex);
        }

        private void formClose(object sender, EventArgs e) //подробная информация
        {
            loadDataGridView();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PublicClasses.sql = "select idProperty, concat(type.type, ' ', typeproperty.typeProperty) as 'Тип Недвижимости', cities.city as 'Город', areas.area as 'Область', district.district as 'Район', undergroundstations.undergroundStation as 'ст. Метро', if(property.buyRent=1,'Продажy','Арендy') as 'Выставлен на', price " +
                   "from property " +
                   "left join type on property.type = type.idType " +
                   "left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty " +
                   "left join cities on property.idCity = cities.idCity " +
                   "left join areas on property.idArea = areas.idArea " +
                   "left join district on property.idDistrict = district.idDistrict " +
                   "left join undergroundstations on property.idUndergroundStation = undergroundstations.idUndergroundStation where isRemoveBuyRent<>1";
            if (PublicClasses.rowIndex > 0)
            {
                PublicClasses.rowIndex--;
                PublicClasses.selectedRowIndex =Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[PublicClasses.rowIndex].ItemArray[0]);
            }
            loadFormFields(-1, PublicClasses.rowIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PublicClasses.sql = "select idProperty, concat(type.type, ' ', typeproperty.typeProperty) as 'Тип Недвижимости', cities.city as 'Город', areas.area as 'Область', district.district as 'Район', undergroundstations.undergroundStation as 'ст. Метро', if(property.buyRent=1,'Продажy','Арендy') as 'Выставлен на', price " +
                  "from property " +
                  "left join type on property.type = type.idType " +
                  "left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty " +
                  "left join cities on property.idCity = cities.idCity " +
                  "left join areas on property.idArea = areas.idArea " +
                  "left join district on property.idDistrict = district.idDistrict " +
                  "left join undergroundstations on property.idUndergroundStation = undergroundstations.idUndergroundStation where isRemoveBuyRent<>1";
            if (PublicClasses.rowIndex >= 0)
            {
                PublicClasses.rowIndex++;
                PublicClasses.selectedRowIndex = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[PublicClasses.rowIndex].ItemArray[0]);
            }
            loadFormFields(-1, PublicClasses.rowIndex);
        }

    }
}
