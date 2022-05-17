using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text.Length == 0 || tbPassword.Text.Length == 0)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                sqlConnection1.Open();
                sqlInsertCommand1.Parameters["@user_login"].Value = tbLogin.Text;
                sqlInsertCommand1.Parameters["@user_password"].Value = tbPassword.Text;
                sqlInsertCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                CommonForm commonForm = new CommonForm();
                commonForm.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
