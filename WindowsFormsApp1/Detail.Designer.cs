
namespace WindowsFormsApp1
{
    partial class Detail
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
            this.btnUpdateDetail = new System.Windows.Forms.Button();
            this.btnFindDetail = new System.Windows.Forms.Button();
            this.btnDelDetail = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.tbDetailType = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbDetailName = new System.Windows.Forms.TextBox();
            this.tbDetailNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерДеталиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеДеталиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПривозаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видДеталиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ISTB_18_1_Romanov_Lab2DataSet7 = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet7();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.detail_SelectTableAdapter = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet7TableAdapters.Detail_SelectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.Location = new System.Drawing.Point(378, 468);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(104, 39);
            this.btnUpdateDetail.TabIndex = 18;
            this.btnUpdateDetail.Text = "Изменить";
            this.btnUpdateDetail.UseVisualStyleBackColor = true;
            this.btnUpdateDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
            // 
            // btnFindDetail
            // 
            this.btnFindDetail.Location = new System.Drawing.Point(273, 468);
            this.btnFindDetail.Name = "btnFindDetail";
            this.btnFindDetail.Size = new System.Drawing.Size(75, 39);
            this.btnFindDetail.TabIndex = 17;
            this.btnFindDetail.Text = "Найти";
            this.btnFindDetail.UseVisualStyleBackColor = true;
            this.btnFindDetail.Click += new System.EventHandler(this.btnFindDetail_Click);
            // 
            // btnDelDetail
            // 
            this.btnDelDetail.Location = new System.Drawing.Point(154, 468);
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(87, 39);
            this.btnDelDetail.TabIndex = 16;
            this.btnDelDetail.Text = "Удалить";
            this.btnDelDetail.UseVisualStyleBackColor = true;
            this.btnDelDetail.Click += new System.EventHandler(this.btnDelDetail_Click);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(12, 467);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(100, 41);
            this.btnAddDetail.TabIndex = 15;
            this.btnAddDetail.Text = "Добавить";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // tbDetailType
            // 
            this.tbDetailType.Location = new System.Drawing.Point(562, 384);
            this.tbDetailType.Name = "tbDetailType";
            this.tbDetailType.Size = new System.Drawing.Size(132, 26);
            this.tbDetailType.TabIndex = 22;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(367, 384);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(165, 26);
            this.tbDate.TabIndex = 21;
            // 
            // tbDetailName
            // 
            this.tbDetailName.Location = new System.Drawing.Point(155, 384);
            this.tbDetailName.Multiline = true;
            this.tbDetailName.Name = "tbDetailName";
            this.tbDetailName.Size = new System.Drawing.Size(182, 56);
            this.tbDetailName.TabIndex = 20;
            // 
            // tbDetailNumber
            // 
            this.tbDetailNumber.Location = new System.Drawing.Point(13, 384);
            this.tbDetailNumber.Name = "tbDetailNumber";
            this.tbDetailNumber.Size = new System.Drawing.Size(115, 26);
            this.tbDetailNumber.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Вид детали";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Дата привоза";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Название детали";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Номер детали";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДеталиDataGridViewTextBoxColumn,
            this.названиеДеталиDataGridViewTextBoxColumn,
            this.датаПривозаDataGridViewTextBoxColumn,
            this.видДеталиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detailSelectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(894, 325);
            this.dataGridView1.TabIndex = 28;
            // 
            // номерДеталиDataGridViewTextBoxColumn
            // 
            this.номерДеталиDataGridViewTextBoxColumn.DataPropertyName = "Номер детали";
            this.номерДеталиDataGridViewTextBoxColumn.HeaderText = "Номер детали";
            this.номерДеталиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерДеталиDataGridViewTextBoxColumn.Name = "номерДеталиDataGridViewTextBoxColumn";
            this.номерДеталиDataGridViewTextBoxColumn.Width = 143;
            // 
            // названиеДеталиDataGridViewTextBoxColumn
            // 
            this.названиеДеталиDataGridViewTextBoxColumn.DataPropertyName = "Название детали";
            this.названиеДеталиDataGridViewTextBoxColumn.HeaderText = "Название детали";
            this.названиеДеталиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.названиеДеталиDataGridViewTextBoxColumn.Name = "названиеДеталиDataGridViewTextBoxColumn";
            this.названиеДеталиDataGridViewTextBoxColumn.Width = 165;
            // 
            // датаПривозаDataGridViewTextBoxColumn
            // 
            this.датаПривозаDataGridViewTextBoxColumn.DataPropertyName = "Дата привоза";
            this.датаПривозаDataGridViewTextBoxColumn.HeaderText = "Дата привоза";
            this.датаПривозаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.датаПривозаDataGridViewTextBoxColumn.Name = "датаПривозаDataGridViewTextBoxColumn";
            this.датаПривозаDataGridViewTextBoxColumn.Width = 138;
            // 
            // видДеталиDataGridViewTextBoxColumn
            // 
            this.видДеталиDataGridViewTextBoxColumn.DataPropertyName = "Вид детали";
            this.видДеталиDataGridViewTextBoxColumn.HeaderText = "Вид детали";
            this.видДеталиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.видДеталиDataGridViewTextBoxColumn.Name = "видДеталиDataGridViewTextBoxColumn";
            this.видДеталиDataGridViewTextBoxColumn.Width = 126;
            // 
            // detailSelectBindingSource
            // 
            this.detailSelectBindingSource.DataMember = "Detail_Select";
            this.detailSelectBindingSource.DataSource = this._ISTB_18_1_Romanov_Lab2DataSet7;
            // 
            // _ISTB_18_1_Romanov_Lab2DataSet7
            // 
            this._ISTB_18_1_Romanov_Lab2DataSet7.DataSetName = "_ISTB_18_1_Romanov_Lab2DataSet7";
            this._ISTB_18_1_Romanov_Lab2DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-JILB1LC\\SQLEXPRESS;Initial Catalog=ISTB-18-1_Romanov_Lab2;Int" +
    "egrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.Detail_Select";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.Деталь_добавление";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@detail_name", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@deliver_date", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@detail_type", System.Data.SqlDbType.VarChar, 100)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "dbo.Деталь_обновление";
            this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@detail_name", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@deliver_date", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@detail_type", System.Data.SqlDbType.VarChar, 100)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "dbo.Деталь_удаление";
            this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Detail_Select", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Номер детали", "Номер детали"),
                        new System.Data.Common.DataColumnMapping("Название детали", "Название детали"),
                        new System.Data.Common.DataColumnMapping("Дата привоза", "Дата привоза"),
                        new System.Data.Common.DataColumnMapping("Вид детали", "Вид детали")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // detail_SelectTableAdapter
            // 
            this.detail_SelectTableAdapter.ClearBeforeFill = true;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDetailType);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbDetailName);
            this.Controls.Add(this.tbDetailNumber);
            this.Controls.Add(this.btnUpdateDetail);
            this.Controls.Add(this.btnFindDetail);
            this.Controls.Add(this.btnDelDetail);
            this.Controls.Add(this.btnAddDetail);
            this.Name = "Detail";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateDetail;
        private System.Windows.Forms.Button btnFindDetail;
        private System.Windows.Forms.Button btnDelDetail;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.TextBox tbDetailType;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbDetailName;
        private System.Windows.Forms.TextBox tbDetailNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private _ISTB_18_1_Romanov_Lab2DataSet7 _ISTB_18_1_Romanov_Lab2DataSet7;
        private System.Windows.Forms.BindingSource detailSelectBindingSource;
        private _ISTB_18_1_Romanov_Lab2DataSet7TableAdapters.Detail_SelectTableAdapter detail_SelectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДеталиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеДеталиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПривозаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видДеталиDataGridViewTextBoxColumn;
    }
}