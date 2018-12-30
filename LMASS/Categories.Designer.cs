namespace LMASS
{
    partial class Categories
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesDataSet = new LMASS.CategoriesDataSet();
            this.categoryTableAdapter = new LMASS.CategoriesDataSetTableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Для просмотра данных категории нажмите на её номер";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.columnName1DataGridViewTextBoxColumn,
            this.columnName2DataGridViewTextBoxColumn,
            this.columnName3DataGridViewTextBoxColumn,
            this.columnName4DataGridViewTextBoxColumn,
            this.columnName5DataGridViewTextBoxColumn,
            this.columnName6DataGridViewTextBoxColumn,
            this.columnName7DataGridViewTextBoxColumn,
            this.columnName8DataGridViewTextBoxColumn,
            this.columnName9DataGridViewTextBoxColumn,
            this.columnName10DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Название категории";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // columnName1DataGridViewTextBoxColumn
            // 
            this.columnName1DataGridViewTextBoxColumn.DataPropertyName = "ColumnName1";
            this.columnName1DataGridViewTextBoxColumn.HeaderText = "Название поля";
            this.columnName1DataGridViewTextBoxColumn.Name = "columnName1DataGridViewTextBoxColumn";
            // 
            // columnName2DataGridViewTextBoxColumn
            // 
            this.columnName2DataGridViewTextBoxColumn.DataPropertyName = "ColumnName2";
            this.columnName2DataGridViewTextBoxColumn.HeaderText = "Название поля";
            this.columnName2DataGridViewTextBoxColumn.Name = "columnName2DataGridViewTextBoxColumn";
            // 
            // columnName3DataGridViewTextBoxColumn
            // 
            this.columnName3DataGridViewTextBoxColumn.DataPropertyName = "ColumnName3";
            this.columnName3DataGridViewTextBoxColumn.HeaderText = "Название поля";
            this.columnName3DataGridViewTextBoxColumn.Name = "columnName3DataGridViewTextBoxColumn";
            // 
            // columnName4DataGridViewTextBoxColumn
            // 
            this.columnName4DataGridViewTextBoxColumn.DataPropertyName = "ColumnName4";
            this.columnName4DataGridViewTextBoxColumn.HeaderText = "Название поля";
            this.columnName4DataGridViewTextBoxColumn.Name = "columnName4DataGridViewTextBoxColumn";
            // 
            // columnName5DataGridViewTextBoxColumn
            // 
            this.columnName5DataGridViewTextBoxColumn.DataPropertyName = "ColumnName5";
            this.columnName5DataGridViewTextBoxColumn.HeaderText = "Название поля";
            this.columnName5DataGridViewTextBoxColumn.Name = "columnName5DataGridViewTextBoxColumn";
            // 
            // columnName6DataGridViewTextBoxColumn
            // 
            this.columnName6DataGridViewTextBoxColumn.DataPropertyName = "ColumnName6";
            this.columnName6DataGridViewTextBoxColumn.HeaderText = "Название поля";
            this.columnName6DataGridViewTextBoxColumn.Name = "columnName6DataGridViewTextBoxColumn";
            // 
            // columnName7DataGridViewTextBoxColumn
            // 
            this.columnName7DataGridViewTextBoxColumn.DataPropertyName = "ColumnName7";
            this.columnName7DataGridViewTextBoxColumn.HeaderText = "Название поля";
            this.columnName7DataGridViewTextBoxColumn.Name = "columnName7DataGridViewTextBoxColumn";
            // 
            // columnName8DataGridViewTextBoxColumn
            // 
            this.columnName8DataGridViewTextBoxColumn.DataPropertyName = "ColumnName8";
            this.columnName8DataGridViewTextBoxColumn.HeaderText = "Название поля";
            this.columnName8DataGridViewTextBoxColumn.Name = "columnName8DataGridViewTextBoxColumn";
            // 
            // columnName9DataGridViewTextBoxColumn
            // 
            this.columnName9DataGridViewTextBoxColumn.DataPropertyName = "ColumnName9";
            this.columnName9DataGridViewTextBoxColumn.HeaderText = "Название поля";
            this.columnName9DataGridViewTextBoxColumn.Name = "columnName9DataGridViewTextBoxColumn";
            // 
            // columnName10DataGridViewTextBoxColumn
            // 
            this.columnName10DataGridViewTextBoxColumn.DataPropertyName = "ColumnName10";
            this.columnName10DataGridViewTextBoxColumn.HeaderText = "Название поля";
            this.columnName10DataGridViewTextBoxColumn.Name = "columnName10DataGridViewTextBoxColumn";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.categoriesDataSet;
            // 
            // categoriesDataSet
            // 
            this.categoriesDataSet.DataSetName = "CategoriesDataSet";
            this.categoriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Categories";
            this.Text = "Категории";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName10DataGridViewTextBoxColumn;
        private CategoriesDataSet categoriesDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private CategoriesDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
    }
}