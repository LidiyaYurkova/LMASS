namespace LMASS
{
    partial class Category
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
            this.CategoryGridView = new System.Windows.Forms.DataGridView();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDataSet = new LMASS.CategoryDataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.ImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.personTableAdapter = new LMASS.CategoryDataSetTableAdapters.PersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // CategoryGridView
            // 
            this.CategoryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryGridView.AutoGenerateColumns = false;
            this.CategoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.iDDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.Email,
            this.p1DataGridViewTextBoxColumn,
            this.p2DataGridViewTextBoxColumn,
            this.p3DataGridViewTextBoxColumn,
            this.p4DataGridViewTextBoxColumn,
            this.p5DataGridViewTextBoxColumn,
            this.p6DataGridViewTextBoxColumn,
            this.p7DataGridViewTextBoxColumn,
            this.p8DataGridViewTextBoxColumn,
            this.p9DataGridViewTextBoxColumn,
            this.p10DataGridViewTextBoxColumn});
            this.CategoryGridView.DataSource = this.personBindingSource;
            this.CategoryGridView.Location = new System.Drawing.Point(3, 2);
            this.CategoryGridView.Name = "CategoryGridView";
            this.CategoryGridView.Size = new System.Drawing.Size(745, 226);
            this.CategoryGridView.TabIndex = 0;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // p1DataGridViewTextBoxColumn
            // 
            this.p1DataGridViewTextBoxColumn.DataPropertyName = "p1";
            this.p1DataGridViewTextBoxColumn.HeaderText = "p1";
            this.p1DataGridViewTextBoxColumn.Name = "p1DataGridViewTextBoxColumn";
            // 
            // p2DataGridViewTextBoxColumn
            // 
            this.p2DataGridViewTextBoxColumn.DataPropertyName = "p2";
            this.p2DataGridViewTextBoxColumn.HeaderText = "p2";
            this.p2DataGridViewTextBoxColumn.Name = "p2DataGridViewTextBoxColumn";
            // 
            // p3DataGridViewTextBoxColumn
            // 
            this.p3DataGridViewTextBoxColumn.DataPropertyName = "p3";
            this.p3DataGridViewTextBoxColumn.HeaderText = "p3";
            this.p3DataGridViewTextBoxColumn.Name = "p3DataGridViewTextBoxColumn";
            // 
            // p4DataGridViewTextBoxColumn
            // 
            this.p4DataGridViewTextBoxColumn.DataPropertyName = "p4";
            this.p4DataGridViewTextBoxColumn.HeaderText = "p4";
            this.p4DataGridViewTextBoxColumn.Name = "p4DataGridViewTextBoxColumn";
            // 
            // p5DataGridViewTextBoxColumn
            // 
            this.p5DataGridViewTextBoxColumn.DataPropertyName = "p5";
            this.p5DataGridViewTextBoxColumn.HeaderText = "p5";
            this.p5DataGridViewTextBoxColumn.Name = "p5DataGridViewTextBoxColumn";
            // 
            // p6DataGridViewTextBoxColumn
            // 
            this.p6DataGridViewTextBoxColumn.DataPropertyName = "p6";
            this.p6DataGridViewTextBoxColumn.HeaderText = "p6";
            this.p6DataGridViewTextBoxColumn.Name = "p6DataGridViewTextBoxColumn";
            // 
            // p7DataGridViewTextBoxColumn
            // 
            this.p7DataGridViewTextBoxColumn.DataPropertyName = "p7";
            this.p7DataGridViewTextBoxColumn.HeaderText = "p7";
            this.p7DataGridViewTextBoxColumn.Name = "p7DataGridViewTextBoxColumn";
            // 
            // p8DataGridViewTextBoxColumn
            // 
            this.p8DataGridViewTextBoxColumn.DataPropertyName = "p8";
            this.p8DataGridViewTextBoxColumn.HeaderText = "p8";
            this.p8DataGridViewTextBoxColumn.Name = "p8DataGridViewTextBoxColumn";
            // 
            // p9DataGridViewTextBoxColumn
            // 
            this.p9DataGridViewTextBoxColumn.DataPropertyName = "p9";
            this.p9DataGridViewTextBoxColumn.HeaderText = "p9";
            this.p9DataGridViewTextBoxColumn.Name = "p9DataGridViewTextBoxColumn";
            // 
            // p10DataGridViewTextBoxColumn
            // 
            this.p10DataGridViewTextBoxColumn.DataPropertyName = "p10";
            this.p10DataGridViewTextBoxColumn.HeaderText = "p10";
            this.p10DataGridViewTextBoxColumn.Name = "p10DataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.categoryDataSet;
            // 
            // categoryDataSet
            // 
            this.categoryDataSet.DataSetName = "CategoryDataSet";
            this.categoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(342, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnImport.Location = new System.Drawing.Point(3, 234);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Импорт";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ImportFileDialog
            // 
            this.ImportFileDialog.FileName = "openFileDialog1";
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // Category
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(752, 261);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.CategoryGridView);
            this.Name = "Category";
            this.Text = "Категория";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView CategoryGridView;
        private System.Windows.Forms.Button btnSave;
        private CategoryDataSet categoryDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private CategoryDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog ImportFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn p1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p10DataGridViewTextBoxColumn;
    }
}