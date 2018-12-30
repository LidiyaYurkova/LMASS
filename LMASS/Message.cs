using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMASS
{
    public partial class Message : Form
    {
        public  ArrayList AllFields = new ArrayList();//все до поля
        public ArrayList Mails = new ArrayList();//адреса категории
        //подключение к БД
        SqlConnection ThisConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = LMASS; Integrated Security = True");
              
        string AttachFile = "";//файл вложения
        public Message()
        {
            InitializeComponent();

        }

        private void Message_Load(object sender, EventArgs e)
        {            
            ThisConnection.Open();//открываем соединение
        }

        //выбор категорий
        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            button5.Enabled = false;
            CategoryList.CurrentCategoriesID.Clear();
            Form frm = new CategoryList();
            frm.Show();
            frm.Closing += CategoryListClosing;
            

        }
        //при закрытии сфомы списка категорий
        private void CategoryListClosing(object sender, EventArgs e)
        {
            if (CategoryList.CurrentCategoriesID.Count > 0)
            {
                checkBox1.Checked = true;
                button5.Enabled = true;
            }
        }

        //выборка всех доп полей
        private void GetAllFields()
        {
           
            SqlCommand thisCommand = ThisConnection.CreateCommand();
            for (int i=1; i<11; i++)
            {
                thisCommand.CommandText = "SELECT ColumnName" + (i) + " from Category where ID=" + CategoryList.CurrentCategoriesID[0] + "";
                AllFields.Add("<" + thisCommand.ExecuteScalar().ToString() + ">");
            }

        }

        //загрузка шаблона
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                richTextBox1.LoadFile(dialog.FileName, RichTextBoxStreamType.PlainText);

        }

        //сохранение шаблона
        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "TXT Files|*.txt";

            if (saveFile1.ShowDialog() == DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }


        }

        //выбор доп полей
        private void button5_Click_1(object sender, EventArgs e)
        {
            FieldsList.Fields.Clear();
            FieldsList form = new FieldsList();
            form.Show();          
            form.Closing += FieldsListClosing;  //обработка закрытия формы

        }

        //при закрытии фомы списка полей
        private void FieldsListClosing(object sender, EventArgs e)
        {
            for (int i = 0; i < FieldsList.Fields.Count; i++)
                richTextBox1.Text += FieldsList.Fields[i] + " ";
        }


        //загрузка вложения
        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                AttachFile = dialog.FileName;
        }

        //отправка
        private void button2_Click(object sender, EventArgs e)
        {
            // отправитель - устанавливаем адрес
            MailAddress from = new MailAddress(LMASS.Enter.Login);
            MailAddress to; // кому отправляем
            MailMessage m;// создаем объект сообщения
            SmtpClient smtp;// адрес smtp-сервера                      
            
            SqlCommand[] Command = new SqlCommand[12];//команды для выборки
            for (int i = 0; i < 12; i++)
               Command[i] = ThisConnection.CreateCommand();
                        
            SqlDataReader thisReader;//ридер результатов запроса для перебора адресатов

            //преобразование переноса строки в HTML
            string htmlLetter = richTextBox1.Text;
            htmlLetter = htmlLetter.Replace("\n", "<br>");

            //для выборки
           // string Mail=" ";
                                  
            if (checkBox1.Checked == false) //если не выбрали категорию
            {
                MessageBox.Show("Выберите категорию!","Ошибка");
            }
            
            else
            {
                for (int i = 0; i < CategoryList.CurrentCategoriesID.Count; i++)//цикл по выбранным категориям
                {
                    GetAllFields();//выбираем все доп поля категории
                    //берем адрес
                    Command[0].CommandText = " SELECT Mail FROM Person WHERE CategoryID= " + CategoryList.CurrentCategoriesID[i];
                                       
                    thisReader = Command[0].ExecuteReader();//перебор адресов
                    
                    while (thisReader.Read())//выбираем адреса
                    {
                        Mails.Add(thisReader["Mail"].ToString());
                        Console.Read();
                    }
                    thisReader.Close();// закрываем ридер

                    for (int adr=0; adr < Mails.Count; adr++)// отправка писем
                    {
                        string letter = htmlLetter;//письмо с <br>
                        Command[1].CommandText = "  SELECT FIO FROM Person WHERE Mail= '" + Mails[adr] + "' AND CategoryID='"+ CategoryList.CurrentCategoriesID[i]+"'"; //берем ФИО

                        letter = letter.Replace("<ФИО>", Command[1].ExecuteScalar().ToString());//заменяем <ФИО>
                        letter = letter.Replace("<Адрес>", Mails[adr].ToString());//заменяем <Адрес>


                        for (int j = 2; j < 12; j++)//выбираем данные остальных полей
                        {
                            Command[j].CommandText = "  SELECT p" + (j - 1) + " FROM Person WHERE CategoryID= " + CategoryList.CurrentCategoriesID[i] + " AND Mail= '" + Mails[adr] + "'";
                            letter = letter.Replace(AllFields[j - 2].ToString(), Command[j].ExecuteScalar().ToString());//заменяем <>
                        }
                        
                        to = new MailAddress(Mails[adr].ToString());
                        m = new MailMessage(from, to);                        
                        if (AttachFile.Length > 0)//вложение, если есть
                            m.Attachments.Add(new Attachment(AttachFile));
                        m.Subject = textBox1.Text;   // тема письма                        
                        m.Body = "<h2>" + letter + "</h2>";// текст письма                        
                        m.IsBodyHtml = true;// письмо представляет код html                       
                        smtp = new SmtpClient("smtp." + LMASS.Enter.Service, 587); // адрес smtp-сервера и порт, с которого будем отправлять письмо
                        smtp.Credentials = new NetworkCredential(LMASS.Enter.Login, LMASS.Enter.Password);// логин и пароль
                        smtp.EnableSsl = true;
                        smtp.Send(m);

                    }
                                        
                }

                MessageBox.Show("Готово!","Отправка");
            }
           // ThisConnection.Close();
        }    

        
    }
}
