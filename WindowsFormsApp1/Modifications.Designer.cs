
namespace WindowsFormsApp1
{
    partial class Modifications
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
            this.btnUpdateMod = new System.Windows.Forms.Button();
            this.btnFindMod = new System.Windows.Forms.Button();
            this.btnDelMod = new System.Windows.Forms.Button();
            this.btnAddMod = new System.Windows.Forms.Button();
            this.cbBench = new System.Windows.Forms.ComboBox();
            this.benchViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ISTB_18_1_Romanov_Lab2DataSet3 = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet3();
            this.tbModType = new System.Windows.Forms.TextBox();
            this.tbCreationTime = new System.Windows.Forms.TextBox();
            this.tbModName = new System.Windows.Forms.TextBox();
            this.tbModNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDetail = new System.Windows.Forms.ComboBox();
            this.detailviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ISTB_18_1_Romanov_Lab2DataSet4 = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet4();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерМодификацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеМодификацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяИзготовленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типМодификацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерСтанкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерДеталиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ISTB_18_1_Romanov_Lab2DataSet6 = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet6();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDetailAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlBenchAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.bench_ViewTableAdapter = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet3TableAdapters.Bench_ViewTableAdapter();
            this.detail_viewTableAdapter = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet4TableAdapters.Detail_viewTableAdapter();
            this.mod_SelectTableAdapter = new WindowsFormsApp1._ISTB_18_1_Romanov_Lab2DataSet6TableAdapters.Mod_SelectTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.benchViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateMod
            // 
            this.btnUpdateMod.Location = new System.Drawing.Point(383, 459);
            this.btnUpdateMod.Name = "btnUpdateMod";
            this.btnUpdateMod.Size = new System.Drawing.Size(104, 39);
            this.btnUpdateMod.TabIndex = 18;
            this.btnUpdateMod.Text = "Изменить";
            this.btnUpdateMod.UseVisualStyleBackColor = true;
            this.btnUpdateMod.Click += new System.EventHandler(this.btnUpdateMod_Click);
            // 
            // btnFindMod
            // 
            this.btnFindMod.Location = new System.Drawing.Point(278, 459);
            this.btnFindMod.Name = "btnFindMod";
            this.btnFindMod.Size = new System.Drawing.Size(75, 39);
            this.btnFindMod.TabIndex = 17;
            this.btnFindMod.Text = "Найти";
            this.btnFindMod.UseVisualStyleBackColor = true;
            this.btnFindMod.Click += new System.EventHandler(this.btnFindMod_Click);
            // 
            // btnDelMod
            // 
            this.btnDelMod.Location = new System.Drawing.Point(159, 459);
            this.btnDelMod.Name = "btnDelMod";
            this.btnDelMod.Size = new System.Drawing.Size(87, 39);
            this.btnDelMod.TabIndex = 16;
            this.btnDelMod.Text = "Удалить";
            this.btnDelMod.UseVisualStyleBackColor = true;
            this.btnDelMod.Click += new System.EventHandler(this.btnDelMod_Click);
            // 
            // btnAddMod
            // 
            this.btnAddMod.Location = new System.Drawing.Point(17, 458);
            this.btnAddMod.Name = "btnAddMod";
            this.btnAddMod.Size = new System.Drawing.Size(100, 41);
            this.btnAddMod.TabIndex = 15;
            this.btnAddMod.Text = "Добавить";
            this.btnAddMod.UseVisualStyleBackColor = true;
            this.btnAddMod.Click += new System.EventHandler(this.btnAddMod_Click);
            // 
            // cbBench
            // 
            this.cbBench.DataSource = this.benchViewBindingSource;
            this.cbBench.DisplayMember = "Номер станка";
            this.cbBench.FormattingEnabled = true;
            this.cbBench.Location = new System.Drawing.Point(567, 406);
            this.cbBench.Name = "cbBench";
            this.cbBench.Size = new System.Drawing.Size(121, 28);
            this.cbBench.TabIndex = 23;
            this.cbBench.ValueMember = "Номер станка";
            // 
            // benchViewBindingSource
            // 
            this.benchViewBindingSource.DataMember = "Bench_View";
            this.benchViewBindingSource.DataSource = this._ISTB_18_1_Romanov_Lab2DataSet3;
            // 
            // _ISTB_18_1_Romanov_Lab2DataSet3
            // 
            this._ISTB_18_1_Romanov_Lab2DataSet3.DataSetName = "_ISTB_18_1_Romanov_Lab2DataSet3";
            this._ISTB_18_1_Romanov_Lab2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbModType
            // 
            this.tbModType.Location = new System.Drawing.Point(439, 407);
            this.tbModType.Name = "tbModType";
            this.tbModType.Size = new System.Drawing.Size(96, 26);
            this.tbModType.TabIndex = 22;
            // 
            // tbCreationTime
            // 
            this.tbCreationTime.Location = new System.Drawing.Point(300, 406);
            this.tbCreationTime.Name = "tbCreationTime";
            this.tbCreationTime.Size = new System.Drawing.Size(114, 26);
            this.tbCreationTime.TabIndex = 21;
            // 
            // tbModName
            // 
            this.tbModName.Location = new System.Drawing.Point(159, 407);
            this.tbModName.Name = "tbModName";
            this.tbModName.Size = new System.Drawing.Size(111, 26);
            this.tbModName.TabIndex = 20;
            // 
            // tbModNumber
            // 
            this.tbModNumber.Location = new System.Drawing.Point(17, 407);
            this.tbModNumber.Name = "tbModNumber";
            this.tbModNumber.Size = new System.Drawing.Size(115, 26);
            this.tbModNumber.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Номер станка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Тип мод";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 40);
            this.label3.TabIndex = 26;
            this.label3.Text = "Время \r\nизготовления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Название мод";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Номер мод";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Номер детали";
            // 
            // cbDetail
            // 
            this.cbDetail.DataSource = this.detailviewBindingSource;
            this.cbDetail.DisplayMember = "Номер детали";
            this.cbDetail.FormattingEnabled = true;
            this.cbDetail.Location = new System.Drawing.Point(719, 404);
            this.cbDetail.Name = "cbDetail";
            this.cbDetail.Size = new System.Drawing.Size(121, 28);
            this.cbDetail.TabIndex = 29;
            this.cbDetail.ValueMember = "Номер детали";
            // 
            // detailviewBindingSource
            // 
            this.detailviewBindingSource.DataMember = "Detail_view";
            this.detailviewBindingSource.DataSource = this._ISTB_18_1_Romanov_Lab2DataSet4;
            // 
            // _ISTB_18_1_Romanov_Lab2DataSet4
            // 
            this._ISTB_18_1_Romanov_Lab2DataSet4.DataSetName = "_ISTB_18_1_Romanov_Lab2DataSet4";
            this._ISTB_18_1_Romanov_Lab2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерМодификацииDataGridViewTextBoxColumn,
            this.названиеМодификацииDataGridViewTextBoxColumn,
            this.времяИзготовленияDataGridViewTextBoxColumn,
            this.типМодификацииDataGridViewTextBoxColumn,
            this.номерСтанкаDataGridViewTextBoxColumn,
            this.номерДеталиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modSelectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 320);
            this.dataGridView1.TabIndex = 31;
            // 
            // номерМодификацииDataGridViewTextBoxColumn
            // 
            this.номерМодификацииDataGridViewTextBoxColumn.DataPropertyName = "Номер модификации";
            this.номерМодификацииDataGridViewTextBoxColumn.HeaderText = "Номер модификации";
            this.номерМодификацииDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерМодификацииDataGridViewTextBoxColumn.Name = "номерМодификацииDataGridViewTextBoxColumn";
            this.номерМодификацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерМодификацииDataGridViewTextBoxColumn.Width = 189;
            // 
            // названиеМодификацииDataGridViewTextBoxColumn
            // 
            this.названиеМодификацииDataGridViewTextBoxColumn.DataPropertyName = "Название модификации";
            this.названиеМодификацииDataGridViewTextBoxColumn.HeaderText = "Название модификации";
            this.названиеМодификацииDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.названиеМодификацииDataGridViewTextBoxColumn.Name = "названиеМодификацииDataGridViewTextBoxColumn";
            this.названиеМодификацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеМодификацииDataGridViewTextBoxColumn.Width = 211;
            // 
            // времяИзготовленияDataGridViewTextBoxColumn
            // 
            this.времяИзготовленияDataGridViewTextBoxColumn.DataPropertyName = "Время изготовления";
            this.времяИзготовленияDataGridViewTextBoxColumn.HeaderText = "Время изготовления";
            this.времяИзготовленияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.времяИзготовленияDataGridViewTextBoxColumn.Name = "времяИзготовленияDataGridViewTextBoxColumn";
            this.времяИзготовленияDataGridViewTextBoxColumn.ReadOnly = true;
            this.времяИзготовленияDataGridViewTextBoxColumn.Width = 187;
            // 
            // типМодификацииDataGridViewTextBoxColumn
            // 
            this.типМодификацииDataGridViewTextBoxColumn.DataPropertyName = "Тип модификации";
            this.типМодификацииDataGridViewTextBoxColumn.HeaderText = "Тип модификации";
            this.типМодификацииDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.типМодификацииDataGridViewTextBoxColumn.Name = "типМодификацииDataGridViewTextBoxColumn";
            this.типМодификацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.типМодификацииDataGridViewTextBoxColumn.Width = 169;
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
            // номерДеталиDataGridViewTextBoxColumn
            // 
            this.номерДеталиDataGridViewTextBoxColumn.DataPropertyName = "Номер детали";
            this.номерДеталиDataGridViewTextBoxColumn.HeaderText = "Номер детали";
            this.номерДеталиDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.номерДеталиDataGridViewTextBoxColumn.Name = "номерДеталиDataGridViewTextBoxColumn";
            this.номерДеталиDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерДеталиDataGridViewTextBoxColumn.Width = 143;
            // 
            // modSelectBindingSource
            // 
            this.modSelectBindingSource.DataMember = "Mod_Select";
            this.modSelectBindingSource.DataSource = this._ISTB_18_1_Romanov_Lab2DataSet6;
            // 
            // _ISTB_18_1_Romanov_Lab2DataSet6
            // 
            this._ISTB_18_1_Romanov_Lab2DataSet6.DataSetName = "_ISTB_18_1_Romanov_Lab2DataSet6";
            this._ISTB_18_1_Romanov_Lab2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-JILB1LC\\SQLEXPRESS;Initial Catalog=ISTB-18-1_Romanov_Lab2;Int" +
    "egrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.Mod_Select";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.Мод_добавление";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@mod_name", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@creation_time", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@mod_type", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@bench_number", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@detail_number", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "dbo.Мод_обновление";
            this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@mod_name", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@creation_time", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@mod_type", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@bench_number", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@detail_number", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "dbo.Мод_удаление";
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
            new System.Data.Common.DataTableMapping("Table", "Mod_Select", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Номер модификации", "Номер модификации"),
                        new System.Data.Common.DataColumnMapping("Название модификации", "Название модификации"),
                        new System.Data.Common.DataColumnMapping("Время изготовления", "Время изготовления"),
                        new System.Data.Common.DataColumnMapping("Тип модификации", "Тип модификации"),
                        new System.Data.Common.DataColumnMapping("Номер станка", "Номер станка"),
                        new System.Data.Common.DataColumnMapping("Номер детали", "Номер детали")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "dbo.Detail_Select";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlDetailAdapter
            // 
            this.sqlDetailAdapter.SelectCommand = this.sqlSelectCommand2;
            this.sqlDetailAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Detail_Select", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Номер детали", "Номер детали"),
                        new System.Data.Common.DataColumnMapping("Название детали", "Название детали"),
                        new System.Data.Common.DataColumnMapping("Дата привоза", "Дата привоза"),
                        new System.Data.Common.DataColumnMapping("Вид детали", "Вид детали")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "dbo.Bench_Select";
            this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlBenchAdapter
            // 
            this.sqlBenchAdapter.SelectCommand = this.sqlSelectCommand3;
            this.sqlBenchAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Bench_Select", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Номер станка", "Номер станка"),
                        new System.Data.Common.DataColumnMapping("Время работы", "Время работы"),
                        new System.Data.Common.DataColumnMapping("Кол-во произвед. мод.", "Кол-во произвед. мод."),
                        new System.Data.Common.DataColumnMapping("Вид работы", "Вид работы"),
                        new System.Data.Common.DataColumnMapping("Номер цеха", "Номер цеха")})});
            // 
            // bench_ViewTableAdapter
            // 
            this.bench_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // detail_viewTableAdapter
            // 
            this.detail_viewTableAdapter.ClearBeforeFill = true;
            // 
            // mod_SelectTableAdapter
            // 
            this.mod_SelectTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Modifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDetail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBench);
            this.Controls.Add(this.tbModType);
            this.Controls.Add(this.tbCreationTime);
            this.Controls.Add(this.tbModName);
            this.Controls.Add(this.tbModNumber);
            this.Controls.Add(this.btnUpdateMod);
            this.Controls.Add(this.btnFindMod);
            this.Controls.Add(this.btnDelMod);
            this.Controls.Add(this.btnAddMod);
            this.Name = "Modifications";
            this.Text = "Modifications";
            this.Load += new System.EventHandler(this.Modifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.benchViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISTB_18_1_Romanov_Lab2DataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateMod;
        private System.Windows.Forms.Button btnFindMod;
        private System.Windows.Forms.Button btnDelMod;
        private System.Windows.Forms.Button btnAddMod;
        private System.Windows.Forms.ComboBox cbBench;
        private System.Windows.Forms.TextBox tbModType;
        private System.Windows.Forms.TextBox tbCreationTime;
        private System.Windows.Forms.TextBox tbModName;
        private System.Windows.Forms.TextBox tbModNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDetail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерМодификацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеМодификацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяИзготовленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типМодификацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСтанкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДеталиDataGridViewTextBoxColumn;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDetailAdapter;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlDataAdapter sqlBenchAdapter;
        private _ISTB_18_1_Romanov_Lab2DataSet3 _ISTB_18_1_Romanov_Lab2DataSet3;
        private System.Windows.Forms.BindingSource benchViewBindingSource;
        private _ISTB_18_1_Romanov_Lab2DataSet3TableAdapters.Bench_ViewTableAdapter bench_ViewTableAdapter;
        private _ISTB_18_1_Romanov_Lab2DataSet4 _ISTB_18_1_Romanov_Lab2DataSet4;
        private System.Windows.Forms.BindingSource detailviewBindingSource;
        private _ISTB_18_1_Romanov_Lab2DataSet4TableAdapters.Detail_viewTableAdapter detail_viewTableAdapter;
        private _ISTB_18_1_Romanov_Lab2DataSet6 _ISTB_18_1_Romanov_Lab2DataSet6;
        private System.Windows.Forms.BindingSource modSelectBindingSource;
        private _ISTB_18_1_Romanov_Lab2DataSet6TableAdapters.Mod_SelectTableAdapter mod_SelectTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}