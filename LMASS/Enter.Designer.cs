namespace LMASS
{
    partial class Enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Window;
            this.lblWelcome.Location = new System.Drawing.Point(12, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(255, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добро пожаловать в LMASS!";
            this.lblWelcome.UseMnemonic = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLogin.Location = new System.Drawing.Point(25, 68);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(196, 15);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Введите адрес почтового ящика";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(28, 84);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(224, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPassword.Location = new System.Drawing.Point(25, 121);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Введите пароль";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(28, 137);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(224, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BackgroundImage = global::LMASS.Properties.Resources.background;
            this.btnOk.Enabled = false;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOk.Location = new System.Drawing.Point(81, 180);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 36);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::LMASS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(270, 233);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Enter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnOk;
    }
}