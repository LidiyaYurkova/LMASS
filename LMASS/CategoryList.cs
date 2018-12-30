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
        private void CategoryList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "categoryListDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.categoryListDataSet.Category);
            
        }

        //При клике грида
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)//Если колонка с checkBox, её индекс 2               
                this.dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit); //Сохраним в кэш данные
                        
            if ((bool)this.dataGridView1.CurrentCell.Value == true)//Если checkBox таки true
            {      //заносим данные в список выбранных категорий
                  CurrentCategoriesID.Add(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value)); // добавление элемента

            } //иначе удаляем из списка данные в список выбранных категорий
            else CurrentCategoriesID.Remove(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value));


        }

        //готово
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
