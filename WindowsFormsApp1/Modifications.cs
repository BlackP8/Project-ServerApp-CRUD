using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Modifications : Form
    {
        public Modifications()
        {
            InitializeComponent();
        }

        private void Modifications_Load(object sender, EventArgs e)
        {
            this._ISTB_18_1_Romanov_Lab2DataSet6.Clear();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ISTB_18_1_Romanov_Lab2DataSet6.Mod_Select". При необходимости она может быть перемещена или удалена.
            this.mod_SelectTableAdapter.Fill(this._ISTB_18_1_Romanov_Lab2DataSet6.Mod_Select);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ISTB_18_1_Romanov_Lab2DataSet4.Detail_view". При необходимости она может быть перемещена или удалена.
            this.detail_viewTableAdapter.Fill(this._ISTB_18_1_Romanov_Lab2DataSet4.Detail_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ISTB_18_1_Romanov_Lab2DataSet3.Bench_View". При необходимости она может быть перемещена или удалена.
            this.bench_ViewTableAdapter.Fill(this._ISTB_18_1_Romanov_Lab2DataSet3.Bench_View);
        }

        private void Modifications_Deactivate(Object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(_ISTB_18_1_Romanov_Lab2DataSet6);
        }

        private void btnAddMod_Click(object sender, EventArgs e)
        {
            if ((tbModNumber.Text.Length == 0) || (tbModName.Text.Length == 0)
                || (tbCreationTime.Text.Length == 0) || (tbModType.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                mod_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet6.Mod_Select);
                sqlConnection1.Open();
                sqlInsertCommand1.Parameters["@number"].Value = Convert.ToInt32(tbModNumber.Text);
                sqlInsertCommand1.Parameters["@mod_name"].Value = tbModName.Text;
                sqlInsertCommand1.Parameters["@creation_time"].Value = Convert.ToInt32(tbCreationTime.Text);
                sqlInsertCommand1.Parameters["@mod_type"].Value = tbModType.Text;
                sqlInsertCommand1.Parameters["@bench_number"].Value = Convert.ToInt32(cbBench.SelectedValue.ToString());
                sqlInsertCommand1.Parameters["@detail_number"].Value = Convert.ToInt32(cbDetail.SelectedValue.ToString());
                sqlInsertCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                mod_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet6.Mod_Select);
                MessageBox.Show("Запись добавлена.");
            }
        }

        private void btnDelMod_Click(object sender, EventArgs e)
        {
            mod_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet6.Mod_Select);
            sqlConnection1.Open();
            sqlDeleteCommand1.Parameters["@number"].Value = Convert.ToInt32(tbModNumber.Text);
            sqlDeleteCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            mod_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet6.Mod_Select);
            MessageBox.Show("Запись удалена.");
        }

        private void btnFindMod_Click(object sender, EventArgs e)
        {
            DataRow row = Form1.GetCurrentRow(dataGridView1);
            tbModNumber.Text = row["Номер модификации"].ToString();
            tbModName.Text = row["Название модификации"].ToString();
            tbCreationTime.Text = row["Время изготовления"].ToString();
            tbModType.Text = row["Тип модификации"].ToString();
            cbBench.SelectedValue = Convert.ToInt32(row["Номер станка"].ToString());
            cbDetail.SelectedValue = Convert.ToInt32(row["Номер детали"].ToString());
        }

        private void btnUpdateMod_Click(object sender, EventArgs e)
        {

            mod_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet6.Mod_Select);
            if ((tbModNumber.Text.Length == 0) || (tbModName.Text.Length == 0)
                || (tbCreationTime.Text.Length == 0) || (tbModType.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                DataRow row = Form1.GetCurrentRow(dataGridView1);
                sqlConnection1.Open();
                sqlUpdateCommand1.Parameters["@number"].Value = Convert.ToInt32(tbModNumber.Text);
                sqlUpdateCommand1.Parameters["@mod_name"].Value = tbModName.Text;
                sqlUpdateCommand1.Parameters["@creation_time"].Value = Convert.ToInt32(tbCreationTime.Text);
                sqlUpdateCommand1.Parameters["@mod_type"].Value = tbModType.Text;
                sqlUpdateCommand1.Parameters["@bench_number"].Value = Convert.ToInt32(cbBench.Text);
                sqlUpdateCommand1.Parameters["@detail_number"].Value = Convert.ToInt32(cbDetail.Text);
                sqlUpdateCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                mod_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet6.Mod_Select);
                MessageBox.Show("Запись изменена.");
            }
        }
    }
}
