
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерСтанкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоПроизведМодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЦехаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benchSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ISTB_18_1_Romanov_Lab2DataSet1 = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet1();
            this.tbBenchNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWorkTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWorkType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddBench = new System.Windows.Forms.Button();
            this.btnDelBench = new System.Windows.Forms.Button();
            this.btnFindBench = new System.Windows.Forms.Button();
            this.btnUpdateBench = new System.Windows.Forms.Button();
            this.cbGild = new System.Windows.Forms.ComboBox();
            this.gildSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ISTB_18_1_Romanov_Lab2DataSet = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet();
            this.gildViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.bench_SelectTableAdapter = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet1TableAdapters.Bench_SelectTableAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.comboBoxAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.gild_SelectTableAdapter = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSetTableAdapters.Gild_SelectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benchSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gildSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gildViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерСтанкаDataGridViewTextBoxColumn,
            this.времяРаботыDataGridViewTextBoxColumn,
            this.колвоПроизведМодDataGridViewTextBoxColumn,
            this.видРаботыDataGridViewTextBoxColumn,
            this.номерЦехаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.benchSelectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(816, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерСтанкаDataGridViewTextBoxColumn
            // 
            this.номерСтанкаDataGridViewTextBoxColumn.DataPropertyName = "Номер станка";
            this.номерСтанкаDataGridViewTextBoxColumn.HeaderText = "Номер станка";
            this.номерСтанкаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерСтанкаDataGridViewTextBoxColumn.Name = "номерСтанкаDataGridViewTextBoxColumn";
            this.номерСтанкаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерСтанкаDataGridViewTextBoxColumn.Width = 139;
            // 
            // времяРаботыDataGridViewTextBoxColumn
            // 
            this.времяРаботыDataGridViewTextBoxColumn.DataPropertyName = "Время работы";
            this.времяРаботыDataGridViewTextBoxColumn.HeaderText = "Время работы";
            this.времяРаботыDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.времяРаботыDataGridViewTextBoxColumn.Name = "времяРаботыDataGridViewTextBoxColumn";
            this.времяРаботыDataGridViewTextBoxColumn.ReadOnly = true;
            this.времяРаботыDataGridViewTextBoxColumn.Width = 142;
            // 
            // колвоПроизведМодDataGridViewTextBoxColumn
            // 
            this.колвоПроизведМодDataGridViewTextBoxColumn.DataPropertyName = "Кол-во произвед. мод.";
            this.колвоПроизведМодDataGridViewTextBoxColumn.HeaderText = "Кол-во произвед. мод.";
            this.колвоПроизведМодDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.колвоПроизведМодDataGridViewTextBoxColumn.Name = "колвоПроизведМодDataGridViewTextBoxColumn";
            this.колвоПроизведМодDataGridViewTextBoxColumn.ReadOnly = true;
            this.колвоПроизведМодDataGridViewTextBoxColumn.Width = 167;
            // 
            // видРаботыDataGridViewTextBoxColumn
            // 
            this.видРаботыDataGridViewTextBoxColumn.DataPropertyName = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn.HeaderText = "Вид работы";
            this.видРаботыDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.видРаботыDataGridViewTextBoxColumn.Name = "видРаботыDataGridViewTextBoxColumn";
            this.видРаботыDataGridViewTextBoxColumn.ReadOnly = true;
            this.видРаботыDataGridViewTextBoxColumn.Width = 125;
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
            // benchSelectBindingSource
            // 
            this.benchSelectBindingSource.DataMember = "Bench_Select";
            this.benchSelectBindingSource.DataSource = this._ISTB_18_1_Romanov_Lab2DataSet1;
            // 
            // _ISTB_18_1_Romanov_Lab2DataSet1
            // 
            this._ISTB_18_1_Romanov_Lab2DataSet1.DataSetName = "_ISTB_18_1_Romanov_Lab2DataSet1";
            this._ISTB_18_1_Romanov_Lab2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBenchNumber
            // 
            this.tbBenchNumber.Location = new System.Drawing.Point(12, 425);
            this.tbBenchNumber.Name = "tbBenchNumber";
            this.tbBenchNumber.Size = new System.Drawing.Size(115, 26);
            this.tbBenchNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер станка";
            // 
            // tbWorkTime
            // 
            this.tbWorkTime.Location = new System.Drawing.Point(154, 425);
            this.tbWorkTime.Name = "tbWorkTime";
            this.tbWorkTime.Size = new System.Drawing.Size(111, 26);
            this.tbWorkTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Время работы";
            // 
            // tbModCount
            // 
            this.tbModCount.Location = new System.Drawing.Point(295, 424);
            this.tbModCount.Name = "tbModCount";
            this.tbModCount.Size = new System.Drawing.Size(114, 26);
            this.tbModCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кол. произвед. мод.";
            // 
            // tbWorkType
            // 
            this.tbWorkType.Location = new System.Drawing.Point(467, 424);
            this.tbWorkType.Name = "tbWorkType";
            this.tbWorkType.Size = new System.Drawing.Size(96, 26);
            this.tbWorkType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вид работы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер цеха";
            // 
            // btnAddBench
            // 
            this.btnAddBench.Location = new System.Drawing.Point(12, 499);
            this.btnAddBench.Name = "btnAddBench";
            this.btnAddBench.Size = new System.Drawing.Size(100, 41);
            this.btnAddBench.TabIndex = 11;
            this.btnAddBench.Text = "Добавить";
            this.btnAddBench.UseVisualStyleBackColor = true;
            this.btnAddBench.Click += new System.EventHandler(this.btnAddBench_Click);
            // 
            // btnDelBench
            // 
            this.btnDelBench.Location = new System.Drawing.Point(154, 500);
            this.btnDelBench.Name = "btnDelBench";
            this.btnDelBench.Size = new System.Drawing.Size(87, 39);
            this.btnDelBench.TabIndex = 12;
            this.btnDelBench.Text = "Удалить";
            this.btnDelBench.UseVisualStyleBackColor = true;
            this.btnDelBench.Click += new System.EventHandler(this.btnDelBench_Click);
            // 
            // btnFindBench
            // 
            this.btnFindBench.Location = new System.Drawing.Point(273, 500);
            this.btnFindBench.Name = "btnFindBench";
            this.btnFindBench.Size = new System.Drawing.Size(75, 39);
            this.btnFindBench.TabIndex = 13;
            this.btnFindBench.Text = "Найти";
            this.btnFindBench.UseVisualStyleBackColor = true;
            this.btnFindBench.Click += new System.EventHandler(this.btnFindBench_Click);
            // 
            // btnUpdateBench
            // 
            this.btnUpdateBench.Location = new System.Drawing.Point(378, 500);
            this.btnUpdateBench.Name = "btnUpdateBench";
            this.btnUpdateBench.Size = new System.Drawing.Size(104, 39);
            this.btnUpdateBench.TabIndex = 14;
            this.btnUpdateBench.Text = "Изменить";
            this.btnUpdateBench.UseVisualStyleBackColor = true;
            this.btnUpdateBench.Click += new System.EventHandler(this.btnUpdateBench_Click);
            // 
            // cbGild
            // 
            this.cbGild.DataSource = this.gildSelectBindingSource;
            this.cbGild.DisplayMember = "Номер цеха";
            this.cbGild.FormattingEnabled = true;
            this.cbGild.Location = new System.Drawing.Point(608, 422);
            this.cbGild.Name = "cbGild";
            this.cbGild.Size = new System.Drawing.Size(121, 28);
            this.cbGild.TabIndex = 15;
            this.cbGild.ValueMember = "Номер цеха";
            // 
            // gildSelectBindingSource
            // 
            this.gildSelectBindingSource.DataMember = "Gild_Select";
            this.gildSelectBindingSource.DataSource = this._ISTB_18_1_Romanov_Lab2DataSet;
            // 
            // _ISTB_18_1_Romanov_Lab2DataSet
            // 
            this._ISTB_18_1_Romanov_Lab2DataSet.DataSetName = "_ISTB_18_1_Romanov_Lab2DataSet";
            this._ISTB_18_1_Romanov_Lab2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gildViewBindingSource
            // 
            this.gildViewBindingSource.DataMember = "Gild_View";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-JILB1LC\\SQLEXPRESS;Initial Catalog=ISTB-18-1_Romanov_Lab2;Int" +
    "egrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.Bench_Select";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.Станок_добавление";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@work_time", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@mod_count", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@work_type", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@gild_number", System.Data.SqlDbType.TinyInt, 1)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "dbo.Станок_обновление";
            this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@work_time", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@mod_count", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@work_type", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@gild_number", System.Data.SqlDbType.TinyInt, 1)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "dbo.Станок_удаление";
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
            new System.Data.Common.DataTableMapping("Table", "Bench_Select", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Номер станка", "Номер станка"),
                        new System.Data.Common.DataColumnMapping("Время работы", "Время работы"),
                        new System.Data.Common.DataColumnMapping("Кол-во произвед. мод.", "Кол-во произвед. мод."),
                        new System.Data.Common.DataColumnMapping("Вид работы", "Вид работы"),
                        new System.Data.Common.DataColumnMapping("Номер цеха", "Номер цеха")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // bench_SelectTableAdapter
            // 
            this.bench_SelectTableAdapter.ClearBeforeFill = true;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "dbo.Gild_Select";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // comboBoxAdapter
            // 
            this.comboBoxAdapter.SelectCommand = this.sqlSelectCommand2;
            this.comboBoxAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Gild_Select", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Номер цеха", "Номер цеха"),
                        new System.Data.Common.DataColumnMapping("ФИО начальника", "ФИО начальника")})});
            // 
            // gild_SelectTableAdapter
            // 
            this.gild_SelectTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(865, 552);
            this.Controls.Add(this.cbGild);
            this.Controls.Add(this.btnUpdateBench);
            this.Controls.Add(this.btnFindBench);
            this.Controls.Add(this.btnDelBench);
            this.Controls.Add(this.btnAddBench);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbWorkType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbModCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWorkTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBenchNumber);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Станки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benchSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gildSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gildViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbBenchNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWorkTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWorkType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddBench;
        private System.Windows.Forms.Button btnDelBench;
        private System.Windows.Forms.Button btnFindBench;
        private System.Windows.Forms.Button btnUpdateBench;
        private System.Windows.Forms.ComboBox cbGild;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private _ISTB_18_1_Romanov_Lab2DataSet1 _ISTB_18_1_Romanov_Lab2DataSet1;
        private System.Windows.Forms.BindingSource benchSelectBindingSource;
        private _ISTB_18_1_Romanov_Lab2DataSet1TableAdapters.Bench_SelectTableAdapter bench_SelectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСтанкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоПроизведМодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЦехаDataGridViewTextBoxColumn;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter comboBoxAdapter;
        private System.Windows.Forms.BindingSource gildViewBindingSource;
        private _ISTB_18_1_Romanov_Lab2DataSet _ISTB_18_1_Romanov_Lab2DataSet;
        private System.Windows.Forms.BindingSource gildSelectBindingSource;
        private _ISTB_18_1_Romanov_Lab2DataSetTableAdapters.Gild_SelectTableAdapter gild_SelectTableAdapter;
    }
}

