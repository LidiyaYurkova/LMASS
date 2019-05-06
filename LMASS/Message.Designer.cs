namespace LMASS
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.btnChooseCategory = new System.Windows.Forms.Button();
            this.tbTheme = new System.Windows.Forms.TextBox();
            this.rtbLetter = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnGetTemplate = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.btnAddValues = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.TemplateFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblSending = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooseCategory
            // 
            this.btnChooseCategory.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnChooseCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseCategory.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnChooseCategory.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnChooseCategory.Location = new System.Drawing.Point(13, 13);
            this.btnChooseCategory.Name = "btnChooseCategory";
            this.btnChooseCategory.Size = new System.Drawing.Size(102, 49);
            this.btnChooseCategory.TabIndex = 0;
            this.btnChooseCategory.Text = "Выберите категории";
            this.btnChooseCategory.UseVisualStyleBackColor = false;
            this.btnChooseCategory.Click += new System.EventHandler(this.btnChooseCategory_Click);
            // 
            // tbTheme
            // 
            this.tbTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTheme.BackColor = System.Drawing.Color.White;
            this.tbTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTheme.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbTheme.ForeColor = System.Drawing.Color.Black;
            this.tbTheme.Location = new System.Drawing.Point(13, 67);
            this.tbTheme.Name = "tbTheme";
            this.tbTheme.Size = new System.Drawing.Size(593, 23);
            this.tbTheme.TabIndex = 2;
            this.tbTheme.Text = "Тема письма";
            this.tbTheme.Enter += new System.EventHandler(this.tbTheme_Enter);
            this.tbTheme.Leave += new System.EventHandler(this.tbTheme_Leave);
            // 
            // rtbLetter
            // 
            this.rtbLetter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLetter.BackColor = System.Drawing.Color.White;
            this.rtbLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLetter.Font = new System.Drawing.Font("Arial", 10F);
            this.rtbLetter.ForeColor = System.Drawing.Color.Black;
            this.rtbLetter.Location = new System.Drawing.Point(13, 93);
            this.rtbLetter.Name = "rtbLetter";
            this.rtbLetter.Size = new System.Drawing.Size(593, 423);
            this.rtbLetter.TabIndex = 3;
            this.rtbLetter.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.BackColor = System.Drawing.Color.MintCream;
            this.btnSend.Enabled = false;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSend.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSend.Location = new System.Drawing.Point(13, 530);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 46);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnGetTemplate
            // 
            this.btnGetTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetTemplate.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGetTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetTemplate.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGetTemplate.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGetTemplate.Location = new System.Drawing.Point(405, 13);
            this.btnGetTemplate.Name = "btnGetTemplate";
            this.btnGetTemplate.Size = new System.Drawing.Size(96, 49);
            this.btnGetTemplate.TabIndex = 5;
            this.btnGetTemplate.Text = "Загрузить шаблон";
            this.btnGetTemplate.UseVisualStyleBackColor = false;
            this.btnGetTemplate.Click += new System.EventHandler(this.btnGetTemplate_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTemplate.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSaveTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTemplate.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSaveTemplate.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSaveTemplate.Location = new System.Drawing.Point(507, 13);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(99, 49);
            this.btnSaveTemplate.TabIndex = 6;
            this.btnSaveTemplate.Text = "Сохранить шаблон";
            this.btnSaveTemplate.UseVisualStyleBackColor = false;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // btnAddValues
            // 
            this.btnAddValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddValues.BackColor = System.Drawing.Color.MintCream;
            this.btnAddValues.Enabled = false;
            this.btnAddValues.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddValues.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAddValues.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddValues.Location = new System.Drawing.Point(507, 530);
            this.btnAddValues.Name = "btnAddValues";
            this.btnAddValues.Size = new System.Drawing.Size(99, 46);
            this.btnAddValues.TabIndex = 17;
            this.btnAddValues.Text = "Вставить поля";
            this.btnAddValues.UseVisualStyleBackColor = false;
            this.btnAddValues.Click += new System.EventHandler(this.btnAddValues_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddFile.BackColor = System.Drawing.Color.MintCream;
            this.btnAddFile.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFile.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAddFile.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddFile.Location = new System.Drawing.Point(124, 530);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(108, 46);
            this.btnAddFile.TabIndex = 19;
            this.btnAddFile.Text = "Прикрепить файл";
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // TemplateFileDialog
            // 
            this.TemplateFileDialog.Multiselect = true;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.Transparent;
            this.lblCategories.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCategories.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCategories.Location = new System.Drawing.Point(121, 29);
            this.lblCategories.MaximumSize = new System.Drawing.Size(200, 20);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(0, 16);
            this.lblCategories.TabIndex = 20;
            // 
            // lblFiles
            // 
            this.lblFiles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFiles.AutoSize = true;
            this.lblFiles.BackColor = System.Drawing.Color.Transparent;
            this.lblFiles.Font = new System.Drawing.Font("Arial", 10F);
            this.lblFiles.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFiles.Location = new System.Drawing.Point(238, 545);
            this.lblFiles.MaximumSize = new System.Drawing.Size(200, 20);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(0, 16);
            this.lblFiles.TabIndex = 21;
            // 
            // lblSending
            // 
            this.lblSending.AutoSize = true;
            this.lblSending.BackColor = System.Drawing.Color.White;
            this.lblSending.Font = new System.Drawing.Font("Monotype Corsiva", 70F, System.Drawing.FontStyle.Bold);
            this.lblSending.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSending.Location = new System.Drawing.Point(74, 237);
            this.lblSending.Name = "lblSending";
            this.lblSending.Size = new System.Drawing.Size(453, 113);
            this.lblSending.TabIndex = 22;
            this.lblSending.Text = "Рассылка...";
            this.lblSending.Visible = false;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(621, 588);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lblSending);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddValues);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.btnGetTemplate);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbLetter);
            this.Controls.Add(this.tbTheme);
            this.Controls.Add(this.btnChooseCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Message";
            this.Text = "Рассылка";
            this.Load += new System.EventHandler(this.Message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseCategory;
        private System.Windows.Forms.TextBox tbTheme;
        private System.Windows.Forms.RichTextBox rtbLetter;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnGetTemplate;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.Button btnAddValues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.OpenFileDialog TemplateFileDialog;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblSending;
    }
}