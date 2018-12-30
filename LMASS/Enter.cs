using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMASS
{
    
    public partial class Enter : Form
    {
        public static string Login,Password,Service;
    
        public Enter()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            button1.Enabled = false;
        }

        private void Enter_Load(object sender, EventArgs e)
        {

        }
        //если введены все данные - кнопка активна
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            { button1.Enabled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //запоминаем логин, пароль и сервис
            Login = textBox1.Text;
            Password = textBox2.Text;
            Service = Login.Substring(Login.IndexOf('@') + 1);
            Form frm = new Menu();
            this.Hide();
            frm.Show();
      
        }
    }
}
