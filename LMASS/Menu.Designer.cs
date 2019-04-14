namespace LMASS
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите действие";
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMessage.BackgroundImage = global::LMASS.Properties.Resources.background;
            this.btnMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMessage.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMessage.Location = new System.Drawing.Point(39, 64);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(133, 44);
            this.btnMessage.TabIndex = 1;
            this.btnMessage.Text = "Рассылка";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCategories.BackgroundImage = global::LMASS.Properties.Resources.background;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategories.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCategories.Location = new System.Drawing.Point(39, 115);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(133, 45);
            this.btnCategories.TabIndex = 2;
            this.btnCategories.Text = "Категории";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.BackgroundImage = global::LMASS.Properties.Resources.background;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(39, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::LMASS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(209, 237);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button button3;
    }
}