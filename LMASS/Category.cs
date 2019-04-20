using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMASS
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            this.CategoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

        }

        private void Category_Load(object sender, EventArgs e)
        {
            this.CategoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.personTableAdapter.Fill(this.categoryDataSet.Person, Categories.CatID);
            this.CategoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           
       
            //для ID категории по умолчанию(добавление элементов иначе не работает)
            CategoryGridView.DefaultValuesNeeded += new DataGridViewRowEventHandler(CategoryGridView_DefaultValuesNeeded);

            //названия колонок
            SqlConnection ThisConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LMASSDatabase.mdf;Integrated Security=True");
            ThisConnection.Open();
            SqlCommand SelectFields = ThisConnection.CreateCommand();
            
            for (int i=1; i<11; i++)//выбираем и присваиваем новые названия
            {
                SelectFields.CommandText = "SELECT ColumnName"+i+" from Category where ID=" + Categories.CatID + "";
                if (SelectFields.ExecuteScalar().ToString() != "")
                    CategoryGridView.Columns[i + 3].HeaderText = SelectFields.ExecuteScalar().ToString();
                else CategoryGridView.Columns[i + 3].Visible = false;
            }
            
        }

        //для ID категории по умолчанию(добавление элементов иначе не работает)
        private void CategoryGridView_DefaultValuesNeeded(object sender,System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            for (int i = 0; i < CategoryGridView.RowCount; i++)
                CategoryGridView.Rows[i].Cells[0].Value = Categories.CatID;
          
        }

  
        //сохранить
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.personBindingSource.EndEdit();
                this.personTableAdapter.Update(this.categoryDataSet.Person);
                MessageBox.Show("Изменения в базе данных выполнены!",
                  "Уведомление о результатах", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Изменения в базе данных выполнить не удалось! Смотрите подробности в LMASS.log",
                  "Уведомление о результатах", MessageBoxButtons.OK);
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

        //Импорт
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ThisConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LMASSDatabase.mdf;Integrated Security=True");
                ThisConnection.Open();
                SqlCommand Import = ThisConnection.CreateCommand();

                if (ImportFileDialog.ShowDialog() == DialogResult.OK) //выбор файла
                {

                    using (StreamReader sr = new StreamReader(ImportFileDialog.FileName))//берем путь к файлу
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null) //читаем строки
                        {
                            String[] words = line.Split(new char[] { ',', ';' });//делим на слова                       
                            String[] p = new string[11]; //массив данных доп полей категории
                            string f, m; //ФИО и Mail                        
                            f = words[0];//первое всегда ФИО                        
                            m = words[1];//второй mail
                            for (int i = 2; i < words.Length; i++)  //остальные поля заносим в переменные р1-р10
                                p[i - 1] = words[i];

                            if (words.Length < 12) //если заполнены не все доп поля -> заполняем их пустой строкой                           
                                for (int i = words.Length - 1; i <= 10; i++) //начинаем с певрого пустого
                                    p[i] = "";

                            //вставляем данные
                            Import.CommandText = "INSERT INTO Person (FIO, Email,CategoryID, p1,p2,p3,p4,p5,p6,p7,p8,p9,p10) values ('" + f + "', '" + m + "', '" + Categories.CatID + "', '" + p[1] + "','" + p[2] + "','" + p[3] + "','" + p[4] + "','" + p[5] + "','" + p[6] + "','" + p[7] + "','" + p[8] + "','" + p[9] + "','" + p[10] + "')";
                            Import.ExecuteScalar();

                        }
                        MessageBox.Show("Импорт выолнен!");
                        ThisConnection.Close();
                        //перезагрузка таблицы
                        this.personTableAdapter.Fill(this.categoryDataSet.Person, Categories.CatID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Изменения в базе данных выполнить не удалось!",
                  "Уведомление о результатах", MessageBoxButtons.OK);
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
