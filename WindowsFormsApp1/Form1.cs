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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._ISTB_18_1_Romanov_Lab2DataSet1.Clear();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ISTB_18_1_Romanov_Lab2DataSet.Gild_Select". При необходимости она может быть перемещена или удалена.
            this.gild_SelectTableAdapter.Fill(this._ISTB_18_1_Romanov_Lab2DataSet.Gild_Select);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ISTB_18_1_Romanov_Lab2DataSet1.Bench_Select". При необходимости она может быть перемещена или удалена.
            this.bench_SelectTableAdapter.Fill(this._ISTB_18_1_Romanov_Lab2DataSet1.Bench_Select);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ISTB_18_1_Romanov_Lab2DataSet.Bench_Select". При необходимости она может быть перемещена или удалена.
            this.bench_SelectTableAdapter.Fill(this._ISTB_18_1_Romanov_Lab2DataSet1.Bench_Select);
        }

        private void Form1_Deactivate(Object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(_ISTB_18_1_Romanov_Lab2DataSet1);
        }

        private void btnAddBench_Click(object sender, EventArgs e)
        {
            if ((tbBenchNumber.Text.Length == 0) || (tbWorkTime.Text.Length == 0)
               || (tbModCount.Text.Length == 0) || (tbWorkType.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                bench_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet1.Bench_Select);
                sqlConnection1.Open();
                sqlInsertCommand1.Parameters["@number"].Value = Convert.ToInt32(tbBenchNumber.Text);
                sqlInsertCommand1.Parameters["@work_time"].Value = Convert.ToSingle(tbWorkTime.Text);
                sqlInsertCommand1.Parameters["@mod_count"].Value = Convert.ToInt32(tbModCount.Text);
                sqlInsertCommand1.Parameters["@work_type"].Value = tbWorkType.Text;
                sqlInsertCommand1.Parameters["@gild_number"].Value = Convert.ToInt32(cbGild.SelectedValue.ToString());
                sqlInsertCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                bench_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet1.Bench_Select);
                MessageBox.Show("Запись добавлена.");
            }
        }

        public static DataRow GetCurrentRow(DataGridView dg)
        {
            CurrencyManager cm = (CurrencyManager)dg.BindingContext[dg.DataSource, dg.DataMember];
            if (cm.Count == 0) { return null; }
            DataRowView drv = (DataRowView)cm.Current;
            return drv.Row;
        }

        private void btnFindBench_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            tbBenchNumber.Text = row["Номер станка"].ToString();
            tbWorkTime.Text = row["Время работы"].ToString();
            tbModCount.Text = row["Кол-во произвед. мод."].ToString();
            tbWorkType.Text = row["Вид работы"].ToString();
            cbGild.SelectedValue = Convert.ToInt32(row["Номер цеха"].ToString());
        }

        private void btnUpdateBench_Click(object sender, EventArgs e)
        {
            if ((tbBenchNumber.Text.Length == 0) || (tbWorkTime.Text.Length == 0)
               || (tbModCount.Text.Length == 0) || (tbWorkType.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else { 
                bench_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet1.Bench_Select);
                DataRow row = GetCurrentRow(dataGridView1);
                sqlConnection1.Open();
                sqlUpdateCommand1.Parameters["@number"].Value = Convert.ToInt32(tbBenchNumber.Text);
                sqlUpdateCommand1.Parameters["@work_time"].Value = Convert.ToSingle(tbWorkTime.Text);
                sqlUpdateCommand1.Parameters["@mod_count"].Value = Convert.ToInt32(tbModCount.Text);
                sqlUpdateCommand1.Parameters["@work_type"].Value = tbWorkType.Text;
                sqlUpdateCommand1.Parameters["@gild_number"].Value = Convert.ToInt32(cbGild.Text);
                sqlUpdateCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                bench_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet1.Bench_Select);
                MessageBox.Show("Запись изменена.");
            }

        }

        private void btnDelBench_Click(object sender, EventArgs e)
        {
            bench_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet1.Bench_Select);
            sqlConnection1.Open();
            sqlDeleteCommand1.Parameters["@number"].Value = Convert.ToInt32(tbBenchNumber.Text);
            sqlDeleteCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            bench_SelectTableAdapter.Fill(_ISTB_18_1_Romanov_Lab2DataSet1.Bench_Select);
            MessageBox.Show("Запись удалена.");
        }
    }
}
