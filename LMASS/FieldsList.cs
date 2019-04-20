using System;
using System.Collections;
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
    public partial class FieldsList : Form
    {
        public static ArrayList SelectedFields = new ArrayList();//названия доп полей
        public static ArrayList AllFields = new ArrayList();//названия доп полей
        CheckBox[] cb;//названия полей
        public FieldsList()
        {
            InitializeComponent();
        }

        private void FieldsList_Load(object sender, EventArgs e)
        {
            SelectedFields.Clear();
            AllFields.Clear();
            SqlConnection ThisConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LMASSDatabase.mdf;Integrated Security=True");
            ThisConnection.Open();
            SqlCommand thisCommand = ThisConnection.CreateCommand();
            
            cb = new CheckBox[12];//создаем список доп полей           
            cb[0] = new CheckBox(); //первое всегда ФИО
            cb[0].Size = new Size(100, 20);
            cb[0].Location = new Point(30, 20 + 20 * 0);
            Controls.Add(cb[0]);
            cb[0].Text = "ФИО";
            cb[0].BackColor = Color.Transparent; 


            cb[1] = new CheckBox(); //второе адрес
            cb[1].Size = new Size(100, 20);
            cb[1].Location = new Point(30, 20 + 20 * 1);
            Controls.Add(cb[1]);
            cb[1].Text = "Адрес";
            cb[1].BackColor = Color.Transparent;

            if (CategoryList.CurrentCategoriesID.Count==1)
                for (int i = 2; i < 12; i++) //остальные грузим из бд
                {
                    cb[i] = new CheckBox();
                    cb[i].Size = new Size(100, 20);
                    cb[i].Location = new Point(30, 20 + 20 * i);
                    cb[i].BackColor = Color.Transparent;
                    Controls.Add(cb[i]);
                    thisCommand.CommandText = "SELECT ColumnName" + (i - 1) + " from Category where ID=" + CategoryList.CurrentCategoriesID[0] + "";
               
                    cb[i].Text = thisCommand.ExecuteScalar().ToString();
                    if (cb[i].Text == "") //если есть не все поля - прячем их
                        cb[i].Visible = false;

                }


        }
        //готово
        private void btnOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)//заполняем массив доп полей
            {
                if (i > 1) AllFields.Add("<" + cb[i].Text + ">");

                if (cb[i].Checked == true)
                    SelectedFields.Add("<" + cb[i].Text + ">");
            }
            this.Close();
        }
    }
}
