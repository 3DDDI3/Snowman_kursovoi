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
    public partial class addProperty : Form
    {
        public addProperty()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
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
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox5.Text) || string.IsNullOrEmpty(comboBox6.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(comboBox5, "Поле не должно быть пустым");
                errorProvider1.SetError(comboBox6, "Поле не должно быть пустым");
                errorProvider1.SetError(label11, "Поле не должно быть пустым");
            }
            else
            {
                PublicClasses.sql = "select count(idProperty) from property";
                int idProperty = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0])+1;
                string columns = "idProperty,", values = idProperty+",";
                if (comboBox1.Text != "")
                {
                    PublicClasses.sql = "select * from cities where city='" + comboBox1.Text + "'";
                    int idCity = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    columns += "idCity,";
                    values += idCity + ",";
                }
                if (comboBox2.Text != "")
                {
                    PublicClasses.sql = "select * from area where Area='" + comboBox2.Text + "'";
                    int idArea = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    columns += "idArea,";
                    values += idArea + ",";
                }
                if (comboBox3.Text != "")
                {
                    PublicClasses.sql = "select * from district where district='" + comboBox3.Text + "'";
                    int idDistrict = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    columns += "idDistrict,";
                    values += idDistrict + ",";
                }
                if (comboBox4.Text != "")
                {
                    PublicClasses.sql = "select * from undergroundstations where undergroundStation='" + comboBox4.Text + "'";
                    int idUndergroundStation = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    columns += "idUndergroundStation,";
                    values += idUndergroundStation + ",";
                }
                if (comboBox5.Text != "")
                {
                    PublicClasses.sql = "select idType, concat(type.type,' ',typeproperty.typeProperty) from type left join typeproperty on type.idTypeProperty = typeproperty.idTypeProperty where concat(type.type,' ',typeproperty.typeProperty)='" + comboBox5.Text + "'";
                    int idType = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    columns += "type,";
                    values += idType + ",";
                }
                if (comboBox6.Text != "")
                {
                    PublicClasses.sql = "select * from owners where concat(surname,' ',left(name,1),'. ',left(lastname,1),'.')='" + comboBox6.Text + "'";
                    int idOwner = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    columns += "idOwner,";
                    values += idOwner + ",";
                }
                if (textBox2.Text != "") { columns += "countRoom,"; values += textBox2.Text + ","; }
                if (textBox3.Text != "") { columns += "isFloor,"; values += textBox3.Text + ","; }
                if (textBox4.Text != "") { columns += "countFloor,"; values += textBox1.Text + ","; }
                if (textBox1.Text != "") { columns += "price,"; values += textBox1.Text + ","; }
                if (checkBox1.Checked) { columns += "isLoggia,"; values += "1,"; }
                if (radioButton1.Checked) { columns += "buyRent,"; values += "0,"; }
                if (radioButton2.Checked) { columns += "buyRent,"; values += "1,"; }
                PublicClasses.sql = "insert into property(" + columns.Remove(columns.Length - 1) +",isRemoveBuyRent"+") values(" + values.Remove(values.Length - 1) +",0"+ ")";
                MessageBox.Show(PublicClasses.sql);
                PublicClasses.executeSqlRequest();
            }
        }

    }
}
