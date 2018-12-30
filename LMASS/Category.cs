using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

       
    }
}
