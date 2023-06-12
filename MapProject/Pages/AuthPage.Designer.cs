namespace MapProject.Pages
{
    partial class AuthPage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.guestLoginButton = new System.Windows.Forms.Button();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hidePasswordSwitch = new MapProject.MySwitchButton();
            ((System.ComponentModel.ISupportInitialize)(this.hidePasswordSwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(379, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход";
            // 
            // guestLoginButton
            // 
            this.guestLoginButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.guestLoginButton.Location = new System.Drawing.Point(343, 346);
            this.guestLoginButton.Name = "guestLoginButton";
            this.guestLoginButton.Size = new System.Drawing.Size(136, 42);
            this.guestLoginButton.TabIndex = 4;
            this.guestLoginButton.Text = "Войти как гость";
            this.guestLoginButton.UseVisualStyleBackColor = true;
            this.guestLoginButton.Click += new System.EventHandler(this.guestLoginButton_Click);
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.adminLoginButton.Location = new System.Drawing.Point(343, 234);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(136, 42);
            this.adminLoginButton.TabIndex = 3;
            this.adminLoginButton.Text = "Войти как админ";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.Location = new System.Drawing.Point(311, 130);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(203, 25);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(311, 178);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(203, 25);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label2.Location = new System.Drawing.Point(167, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label3.Location = new System.Drawing.Point(243, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label4.Location = new System.Drawing.Point(390, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "или";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(343, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 1);
            this.panel1.TabIndex = 8;
            // 
            // hidePasswordSwitch
            // 
            this.hidePasswordSwitch.Image = global::MapProject.Properties.Resources.restrictEye_Default;
            this.hidePasswordSwitch.Location = new System.Drawing.Point(520, 178);
            this.hidePasswordSwitch.Name = "hidePasswordSwitch";
            this.hidePasswordSwitch.Size = new System.Drawing.Size(24, 24);
            this.hidePasswordSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidePasswordSwitch.Switch = true;
            this.hidePasswordSwitch.SwitchOffImage_Active = global::MapProject.Properties.Resources.passEye_Active;
            this.hidePasswordSwitch.SwitchOffImage_Default = global::MapProject.Properties.Resources.passEye_Default;
            this.hidePasswordSwitch.SwitchOnImage_Active = global::MapProject.Properties.Resources.restrictEye_Active;
            this.hidePasswordSwitch.SwitchOnImage_Default = global::MapProject.Properties.Resources.restrictEye_Default;
            this.hidePasswordSwitch.TabIndex = 9;
            this.hidePasswordSwitch.TabStop = false;
            this.hidePasswordSwitch.Click += new System.EventHandler(this.hidePasswordSwitch_Click);
            // 
            // AuthPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hidePasswordSwitch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.adminLoginButton);
            this.Controls.Add(this.guestLoginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AuthPage";
            this.Size = new System.Drawing.Size(823, 460);
            ((System.ComponentModel.ISupportInitialize)(this.hidePasswordSwitch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guestLoginButton;
        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private MySwitchButton hidePasswordSwitch;
    }
}
