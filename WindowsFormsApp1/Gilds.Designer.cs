
namespace WindowsFormsApp1
{
    partial class Gilds
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnUpdateGild = new System.Windows.Forms.Button();
            this.btnFindGild = new System.Windows.Forms.Button();
            this.btnDelGild = new System.Windows.Forms.Button();
            this.btnAddGild = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBoss = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGildNumber = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерЦехаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОНачальникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gildSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ISTB_18_1_Romanov_Lab2DataSet8 = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet8();
            this.gild_SelectTableAdapter = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet8TableAdapters.Gild_SelectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gildSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateGild
            // 
            this.btnUpdateGild.Location = new System.Drawing.Point(392, 388);
            this.btnUpdateGild.Name = "btnUpdateGild";
            this.btnUpdateGild.Size = new System.Drawing.Size(104, 39);
            this.btnUpdateGild.TabIndex = 22;
            this.btnUpdateGild.Text = "Изменить";
            this.btnUpdateGild.UseVisualStyleBackColor = true;
            this.btnUpdateGild.Click += new System.EventHandler(this.btnUpdateGild_Click);
            // 
            // btnFindGild
            // 
            this.btnFindGild.Location = new System.Drawing.Point(287, 388);
            this.btnFindGild.Name = "btnFindGild";
            this.btnFindGild.Size = new System.Drawing.Size(75, 39);
            this.btnFindGild.TabIndex = 21;
            this.btnFindGild.Text = "Найти";
            this.btnFindGild.UseVisualStyleBackColor = true;
            this.btnFindGild.Click += new System.EventHandler(this.btnFindGild_Click);
            // 
            // btnDelGild
            // 
            this.btnDelGild.Location = new System.Drawing.Point(168, 388);
            this.btnDelGild.Name = "btnDelGild";
            this.btnDelGild.Size = new System.Drawing.Size(87, 39);
            this.btnDelGild.TabIndex = 20;
            this.btnDelGild.Text = "Удалить";
            this.btnDelGild.UseVisualStyleBackColor = true;
            this.btnDelGild.Click += new System.EventHandler(this.btnDelGild_Click);
            // 
            // btnAddGild
            // 
            this.btnAddGild.Location = new System.Drawing.Point(26, 387);
            this.btnAddGild.Name = "btnAddGild";
            this.btnAddGild.Size = new System.Drawing.Size(100, 41);
            this.btnAddGild.TabIndex = 19;
            this.btnAddGild.Text = "Добавить";
            this.btnAddGild.UseVisualStyleBackColor = true;
            this.btnAddGild.Click += new System.EventHandler(this.btnAddGild_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "ФИО начальника";
            // 
            // tbBoss
            // 
            this.tbBoss.Location = new System.Drawing.Point(168, 341);
            this.tbBoss.Name = "tbBoss";
            this.tbBoss.Size = new System.Drawing.Size(224, 26);
            this.tbBoss.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Номер цеха";
            // 
            // tbGildNumber
            // 
            this.tbGildNumber.Location = new System.Drawing.Point(26, 341);
            this.tbGildNumber.Name = "tbGildNumber";
            this.tbGildNumber.Size = new System.Drawing.Size(115, 26);
            this.tbGildNumber.TabIndex = 15;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-JILB1LC\\SQLEXPRESS;Initial Catalog=ISTB-18-1_Romanov_Lab2;Int" +
    "egrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.Gild_Select";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.Цех_добавление";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.TinyInt, 1),
            new System.Data.SqlClient.SqlParameter("@boss", System.Data.SqlDbType.VarChar, 50)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "dbo.Цех_обновление";
            this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.TinyInt, 1),
            new System.Data.SqlClient.SqlParameter("@boss", System.Data.SqlDbType.VarChar, 50)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "dbo.Цех_удаление";
            this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.TinyInt, 1)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Gild_Select", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Номер цеха", "Номер цеха"),
                        new System.Data.Common.DataColumnMapping("ФИО начальника", "ФИО начальника")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерЦехаDataGridViewTextBoxColumn,
            this.фИОНачальникаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gildSelectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(605, 283);
            this.dataGridView1.TabIndex = 23;
            // 
            // номерЦехаDataGridViewTextBoxColumn
            // 
            this.номерЦехаDataGridViewTextBoxColumn.DataPropertyName = "Номер цеха";
            this.номерЦехаDataGridViewTextBoxColumn.HeaderText = "Номер цеха";
            this.номерЦехаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерЦехаDataGridViewTextBoxColumn.Name = "номерЦехаDataGridViewTextBoxColumn";
            this.номерЦехаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерЦехаDataGridViewTextBoxColumn.Width = 123;
            // 
            // фИОНачальникаDataGridViewTextBoxColumn
            // 
            this.фИОНачальникаDataGridViewTextBoxColumn.DataPropertyName = "ФИО начальника";
            this.фИОНачальникаDataGridViewTextBoxColumn.HeaderText = "ФИО начальника";
            this.фИОНачальникаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фИОНачальникаDataGridViewTextBoxColumn.Name = "фИОНачальникаDataGridViewTextBoxColumn";
            this.фИОНачальникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОНачальникаDataGridViewTextBoxColumn.Width = 162;
            // 
            // gildSelectBindingSource
            // 
            this.gildSelectBindingSource.DataMember = "Gild_Select";
            this.gildSelectBindingSource.DataSource = this._ISTB_18_1_Romanov_Lab2DataSet8;
            // 
            // _ISTB_18_1_Romanov_Lab2DataSet8
            // 
            this._ISTB_18_1_Romanov_Lab2DataSet8.DataSetName = "_ISTB_18_1_Romanov_Lab2DataSet8";
            this._ISTB_18_1_Romanov_Lab2DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gild_SelectTableAdapter
            // 
            this.gild_SelectTableAdapter.ClearBeforeFill = true;
            // 
            // Gilds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateGild);
            this.Controls.Add(this.btnFindGild);
            this.Controls.Add(this.btnDelGild);
            this.Controls.Add(this.btnAddGild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBoss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGildNumber);
            this.Name = "Gilds";
            this.Text = "Gilds";
            this.Load += new System.EventHandler(this.Gilds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gildSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateGild;
        private System.Windows.Forms.Button btnFindGild;
        private System.Windows.Forms.Button btnDelGild;
        private System.Windows.Forms.Button btnAddGild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBoss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGildNumber;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _ISTB_18_1_Romanov_Lab2DataSet8 _ISTB_18_1_Romanov_Lab2DataSet8;
        private System.Windows.Forms.BindingSource gildSelectBindingSource;
        private _ISTB_18_1_Romanov_Lab2DataSet8TableAdapters.Gild_SelectTableAdapter gild_SelectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЦехаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОНачальникаDataGridViewTextBoxColumn;
    }
}