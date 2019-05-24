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
            ActiveControl = lblWelcome;//снимаем фокус с фолей ввода
        }
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbLogin.Text != "Email" && tbPassword.Text != "" && tbPassword.Text != "Пароль")
                btnOk.Enabled = true;//если введены все данные, кнопка входа доступна
        }
        private void tbLogin_Enter(object sender, EventArgs e)
        {
            if (tbLogin.Text == "Email")
            {
                tbLogin.Text = "";//при клике на поле убираем подсказку
            }
        }
        private void tbLogin_Leave(object sender, EventArgs e)
        {
            if (tbLogin.Text == "")
            {
                tbLogin.Text = "Email";
                btnOk.Enabled = false;//если адрес пустой, вернем додсказку и заблокируем кнопку входа
            }
        }
        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Пароль")
            {
                tbPassword.Text = "";
                tbPassword.PasswordChar = '*';//убираем подсказку при клике
            }
        }
        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.PasswordChar = '\0';
                tbPassword.Text = "Пароль";
                btnOk.Enabled = false;//если пароль пустой, вернем подсказку и заблокируем кнопку
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
                Service = "mail.ru";//если сервис mail.ru но с другим именем, запомним нужный
            }
            Form frm = new Menu();
            this.Hide();//скрываем окно
            frm.Show();//отображаем меню
            frm.Closing += MenuClosing;//обработчик закрытия меню   
        }
        //при закрытии фомы Menu - выход
        private void MenuClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
