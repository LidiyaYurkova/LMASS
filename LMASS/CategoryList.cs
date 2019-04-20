using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMASS
{
    public partial class CategoryList : Form
    {
        public CategoryList()
        {
            InitializeComponent();
        }
        public static ArrayList CurrentCategoriesID = new ArrayList(); //список выбранных категорий
        public static ArrayList CurrentCategoriesName = new ArrayList();

        private void CategoryList_Load(object sender, EventArgs e)
        {
            this.categoryTableAdapter.Fill(this.categoryListDatabaseDataSet.Category);
            CurrentCategoriesID.Clear();
            CurrentCategoriesName.Clear();

        }

        //При клике грида
        private void CategoryListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)//Если колонка с checkBox, её индекс 2               
                this.CategoryListGridView.CommitEdit(DataGridViewDataErrorContexts.Commit); //Сохраним в кэш данные

            if ((bool)this.CategoryListGridView.CurrentCell.Value == true)//Если checkBox таки true
            {      //заносим данные в список выбранных категорий
                CurrentCategoriesID.Add(Convert.ToInt32(CategoryListGridView.Rows[e.RowIndex].Cells[0].Value)); // добавление элемента
                CurrentCategoriesName.Add(CategoryListGridView.Rows[e.RowIndex].Cells[1].Value); // добавление элемента
            } //иначе удаляем из списка данные в список выбранных категорий
            else { CurrentCategoriesID.Remove(Convert.ToInt32(CategoryListGridView.Rows[e.RowIndex].Cells[0].Value));
                CurrentCategoriesName.Remove(CategoryListGridView.Rows[e.RowIndex].Cells[1].Value);
            }
        }

        //ok
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
