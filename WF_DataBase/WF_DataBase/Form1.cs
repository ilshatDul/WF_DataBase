using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Create_db dataBase = new Create_db();
        private void bt_start_Click(object sender, EventArgs e)
        {
            dataBase.create_db();
        }

        public void rtb_cmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_cmdGo_Click(object sender, EventArgs e)
        {
            if (rtb_cmd.Text != string.Empty)
            {
                rtb_cmd.Text = dataBase.Insert(rtb_cmd.Text);
                //rtb_cmd.Clear();
            }
            else { rtb_cmd.Text = "Введите команду"; }
        }
    }
}
