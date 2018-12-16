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
    public partial class dbSettings : Form
    {
        public dbSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PublicClasses.server = textBox1.Text;
            PublicClasses.user = textBox2.Text;
            PublicClasses.password = textBox3.Text;
            PublicClasses.db = textBox4.Text;
            PublicClasses.port = textBox5.Text;
            PublicClasses.setDbPathToFile();
            if (PublicClasses.checkConnection() == 0)
            {
                MessageBox.Show("Не удалось соединиться с базой.", "Соединение с базой", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Успешное соединение с базой", "Соединение с базой", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PublicClasses.checkConnection() == 0)
            {
               MessageBox.Show("Ой, что-то пошло не так. Возникли ошибки с подключением к базе. Попробуйте снова подключиться к базе", "Соединение с базой", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { this.Close(); }
        }
    }
}
