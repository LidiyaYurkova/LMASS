﻿namespace LMASS
{
    partial class CategoryList
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
            this.btnOk = new System.Windows.Forms.Button();
            this.CategoryListGridView = new System.Windows.Forms.DataGridView();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryListDataSet = new LMASS.CategoryListDataSet();
            this.categoryTableAdapter = new LMASS.CategoryListDataSetTableAdapters.CategoryTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOk.BackgroundImage = global::LMASS.Properties.Resources.background;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOk.Location = new System.Drawing.Point(102, 321);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 30);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // CategoryListGridView
            // 
            this.CategoryListGridView.AllowUserToAddRows = false;
            this.CategoryListGridView.AllowUserToDeleteRows = false;
            this.CategoryListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryListGridView.AutoGenerateColumns = false;
            this.CategoryListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryListGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.CategoryListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.categoryNameDataGridViewTextBoxColumn,
            this.Column1});
            this.CategoryListGridView.DataSource = this.categoryBindingSource;
            this.CategoryListGridView.Location = new System.Drawing.Point(0, 0);
            this.CategoryListGridView.Name = "CategoryListGridView";
            this.CategoryListGridView.Size = new System.Drawing.Size(286, 321);
            this.CategoryListGridView.TabIndex = 2;
            this.CategoryListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryListGridView_CellContentClick);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.categoryListDataSet;
            // 
            // categoryListDataSet
            // 
            this.categoryListDataSet.DataSetName = "CategoryListDataSet";
            this.categoryListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.FillWeight = 169.5432F;
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Название категории";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30.45685F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CategoryList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::LMASS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(286, 351);
            this.Controls.Add(this.CategoryListGridView);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CategoryList";
            this.Text = "Список категорий";
            this.Load += new System.EventHandler(this.CategoryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView CategoryListGridView;
        private CategoryListDataSet categoryListDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private CategoryListDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}