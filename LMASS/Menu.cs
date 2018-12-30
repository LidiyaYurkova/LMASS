using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //рассылка
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Message();
            frm.Show();
           
        }
        //категории
        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Categories();
            frm.Show();
            
        }
        //выход
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

        }
    }
}
