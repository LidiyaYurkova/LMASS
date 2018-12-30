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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.personTableAdapter = new LMASS.CategoryDataSetTableAdapters.PersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.iDDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
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
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
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
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // Category
            // 
            this.ClientSize = new System.Drawing.Size(752, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Category";
            this.Text = "Категория";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private CategoryDataSet categoryDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private CategoryDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
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