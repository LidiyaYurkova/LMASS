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
            this.CategoriesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }
                
        public static int CatID;//ID выбранной нажатием категории для дальнейшего просмотра

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "categoriesDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.categoriesDataSet.Category);
            this.CategoriesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        //просмотр категории по нажатию
        private void CategoriesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)//если клик на ID в строке
            {
                this.CategoriesGridView.CommitEdit(DataGridViewDataErrorContexts.Commit); //Сохраним в кэш данные

                CatID = Convert.ToInt32(CategoriesGridView.Rows[e.RowIndex].Cells[0].Value);//запоминаем ID выбранной категории
                //this.CategoriesGridView.CommitEdit(DataGridViewDataErrorContexts.Commit); //Сохраним в кэш данные
                //открываем просмотр категории
                Form frm = new Category();
                frm.Show();
            }
        }

        //Сохранить изменения
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryBindingSource.EndEdit();
                this.categoryTableAdapter.Update(this.categoriesDataSet.Category);
                MessageBox.Show("Изменения в базе данных выполнены!",
                  "Уведомление о результатах", MessageBoxButtons.OK);
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
