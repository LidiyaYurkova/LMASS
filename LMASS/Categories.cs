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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
                
        public static int CatID;//ID выбранной нажатием категории для дальнейшего просмотра

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "categoriesDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.categoriesDataSet.Category);
        }

        //просмотр категории по нажатию
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)//если клик на ID в строке
               this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit); //Сохраним в кэш данные

            CatID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);//запоминаем ID выбранной категории

            //открываем просмотр категории
            Form frm = new Category();
            frm.Show();
        }

        //Сохранить изменения
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryBindingSource.EndEdit();
                this.categoryTableAdapter.Update(this.categoriesDataSet.Category);
                MessageBox.Show("Изменения в базе данных выполнены!",
                  "Уведомление о результатах", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Изменения в базе данных выполнить не удалось!",
                  "Уведомление о результатах", MessageBoxButtons.OK);
            }
        }

        ////Импорт
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    SqlConnection ThisConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = LMASS; Integrated Security = True");
        //    ThisConnection.Open();
        //    SqlCommand thisCommand = ThisConnection.CreateCommand();
            
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK) //выбор файла
        //    {
                
        //        using (StreamReader sr = new StreamReader(openFileDialog1.FileName))//берем путь к файлу
        //        {
        //            string line;                   
        //            while ((line = sr.ReadLine()) != null) //читаем строки
        //            {                        
        //                String[] words = line.Split(new char[] { ',', ';' });//делим на слова                       
        //                String[] p = new string[11]; //массив данных доп полей категории
        //                string f, m; //ФИО и Mail                        
        //                f = words[0];//первое всегда ФИО                        
        //                m = words[1];//второй mail
        //                for (int i = 2; i < words.Length; i++)  //остальные поля заносим в переменные р1-р10
        //                    p[i-1]= words[i];
                       
        //                if (words.Length < 12) //если заполнены не все доп поля -> заполняем их пустой строкой                           
        //                    for (int i = words.Length-1; i<=10; i++) //начинаем с певрого пустого
        //                        p[i]= "";

        //                //вставляем данные
        //                thisCommand.CommandText = "INSERT INTO Person (FIO, Mail,CategoryID, p1,p2,p3,p4,p5,p6,p7,p8,p9,p10) values ('" + f+"', '"+m+"', '"+textBox1.Text+"', '"+p[1] +"','" + p[2] + "','" + p[3] + "','"+p[4] + "','"+p[5] + "','" + p[6] + "','" + p[7] + "','" + p[8] + "','" + p[9] + "','" + p[10] +"')";
        //                thisCommand.ExecuteScalar();
                                               
        //            }
        //            MessageBox.Show("Импорт выолнен!");
        //            ThisConnection.Close();
        //        }
        //    }

        //}


    }
}
