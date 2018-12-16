using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class registration : Form
    {
        public string strDbPath = "server=localhost;user=root;password=123;database=snowman_kursovoi;port=3306";
        public registration()
        {
            InitializeComponent();
        }

        private string GetHashString(string s) //функция хеширования пароля
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider csp = new MD5CryptoServiceProvider();
            byte[] byteHash = csp.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHash)
                hash += string.Format("{0:x}", b);
            return hash;
        }

        private void button2_Click(object sender, EventArgs e) //назад
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //регистрация пользователя
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (PublicClasses.idUser == null)
                {
                    PublicClasses.sql = "insert into autorization_datas(login,password,password1) values('" + textBox1.Text + "','" + GetHashString(textBox2.Text) + "','" + textBox2.Text + "')";
                    try
                    {
                        PublicClasses.executeSqlRequest();
                        MessageBox.Show("Регистрация прошла успешно", "Регистрация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Регистрация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else
                {
                    PublicClasses.sql = "update autorization_datas set login='"+textBox1.Text+"',password='"+GetHashString(textBox2.Text)+"', password1='"+textBox2.Text+"' where idUser="+PublicClasses.idUser+"";
                    try
                    {
                        PublicClasses.executeSqlRequest();
                        MessageBox.Show("Регистрация прошла успешно", "Регистрация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Регистрация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "Поле не должно быть пустым");
                errorProvider1.SetError(textBox2, "Поле не должно быть пустым");
            }
        }

        private void registration_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
