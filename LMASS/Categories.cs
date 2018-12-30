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

        

    }
}
