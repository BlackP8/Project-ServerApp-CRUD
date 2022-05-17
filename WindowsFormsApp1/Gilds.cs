using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Gilds : Form
    {
        public Gilds()
        {
            InitializeComponent();
        }

        private void Gilds_Load(object sender, EventArgs e)
        {
            this._ISTB_18_1_Romanov_Lab2DataSet8.Clear();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ISTB_18_1_Romanov_Lab2DataSet8.Gild_Select". При необходимости она может быть перемещена или удалена.
            this.gild_SelectTableAdapter.Fill(this._ISTB_18_1_Romanov_Lab2DataSet8.Gild_Select);
        }

        private void Gilds_Deactivate(Object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(_ISTB_18_1_Romanov_Lab2DataSet8);
        }

        private void btnAddGild_Click(object sender, EventArgs e)
        {
            if ((tbGildNumber.Text.Length == 0) || (tbBoss.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                gild_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet8.Gild_Select);
                sqlConnection1.Open();
                sqlInsertCommand1.Parameters["@number"].Value = Convert.ToInt32(tbGildNumber.Text);
                sqlInsertCommand1.Parameters["@boss"].Value = tbBoss.Text;
                sqlInsertCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                gild_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet8.Gild_Select);
                MessageBox.Show("Запись добавлена.");
            }
        }

        private void btnDelGild_Click(object sender, EventArgs e)
        {
            gild_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet8.Gild_Select);
            sqlConnection1.Open();
            sqlDeleteCommand1.Parameters["@number"].Value = Convert.ToInt32(tbGildNumber.Text);
            sqlDeleteCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            gild_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet8.Gild_Select);
            MessageBox.Show("Запись удалена.");
        }

        private void btnFindGild_Click(object sender, EventArgs e)
        {
            DataRow row = Form1.GetCurrentRow(dataGridView1);
            tbGildNumber.Text = row["Номер цеха"].ToString();
            tbBoss.Text = row["ФИО начальника"].ToString();
        }

        private void btnUpdateGild_Click(object sender, EventArgs e)
        {
            if ((tbGildNumber.Text.Length == 0) || (tbBoss.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                gild_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet8.Gild_Select);
                DataRow row = Form1.GetCurrentRow(dataGridView1);
                sqlConnection1.Open();
                sqlUpdateCommand1.Parameters["@number"].Value = Convert.ToInt32(tbGildNumber.Text);
                sqlUpdateCommand1.Parameters["@boss"].Value = tbBoss.Text;
                sqlUpdateCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                gild_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet8.Gild_Select);
                MessageBox.Show("Запись изменена.");
            }
        }
    }
}
