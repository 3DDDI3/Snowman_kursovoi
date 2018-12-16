using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class enter : Form
    {
        public string captcha, sql, idUser;
        public enter()
        {
            InitializeComponent();
        }

        public string GetHashString(string s) //функция хеширования пароля
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider csp = new MD5CryptoServiceProvider();
            byte[] byteHash = csp.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHash)
                hash += string.Format("{0:x}", b);
            return hash;
        }

        public int i = 0;

        private void Form1_Load(object sender, EventArgs e) //загрузка формы
        {
            textBox2.UseSystemPasswordChar = true;
            string captcha_str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Boolean l = false;
            Random rand = new Random();
            while (!l)
            {
                captcha = "";
                for (int i = 0; i < 4; i++)
                {
                    captcha += captcha_str[rand.Next(captcha_str.Length)];
                }
                if (Regex.IsMatch(captcha, "[A - Z]") && Regex.IsMatch(captcha, "[a - z]") && Regex.IsMatch(captcha, @"\d"))
                { label3.Text = captcha; l = true; }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //открытие окна регистрация
        {
            registration form3 = new registration();
            form3.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e) //обновление капчи
        {
            string captcha_str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Boolean l = false;
            Random rand = new Random();
            while (!l)
            {
                captcha = "";
                for (int i = 0; i < 4; i++)
                {
                    captcha += captcha_str[rand.Next(captcha_str.Length)];
                }
                if (Regex.IsMatch(captcha, "[A - Z]") && Regex.IsMatch(captcha, "[a - z]") && Regex.IsMatch(captcha, @"\d"))
                { label3.Text = captcha; l = true; }
                textBox3.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                textBox2.UseSystemPasswordChar = false;
                pictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources.icons8_invisible_50;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                pictureBox1.BackgroundImage=WindowsFormsApplication1.Properties.Resources.icons8_eye_50;
                i = 0;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (PublicClasses.checkConnection() == 0)
            {
                var result=MessageBox.Show("Ой, что-то пошло не так. Возникли ошибки с подключением к базе. Попробуйте снова подключиться к базе", "Соединение с базой",MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    dbSettings form5 = new dbSettings();
                    form5.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //вход в ситему
        {
            property form2 = new property();
            try
            {
                PublicClasses.sql = "select * from autorization_datas where login='" + textBox1.Text + "' and password='" + GetHashString(textBox2.Text) + "';";
                PublicClasses.idUser = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[0].ToString();
                PublicClasses.UserLogin = PublicClasses.executeSqlRequest().Tables[0].Rows[0].ItemArray[1].ToString();
                if (PublicClasses.executeSqlRequest().Tables[0].Rows.Count == 0 /*&& captcha!=textBox3.Text*/)
                { MessageBox.Show("Ой что-то пошло не так. Попробуйте заполнить поля снова.", "Окно предупреждения", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    this.Hide();
                     form2.Show();
                }
                if (checkBox1.Checked) { PublicClasses.writeToFileUser(); }
            }
            catch (Exception ex) { MessageBox.Show("Неправильные пароль или логин.", "Вход в систему", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
