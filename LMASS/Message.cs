using System;
using System.Collections;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace LMASS
{
    public partial class Message : Form
    {
        static object locker = new object();
        public int CurrentCategoryID;
        public ArrayList AllFields = new ArrayList();//все доп поля
        public ArrayList Emails = new ArrayList();//адреса категории
        public string[] fileNames;// вложения
        string AttachFile = "";//файл вложения
        string DatabasePath = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LMASSDatabase.mdf;Max Pool Size=5000;Integrated Security=True";
        bool allIsRight = true;
        public Message()
        {
            InitializeComponent();

        }
        private void Message_Load(object sender, EventArgs e)
        {
           
        }
        //выбор категорий
        private void btnChooseCategory_Click(object sender, EventArgs e)
        {
            lblCategories.Text = "";
            btnSend.Enabled = false;
            btnAddValues.Enabled = false;
            Form frm = new CategoryList();
            frm.Show();
            frm.Closing += CategoryListClosing;
        }
        //при закрытии фомы списка категорий
        private void CategoryListClosing(object sender, EventArgs e)
        {
            if (CategoryList.CurrentCategoriesID.Count > 0)
            {
                lblCategories.Text += CategoryList.CurrentCategoriesID.Count + ": ";
                for (int i = 0; i < CategoryList.CurrentCategoriesID.Count; i++)
                    lblCategories.Text += CategoryList.CurrentCategoriesName[i] + ", ";
                btnAddValues.Enabled = true;
                btnSend.Enabled = true;
            }
        }

        //выборка всех доп полей
        private void GetAllFields()
        {
            SqlConnection ThisConnection = new SqlConnection(DatabasePath);
            ThisConnection.Open();
            SqlCommand thisCommand = ThisConnection.CreateCommand();
            for (int i = 1; i < 11; i++)
            {
                thisCommand.CommandText = "SELECT ColumnName" + (i) + " from Category where ID=" + CategoryList.CurrentCategoriesID[0] + "";
                AllFields.Add("<" + thisCommand.ExecuteScalar().ToString() + ">");
            }
            ThisConnection.Close();
        }

        //загрузка шаблона
        private void btnGetTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtbLetter.LoadFile(dialog.FileName, RichTextBoxStreamType.PlainText);

        }

        //сохранение шаблона
        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.txt";
            saveFile.Filter = "TXT Files|*.txt";

            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                rtbLetter.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
            }


        }

        //выбор доп полей
        private void btnAddValues_Click(object sender, EventArgs e)
        {
            FieldsList form = new FieldsList();
            form.Show();
            form.Closing += FieldsListClosing;  //обработка закрытия формы

        }

        //при закрытии фомы списка полей
        private void FieldsListClosing(object sender, EventArgs e)
        {
            for (int i = 0; i < FieldsList.SelectedFields.Count; i++)
                rtbLetter.Text += FieldsList.SelectedFields[i] + " ";
        }


        //загрузка вложения
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            lblFiles.Text = "";
            if (TemplateFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileNames = TemplateFileDialog.FileNames;
                lblFiles.Text += fileNames.Length + ": ";
                for (int i = 0; i< fileNames.Length;i++)
                   lblFiles.Text += Path.GetFileNameWithoutExtension(fileNames[i])+", ";
            }
        }



        //отправка
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                AllFields.Clear();
                Emails.Clear();

                lblSending.Visible = true;
                btnSend.Enabled = false;

                SqlConnection ThisConnection = new SqlConnection(DatabasePath);
                ThisConnection.Open();
                Thread masThread;
                SqlCommand SelectEmails = new SqlCommand();
                SelectEmails = ThisConnection.CreateCommand();
                SqlDataReader thisReader;//ридер результатов запроса для перебора адресатов

                GetAllFields();//выбираем все доп поля категории
                for (int i = 0; i < CategoryList.CurrentCategoriesID.Count; i++)//цикл по выбранным категориям
                {                      
                    SelectEmails.CommandText = "SELECT Email FROM Person WHERE CategoryID= " + CategoryList.CurrentCategoriesID[i];
                    CurrentCategoryID = Convert.ToInt32(CategoryList.CurrentCategoriesID[i]);
                    thisReader = SelectEmails.ExecuteReader();//перебор адресов

                    while (thisReader.Read())//выбираем адреса
                    {
                        Emails.Add(thisReader["Email"].ToString());
                    }
                    thisReader.Close();
                    ThisConnection.Close();
                    string htmlLetter = rtbLetter.Text;
                    letter = htmlLetter.Replace("\n", "<br>");
                   
                    ArrayList Threads = new ArrayList();//все до поля
                    int threadsNum = 0;
                    int msgNum = 10;                  

                    if ((Emails.Count % msgNum) > 0)//если кол-во адресов в списке IPs не кратно кол-ву адресов для проверки одним потоком
                        threadsNum = Emails.Count / msgNum + 1;//то кол-во потоков = кол-во адресов в списке / кол-во адресов для проверки одним потоком +1
                                                                //т.е. если у нас 11 адресов, а один поток считет по 10, мы ищем остаток от деления первого на второе, если остаток есть, значит дужно на один потоко больше чем деление на цело
                    else threadsNum = Emails.Count / msgNum;

                    for (int j = 0; j < threadsNum; j++)//после того, как мы определились с количеством потоков, в цикле создадим и запустим их.
                    {
                        Interval interval = new Interval();//создаем экземпляр структуры, которая содержит в себе необходимые данные для проверки (см. описание в   struct Interval)
                        interval.from = msgNum * j;//заносим индекс первого адреса для проверки текущим потоком.
                                                        //Вычисляется он так: у нас есть количество адресов для проверки одним потоком, его мы умножим на индекс i и получим помер адреса в списке для проверки.
                        interval.num = msgNum;//кол-во адресов для проверки одним потоком
                        if (j == threadsNum - 1 && (Emails.Count % msgNum) > 0)//если мы создаём последний поток и остались свободные адреса (остаток од деления при вычислнении кол-ва потоков)
                            interval.num = Emails.Count % msgNum;//то кол-во адресов для проверки = остатку

                        masThread = new Thread(sending);//инициализация потока с вызовом функции провекри
                        masThread.Start(interval);//старт потока с передачей адгумента, в котором содержится индекс первогопроверяемого потоком адреса и кол-во адресов для проверки
                        Threads.Add(masThread);//добавление потока в список потоков

                    }
                    foreach (Thread thread in Threads)//перебирая потоки в списке потоков
                        {
                            thread.Join();//присоединяем каждый поток, т.е. основной поток программы будет ждать окончание работы всех порождённых присоединённых потоков.
                                            //это нужно для корректной работы приложения (см. подробнее в Main)
                        }
                }
                lblSending.Visible = false;
                btnSend.Enabled = true;   
                if(allIsRight) MessageBox.Show("Готово!", "Отправка");
                else MessageBox.Show("Произошла ошибка. Смотрите подробности в файле LMASS.log.", "Отправка");
            }
            catch (Exception ex)
            {
                allIsRight = false;
                FileStream f1;//инициализируем файл.
                string path = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase.Replace("LMASS.exe", "")).LocalPath; //вычисляем путь лог файла (строка)
                //получаем директорию, в которой хранится exe файл, адаптируем её название (удаляем название exe и делаем путь логическим).
                f1 = new FileStream(path + "LMASS.log", FileMode.Append);//находим файл лога, если его нет - создаём
                StreamWriter sw = new StreamWriter(f1);//создадим объект StreamWriter для записи данных в файл
                sw.WriteLine(DateTime.Now.ToString() + " : " + ex.ToString());//запишем в лог дату, время и наше сообщение
                sw.Close();// завершаем запись
                f1.Dispose();// освобождаем файл
            }

        }
        struct Interval
        {
            public int from;
            public int num;
        }
        string letter;
         private  void sending(object context)
        {
            try
            {
                using (SqlConnection ThisConnection = new SqlConnection(DatabasePath))
                {
                    ThisConnection.Open();

                    // отправитель - устанавливаем адрес
                    MailAddress from = new MailAddress(LMASS.Enter.Login);
                    MailAddress to; // кому отправляем
                    MailMessage m;// создаем объект сообщения
                    SmtpClient smtp;// адрес smtp-сервера      
                    SqlCommand Command = new SqlCommand();//команды для выборки
                    Command = ThisConnection.CreateCommand();
                    SqlDataReader thisReader;//ридер результатов запроса для перебора адресатов


                    Interval interval = (Interval)context;
                    int first = interval.from;
                    int last = first + interval.num;

                    for (int i = first; i < last; i++)
                    {
                        Command.CommandText = "  SELECT FIO, p1,p2,p3,p4,p5,p6,p7,p8,p9,p10 FROM Person WHERE Email= '" + Emails[i] + "' AND CategoryID='" + CurrentCategoryID + "'"; //
                        thisReader = Command.ExecuteReader();
                        thisReader.Read();
                        string currentLetter=letter;
                        currentLetter = currentLetter.Replace("<ФИО>", thisReader["FIO"].ToString());//заменяем <ФИО>
                        currentLetter = currentLetter.Replace("<Адрес>", Emails[i].ToString());//заменяем <Адрес>
                        string x = thisReader["p" + (0 + 1)].ToString();
                        for (int j = 0; j < 10; j++)
                            currentLetter = currentLetter.Replace(AllFields[j].ToString(), thisReader["p" + (j + 1)].ToString());//заменяем <>


                        to = new MailAddress(Emails[i].ToString());
                        m = new MailMessage(from, to);

                        if (fileNames != null)//вложение, если есть
                            for (int f = 0; f < fileNames.Length; f++)//перебираем файлы
                            {
                                AttachFile = fileNames[f];
                                m.Attachments.Add(new Attachment(AttachFile));//добавляем их в письмо
                            }
                        m.Subject = tbTheme.Text;   // тема письма                        
                        m.Body = "<h2>" + currentLetter + "</h2>";// текст письма                        
                        m.IsBodyHtml = true;// письмо представляет код html                       
                        smtp = new SmtpClient("smtp." + LMASS.Enter.Service, 587); // адрес smtp-сервера и порт, с которого будем отправлять письмо
                        smtp.Credentials = new NetworkCredential(LMASS.Enter.Login, LMASS.Enter.Password);// логин и пароль
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.EnableSsl = true;
                        smtp.Send(m);
                        thisReader.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                lock (locker)
                {
                    allIsRight = false;
                    FileStream f1;//инициализируем файл.
                    string path = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase.Replace("LMASS.exe", "")).LocalPath; //вычисляем путь лог файла (строка)
                                                                                                                                          //получаем директорию, в которой хранится exe файл, адаптируем её название (удаляем название exe и делаем путь логическим).
                    f1 = new FileStream(path + "LMASS.log", FileMode.Append);//находим файл лога, если его нет - создаём
                    StreamWriter sw = new StreamWriter(f1);//создадим объект StreamWriter для записи данных в файл
                    sw.WriteLine(DateTime.Now.ToString() + " : " + ex.ToString());//запишем в лог дату, время и наше сообщение
                    sw.Close();// завершаем запись
                    f1.Dispose();// освобождаем файл


                }
            }
        }
              
    }
    
}
