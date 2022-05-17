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
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            this._ISTB_18_1_Romanov_Lab2DataSet7.Clear();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ISTB_18_1_Romanov_Lab2DataSet7.Detail_Select". При необходимости она может быть перемещена или удалена.
            this.detail_SelectTableAdapter.Fill(this._ISTB_18_1_Romanov_Lab2DataSet7.Detail_Select);
        }

        private void Detail_Deactivate(Object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(_ISTB_18_1_Romanov_Lab2DataSet7);
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if ((tbDetailNumber.Text.Length == 0) || (tbDetailName.Text.Length == 0)
               || (tbDate.Text.Length == 0) || (tbDetailType.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                detail_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet7.Detail_Select);
                sqlConnection1.Open();
                sqlInsertCommand1.Parameters["@number"].Value = Convert.ToInt32(tbDetailNumber.Text);
                sqlInsertCommand1.Parameters["@detail_name"].Value = tbDetailName.Text;
                sqlInsertCommand1.Parameters["@deliver_date"].Value = tbDate.Text;
                sqlInsertCommand1.Parameters["@detail_type"].Value = tbDetailType.Text;
                sqlInsertCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                detail_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet7.Detail_Select);
                MessageBox.Show("Запись добавлена.");
            }
        }

        private void btnDelDetail_Click(object sender, EventArgs e)
        {
            detail_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet7.Detail_Select);
            sqlConnection1.Open();
            sqlDeleteCommand1.Parameters["@number"].Value = Convert.ToInt32(tbDetailNumber.Text);
            sqlDeleteCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            detail_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet7.Detail_Select);
            MessageBox.Show("Запись удалена.");
        }

        private void btnFindDetail_Click(object sender, EventArgs e)
        {
            DataRow row = Form1.GetCurrentRow(dataGridView1);
            tbDetailNumber.Text = row["Номер детали"].ToString();
            tbDetailName.Text = row["Название детали"].ToString();
            tbDate.Text = row["Дата привоза"].ToString();
            tbDetailType.Text = row["Вид детали"].ToString();
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            if ((tbDetailNumber.Text.Length == 0) || (tbDetailName.Text.Length == 0)
               || (tbDate.Text.Length == 0) || (tbDetailType.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                detail_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet7.Detail_Select);
                DataRow row = Form1.GetCurrentRow(dataGridView1);
                sqlConnection1.Open();
                sqlUpdateCommand1.Parameters["@number"].Value = Convert.ToInt32(tbDetailNumber.Text);
                sqlUpdateCommand1.Parameters["@detail_name"].Value = tbDetailName.Text;
                sqlUpdateCommand1.Parameters["@deliver_date"].Value = tbDate.Text;
                sqlUpdateCommand1.Parameters["@detail_type"].Value = tbDetailType.Text;
                sqlUpdateCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                detail_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet7.Detail_Select);
                MessageBox.Show("Запись изменена.");
            }
        }
    }
}
