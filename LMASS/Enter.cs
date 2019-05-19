using System;
using System.Windows.Forms;

namespace LMASS
{    
    public partial class Enter : Form
    {
        public static string Login,Password,Service;
        public Enter()
        {
            InitializeComponent();
        }
        private void Enter_Load(object sender, EventArgs e)
        {
            ActiveControl = lblWelcome;
        }
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbLogin.Text != "Email" && tbPassword.Text != "" && tbPassword.Text != "Пароль")
                btnOk.Enabled = true;
        }
        private void tbLogin_Enter(object sender, EventArgs e)
        {
            if (tbLogin.Text == "Email")
            {
                tbLogin.Text = "";
            }
        }
        private void tbLogin_Leave(object sender, EventArgs e)
        {
            if (tbLogin.Text == "")
            {
                tbLogin.Text = "Email";
                btnOk.Enabled = false;
            }
        }
        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Пароль")
            {
                tbPassword.Text = "";
                tbPassword.PasswordChar = '*';
            }
        }
        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.PasswordChar = '\0';
                tbPassword.Text = "Пароль";
                btnOk.Enabled = false;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            //запоминаем логин, пароль и сервис
            Login = tbLogin.Text;
            Password = tbPassword.Text;
            Service = Login.Substring(Login.IndexOf('@') + 1);
            if (Service == "inbox.ru" || Service == "list.ru" || Service == "bk.ru")
            {
                Service = "mail.ru";
            }
            Form frm = new Menu();
            this.Hide();
            frm.Show();
            frm.Closing += MenuClosing;        
        }
        //при закрытии фомы Menu
        private void MenuClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
