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
    public partial class mainUser : Form
    {
        public mainUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            property buyProperty = new property();
            buyProperty.radioButton2.Checked = true;
            this.Close();
            buyProperty.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            property buyProperty = new property();
            buyProperty.radioButton1.Checked = true;
            this.Close();
            buyProperty.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enter enter = new enter();
            this.Close();
            enter.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            enter enter = new enter();
            enter.Close();
        }
    }
}
