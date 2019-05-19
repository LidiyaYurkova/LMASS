using System;
using System.IO;
using System.Windows.Forms;

namespace LMASS
{
    public partial class Categories : Form
    {
        public static int ClickedCategoryID;//ID выбранной нажатием категории для дальнейшего просмотра
        public Categories()
        {
            InitializeComponent();
        }       
        private void Categories_Load(object sender, EventArgs e)
        {
            this.CategoriesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.categoryTableAdapter.Fill(this.categoriesDataSet.Category);
            this.CategoriesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
        private void CategoriesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)//просмотр категории по нажатию
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)//если клик на ID в строке
            {
                this.CategoriesGridView.CommitEdit(DataGridViewDataErrorContexts.Commit); //Сохраним в кэш данные
                ClickedCategoryID = Convert.ToInt32(CategoriesGridView.Rows[e.RowIndex].Cells[0].Value);//запоминаем ID выбранной категории
                if (ClickedCategoryID >= 0)
                {
                    Form frm = new Category();
                    frm.Show();   //открываем просмотр категории
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)//Сохранить изменения
        {
            try
            {
                this.categoryBindingSource.EndEdit();
                this.categoryTableAdapter.Update(this.categoriesDataSet.Category);
                MessageBox.Show("Изменения в базе данных выполнены!","Уведомление о результатах", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Изменения в базе данных выполнить не удалось! Смотрите подробности в LMASS.log","Уведомление о результатах", MessageBoxButtons.OK);
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
