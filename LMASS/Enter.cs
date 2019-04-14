using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            tbPassword.PasswordChar = '*';
            
        }

        private void Enter_Load(object sender, EventArgs e)
        {

        }
        //если введены все данные - кнопка активна
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbLogin.Text.Length > 0)
            btnOk.Enabled = true; 
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //запоминаем логин, пароль и сервис
                Login = tbLogin.Text;
                Password = tbPassword.Text;
                Service = Login.Substring(Login.IndexOf('@') + 1);

                //// отправитель - устанавливаем адрес и отображаемое в письме имя
                //MailAddress from = new MailAddress(Login);
                //// кому отправляем
                //MailAddress to = new MailAddress(Login);
                //// создаем объект сообщения
                //MailMessage m = new MailMessage(from, to);
                //// адрес smtp-сервера и порт, с которого будем отправлять письмо
                //SmtpClient smtp = new SmtpClient("smtp." + Service, 587);
                //// логин и пароль
                //smtp.Credentials = new NetworkCredential(Login, Password);
                //smtp.EnableSsl = true;
                //smtp.Send(m);
                //Console.Read();
                Form frm = new Menu();
                this.Hide();
                frm.Show();
                frm.Closing += MenuClosing;
     
        //}
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Не удалось войти в почтовый ящик. Проверьту логин, пароль, наличие доступа к ящику сторонними приложениями.");
        //    }

        }
        
        //при закрытии фомы Menu
        private void MenuClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
