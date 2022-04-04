
namespace DBtoExcelExporter
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
            this.yandexDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yandexDataSet = new DBtoExcelExporter.YandexDataSet();
            this.Exportbtn = new System.Windows.Forms.Button();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesTableAdapter = new DBtoExcelExporter.YandexDataSetTableAdapters.CitiesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.citiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companiesTableAdapter = new DBtoExcelExporter.YandexDataSetTableAdapters.CompaniesTableAdapter();
            this.citiesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesTableAdapter1 = new DBtoExcelExporter.YandexDataSetTableAdapters.CountriesTableAdapter();
            this.citiesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foundedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yandexDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yandexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.foundedDataGridViewTextBoxColumn,
            this.countryidDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Cities";
            this.dataGridView1.DataSource = this.yandexDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(679, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataMemberChanged += new System.EventHandler(this.dataGridView1_DataMemberChanged);
            // 
            // yandexDataSetBindingSource
            // 
            this.yandexDataSetBindingSource.DataSource = this.yandexDataSet;
            this.yandexDataSetBindingSource.Position = 0;
            // 
            // yandexDataSet
            // 
            this.yandexDataSet.DataSetName = "YandexDataSet";
            this.yandexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Exportbtn
            // 
            this.Exportbtn.Location = new System.Drawing.Point(12, 368);
            this.Exportbtn.Name = "Exportbtn";
            this.Exportbtn.Size = new System.Drawing.Size(204, 23);
            this.Exportbtn.TabIndex = 1;
            this.Exportbtn.Text = "Click to Export";
            this.Exportbtn.UseVisualStyleBackColor = true;
            this.Exportbtn.Click += new System.EventHandler(this.Exportbtn_Click);
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.yandexDataSetBindingSource;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 329);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // citiesBindingSource1
            // 
            this.citiesBindingSource1.DataMember = "Cities";
            this.citiesBindingSource1.DataSource = this.yandexDataSetBindingSource;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            this.companiesBindingSource.DataSource = this.yandexDataSetBindingSource;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // citiesBindingSource2
            // 
            this.citiesBindingSource2.DataMember = "Cities";
            this.citiesBindingSource2.DataSource = this.yandexDataSetBindingSource;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.yandexDataSetBindingSource;
            // 
            // countriesTableAdapter1
            // 
            this.countriesTableAdapter1.ClearBeforeFill = true;
            // 
            // citiesBindingSource3
            // 
            this.citiesBindingSource3.DataMember = "Cities";
            this.citiesBindingSource3.DataSource = this.yandexDataSetBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "population";
            this.populationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.Width = 125;
            // 
            // foundedDataGridViewTextBoxColumn
            // 
            this.foundedDataGridViewTextBoxColumn.DataPropertyName = "founded";
            this.foundedDataGridViewTextBoxColumn.HeaderText = "founded";
            this.foundedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foundedDataGridViewTextBoxColumn.Name = "foundedDataGridViewTextBoxColumn";
            this.foundedDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryidDataGridViewTextBoxColumn
            // 
            this.countryidDataGridViewTextBoxColumn.DataPropertyName = "country_id";
            this.countryidDataGridViewTextBoxColumn.HeaderText = "country_id";
            this.countryidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryidDataGridViewTextBoxColumn.Name = "countryidDataGridViewTextBoxColumn";
            this.countryidDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.cityidDataGridViewTextBoxColumn,
            this.revenueDataGridViewTextBoxColumn,
            this.laborsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.companiesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(697, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(674, 318);
            this.dataGridView2.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cityidDataGridViewTextBoxColumn
            // 
            this.cityidDataGridViewTextBoxColumn.DataPropertyName = "city_id";
            this.cityidDataGridViewTextBoxColumn.HeaderText = "city_id";
            this.cityidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityidDataGridViewTextBoxColumn.Name = "cityidDataGridViewTextBoxColumn";
            this.cityidDataGridViewTextBoxColumn.Width = 125;
            // 
            // revenueDataGridViewTextBoxColumn
            // 
            this.revenueDataGridViewTextBoxColumn.DataPropertyName = "revenue";
            this.revenueDataGridViewTextBoxColumn.HeaderText = "revenue";
            this.revenueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.revenueDataGridViewTextBoxColumn.Name = "revenueDataGridViewTextBoxColumn";
            this.revenueDataGridViewTextBoxColumn.Width = 125;
            // 
            // laborsDataGridViewTextBoxColumn
            // 
            this.laborsDataGridViewTextBoxColumn.DataPropertyName = "labors";
            this.laborsDataGridViewTextBoxColumn.HeaderText = "labors";
            this.laborsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.laborsDataGridViewTextBoxColumn.Name = "laborsDataGridViewTextBoxColumn";
            this.laborsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.populationDataGridViewTextBoxColumn1,
            this.gdpDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.countriesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(697, 336);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(674, 253);
            this.dataGridView3.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.Width = 125;
            // 
            // populationDataGridViewTextBoxColumn1
            // 
            this.populationDataGridViewTextBoxColumn1.DataPropertyName = "population";
            this.populationDataGridViewTextBoxColumn1.HeaderText = "population";
            this.populationDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.populationDataGridViewTextBoxColumn1.Name = "populationDataGridViewTextBoxColumn1";
            this.populationDataGridViewTextBoxColumn1.Width = 125;
            // 
            // gdpDataGridViewTextBoxColumn
            // 
            this.gdpDataGridViewTextBoxColumn.DataPropertyName = "gdp";
            this.gdpDataGridViewTextBoxColumn.HeaderText = "gdp";
            this.gdpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gdpDataGridViewTextBoxColumn.Name = "gdpDataGridViewTextBoxColumn";
            this.gdpDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 1106);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Exportbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yandexDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yandexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Exportbtn;
        private System.Windows.Forms.BindingSource yandexDataSetBindingSource;
        private YandexDataSet yandexDataSet;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private YandexDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private YandexDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource citiesBindingSource1;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private YandexDataSetTableAdapters.CompaniesTableAdapter companiesTableAdapter;
        private System.Windows.Forms.BindingSource citiesBindingSource2;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private YandexDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter1;
        private System.Windows.Forms.BindingSource citiesBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foundedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdpDataGridViewTextBoxColumn;
    }
}

