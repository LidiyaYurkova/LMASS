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
        }

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "categoryDataSet.Person". При необходимости она может быть перемещена или удалена.
            this.personTableAdapter.Fill(this.categoryDataSet.Person, Categories.CatID);

          
            //для ID категории по умолчанию(добавление элементов иначе не работает)
            dataGridView1.DefaultValuesNeeded += new DataGridViewRowEventHandler(dataGridView1_DefaultValuesNeeded);

            //название колонок
            SqlConnection ThisConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = LMASS; Integrated Security = True");
            ThisConnection.Open();
            SqlCommand thisCommand = ThisConnection.CreateCommand();
            
            for (int i=1; i<11; i++)//выбираем и присваиваем новые названия
            {
                thisCommand.CommandText = "SELECT ColumnName"+i+" from Category where ID=" + Categories.CatID + "";
                
                dataGridView1.Columns[i+3].HeaderText = thisCommand.ExecuteScalar().ToString();
            }
            
        }

        //для ID категории по умолчанию(добавление элементов иначе не работает)

        private void dataGridView1_DefaultValuesNeeded(object sender,System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
                dataGridView1.Rows[i].Cells[0].Value = Categories.CatID;
          
        }

  
        //сохранить
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.personBindingSource.EndEdit();
                this.personTableAdapter.Update(this.categoryDataSet.Person);
                MessageBox.Show("Изменения в базе данных выполнены!",
                  "Уведомление о результатах", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Изменения в базе данных выполнить не удалось!",
                  "Уведомление о результатах", MessageBoxButtons.OK);
            }
        }

        //Импорт
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection ThisConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = LMASS; Integrated Security = True");
            ThisConnection.Open();
            SqlCommand thisCommand = ThisConnection.CreateCommand();

            if (openFileDialog1.ShowDialog() == DialogResult.OK) //выбор файла
            {

                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))//берем путь к файлу
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
                        thisCommand.CommandText = "INSERT INTO Person (FIO, Mail,CategoryID, p1,p2,p3,p4,p5,p6,p7,p8,p9,p10) values ('" + f + "', '" + m + "', '" + Categories.CatID + "', '" + p[1] + "','" + p[2] + "','" + p[3] + "','" + p[4] + "','" + p[5] + "','" + p[6] + "','" + p[7] + "','" + p[8] + "','" + p[9] + "','" + p[10] + "')";
                        thisCommand.ExecuteScalar();

                    }
                    MessageBox.Show("Импорт выолнен!");
                    ThisConnection.Close();
                    //перезагрузка таблицы
                    this.personTableAdapter.Fill(this.categoryDataSet.Person, Categories.CatID);
                }
            }
        }
    }
}
