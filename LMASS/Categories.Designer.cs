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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CategoriesGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.BackgroundImage = global::LMASS.Properties.Resources.background;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Name = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CategoriesGridView
            // 
            resources.ApplyResources(this.CategoriesGridView, "CategoriesGridView");
            this.CategoriesGridView.AutoGenerateColumns = false;
            this.CategoriesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoriesGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.CategoriesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.CategoriesGridView.DataSource = this.categoryBindingSource;
            this.CategoriesGridView.Name = "CategoriesGridView";
            this.CategoriesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesGridView_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            resources.ApplyResources(this.categoryNameDataGridViewTextBoxColumn, "categoryNameDataGridViewTextBoxColumn");
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // columnName1DataGridViewTextBoxColumn
            // 
            this.columnName1DataGridViewTextBoxColumn.DataPropertyName = "ColumnName1";
            resources.ApplyResources(this.columnName1DataGridViewTextBoxColumn, "columnName1DataGridViewTextBoxColumn");
            this.columnName1DataGridViewTextBoxColumn.Name = "columnName1DataGridViewTextBoxColumn";
            // 
            // columnName2DataGridViewTextBoxColumn
            // 
            this.columnName2DataGridViewTextBoxColumn.DataPropertyName = "ColumnName2";
            resources.ApplyResources(this.columnName2DataGridViewTextBoxColumn, "columnName2DataGridViewTextBoxColumn");
            this.columnName2DataGridViewTextBoxColumn.Name = "columnName2DataGridViewTextBoxColumn";
            // 
            // columnName3DataGridViewTextBoxColumn
            // 
            this.columnName3DataGridViewTextBoxColumn.DataPropertyName = "ColumnName3";
            resources.ApplyResources(this.columnName3DataGridViewTextBoxColumn, "columnName3DataGridViewTextBoxColumn");
            this.columnName3DataGridViewTextBoxColumn.Name = "columnName3DataGridViewTextBoxColumn";
            // 
            // columnName4DataGridViewTextBoxColumn
            // 
            this.columnName4DataGridViewTextBoxColumn.DataPropertyName = "ColumnName4";
            resources.ApplyResources(this.columnName4DataGridViewTextBoxColumn, "columnName4DataGridViewTextBoxColumn");
            this.columnName4DataGridViewTextBoxColumn.Name = "columnName4DataGridViewTextBoxColumn";
            // 
            // columnName5DataGridViewTextBoxColumn
            // 
            this.columnName5DataGridViewTextBoxColumn.DataPropertyName = "ColumnName5";
            resources.ApplyResources(this.columnName5DataGridViewTextBoxColumn, "columnName5DataGridViewTextBoxColumn");
            this.columnName5DataGridViewTextBoxColumn.Name = "columnName5DataGridViewTextBoxColumn";
            // 
            // columnName6DataGridViewTextBoxColumn
            // 
            this.columnName6DataGridViewTextBoxColumn.DataPropertyName = "ColumnName6";
            resources.ApplyResources(this.columnName6DataGridViewTextBoxColumn, "columnName6DataGridViewTextBoxColumn");
            this.columnName6DataGridViewTextBoxColumn.Name = "columnName6DataGridViewTextBoxColumn";
            // 
            // columnName7DataGridViewTextBoxColumn
            // 
            this.columnName7DataGridViewTextBoxColumn.DataPropertyName = "ColumnName7";
            resources.ApplyResources(this.columnName7DataGridViewTextBoxColumn, "columnName7DataGridViewTextBoxColumn");
            this.columnName7DataGridViewTextBoxColumn.Name = "columnName7DataGridViewTextBoxColumn";
            // 
            // columnName8DataGridViewTextBoxColumn
            // 
            this.columnName8DataGridViewTextBoxColumn.DataPropertyName = "ColumnName8";
            resources.ApplyResources(this.columnName8DataGridViewTextBoxColumn, "columnName8DataGridViewTextBoxColumn");
            this.columnName8DataGridViewTextBoxColumn.Name = "columnName8DataGridViewTextBoxColumn";
            // 
            // columnName9DataGridViewTextBoxColumn
            // 
            this.columnName9DataGridViewTextBoxColumn.DataPropertyName = "ColumnName9";
            resources.ApplyResources(this.columnName9DataGridViewTextBoxColumn, "columnName9DataGridViewTextBoxColumn");
            this.columnName9DataGridViewTextBoxColumn.Name = "columnName9DataGridViewTextBoxColumn";
            // 
            // columnName10DataGridViewTextBoxColumn
            // 
            this.columnName10DataGridViewTextBoxColumn.DataPropertyName = "ColumnName10";
            resources.ApplyResources(this.columnName10DataGridViewTextBoxColumn, "columnName10DataGridViewTextBoxColumn");
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
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::LMASS.Properties.Resources.background;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.CategoriesGridView);
            this.Name = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView CategoriesGridView;
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