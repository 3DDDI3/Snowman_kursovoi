using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class addPerson : Form
    {
        public addPerson(string formAction)
        {
            InitializeComponent();

            if(formAction=="addPerson") 
            {
                this.button1.Click += addNewPerson;
                this.button2.Click += closeForm;
                this.button3.Text = "Добавить фото";
            }
            else 
            {
                executeSqlRequest();
                this.Text = "Изменение данных сотрудника";
                this.button1.Text = "Внести изменения";
                this.button1.Click += changePersonsData;
                this.button2.Click += closeForm;
            }
        }

        public DateTime date =new DateTime();
        public OpenFileDialog opndlg = new OpenFileDialog();

        private void executeSqlRequest() //пользовательская функция 
        {
            PublicClasses.sql = "select special from specials";
            comboBox1.Items.AddRange(PublicClasses.loadStringsToCmbbox());
            if (this.Text!= "Добавление сотрудника"){date = DateTime.Now;}
            else
            {
                PublicClasses.sql = "select surname, name, lastname, adres, phone, special, photo from persons left join specials on persons.idSpecial=specials.idSpecial where idPerson=" + PublicClasses.selectedRowIndex + "";
                textBox3.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0].ToString();
                textBox4.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[1].ToString();
                textBox5.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[2].ToString();
                textBox6.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[3].ToString();
                maskedTextBox1.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[4].ToString();
                comboBox1.Text = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[5].ToString();
                string photoPath = System.IO.Path.Combine(Application.StartupPath, @"Photos\"+PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[6]+"");
                pictureBox1.Load(photoPath);
            }
        }

        private void addNewPerson(object sender, EventArgs e)
        {
            date = DateTime.Now;
            errorProvider1.Clear();
            bool l;
            int idSpecial;
            string columnName="", values="";
            if (string.IsNullOrEmpty(textBox3.Text)) { errorProvider1.SetError(textBox3, "Поле не должно быть пустым."); l = false; } else { l = true; }
            if (string.IsNullOrEmpty(textBox4.Text)) { errorProvider1.SetError(textBox4, "Поле не должно быть пустым."); l = false; } else { l = true; }
            if (string.IsNullOrEmpty(textBox5.Text)) { errorProvider1.SetError(textBox5, "Поле не должно быть пустым."); l = false; } else { l = true; }
            if (string.IsNullOrEmpty(comboBox1.Text)) { errorProvider1.SetError(comboBox1, "Поле не должно быть пустым."); l = false; } else { l = true; }
            if (l)
            {
                PublicClasses.sql = "select max(idUser) from autorization_datas";
                PublicClasses.idUser =(Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0])+1).ToString();
                if (textBox3.Text != "") { columnName += "surname,"; values += "'" + textBox3.Text + "',"; }
                if (textBox4.Text != "") { columnName += "name,"; values += "'" + textBox4.Text + "',"; }
                if (textBox5.Text != "") { columnName += "lastname,"; values += "'" + textBox5.Text + "',"; }
                if (textBox6.Text != "") { columnName += "adres,"; values += "'" + textBox6.Text + "',"; }
                if (maskedTextBox1.MaskFull) { columnName += "phone,"; values += "'" + maskedTextBox1.Text + "',"; }
                if (opndlg.FileName != null) { columnName += "photo,"; values += "'" + opndlg.FileName.Substring(opndlg.FileName.LastIndexOf(@"\") + 1) + "',"; }
                if (comboBox1.Text != "")
                {
                    PublicClasses.sql = "select idSpecial from specials where special='" + comboBox1.Text + "'";
                    idSpecial = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    columnName += "idSpecial,"; values += idSpecial + ",";
                }
                if (columnName != "" && values != "") //добавление нового сторудникa
                {
                    date = date.Date;
                    try
                    {
                        PublicClasses.sql = "insert into persons(" + columnName.Remove(columnName.Length - 1) + ", dateReceipt, isDeleted) values(" + values.Remove(values.Length - 1) + ",'" + date.ToString("yyyy-MM-dd") + "', 0)";
                        MessageBox.Show(PublicClasses.sql);
                        PublicClasses.executeSqlRequest();
                        var result=MessageBox.Show("Сотрудник успешно добавлен. Создать аккаунт данному сотруднику?", "Добавление сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            PublicClasses.sql = "insert into autorization_datas(password1) values(' ')";
                            PublicClasses.executeSqlRequest();
                            PublicClasses.sql = "select idPerson from persons order by 1 desc limit 1";
                            int idPerson=Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                            PublicClasses.sql = "update persons set idUser=" + PublicClasses.idUser + " where idPerson=" + idPerson + "";
                            MessageBox.Show(PublicClasses.sql);
                            PublicClasses.executeSqlRequest();
                            registration rgstr = new registration();
                            rgstr.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Окно предупреждения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void changePersonsData(object sender, EventArgs e)
        {
            string set = "";
            int idSpecial;
            bool l;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBox3.Text)) { errorProvider1.SetError(textBox3, "Поле не должно быть пустым."); l = false; } else { l = true; }
            if (string.IsNullOrEmpty(textBox4.Text)) { errorProvider1.SetError(textBox4, "Поле не должно быть пустым."); l = false; } else { l = true; }
            if (string.IsNullOrEmpty(textBox5.Text)) { errorProvider1.SetError(textBox5, "Поле не должно быть пустым."); l = false; } else { l = true; }
            if (string.IsNullOrEmpty(comboBox1.Text)) { errorProvider1.SetError(comboBox1, "Поле не должно быть пустым."); l = false; } else { l = true; }
            if (l)
            {

                if (opndlg.FileName != null) { set += "photo='" + opndlg.FileName.Substring(opndlg.FileName.LastIndexOf(@"\")+1) + "',"; }
                if (textBox3.Text != "") { set += "surname='" + textBox3.Text + "',"; }
                if (textBox4.Text != "") { set += "name='" + textBox4.Text + "',"; }
                if (textBox5.Text != "") { set += "lastname='" + textBox5.Text + "',"; }
                if (textBox6.Text != "") { set += "adres='" + textBox6.Text + "',"; }
                if (maskedTextBox1.MaskFull) { set += "phone='" + maskedTextBox1.Text + "',"; }
                if (comboBox1.Text != "")
                {
                    PublicClasses.sql = "select idSpecial from specials where special='" + comboBox1.Text + "'";
                    idSpecial = Convert.ToInt16(PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0]);
                    set += "idSpecial='" + idSpecial + "',";
                }
                if (set != "") //изменение данных сотрудника
                {
                    try
                    {
                        MessageBox.Show(set);
                        PublicClasses.sql = "update persons set " + set.Remove(set.Length - 1) + " where idPerson=" + PublicClasses.selectedRowIndex + "";
                        MessageBox.Show(PublicClasses.sql);
                        PublicClasses.executeSqlRequest();
                        MessageBox.Show("Данные успешно изменены", "Изменение данных сотрудника", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Окно предупреждения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void closeForm(object sender, EventArgs e)
        {
            personal personal = new personal();
            personal.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opndlg.Filter = "All image files(*.jpg);(*.png);(*.tiff);(*.tif);(*.bmp)|*.jpg;*.png;*.tiff;*.tif;*.bmp|JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|TIFF files (*.tiff)|*.tiff|TIF files (*.tif)|*.tif|BMP files (*.bmp)|*.bmp";
            opndlg.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, "Photos");
            if (opndlg.ShowDialog() == DialogResult.OK) { pictureBox1.Load(opndlg.FileName); }
        }
    }
}
