
namespace Coffee
{
    partial class LoginMenu
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
            this.authorizatioMenu = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passText = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.Label();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.backButton1 = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorizatioMenu
            // 
            this.authorizatioMenu.BackColor = System.Drawing.Color.Transparent;
            this.authorizatioMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorizatioMenu.Font = new System.Drawing.Font("Comic Sans MS", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authorizatioMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.authorizatioMenu.Location = new System.Drawing.Point(0, 0);
            this.authorizatioMenu.Name = "authorizatioMenu";
            this.authorizatioMenu.Size = new System.Drawing.Size(1468, 160);
            this.authorizatioMenu.TabIndex = 1;
            this.authorizatioMenu.Text = "Авторизация пользователя\r\n(логин: admin; пароль: 1)\r\n";
            this.authorizatioMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.Controls.Add(this.backButton1);
            this.loginPanel.Controls.Add(this.passTextBox);
            this.loginPanel.Controls.Add(this.loginTextBox);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passText);
            this.loginPanel.Controls.Add(this.loginText);
            this.loginPanel.Location = new System.Drawing.Point(341, 240);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(804, 455);
            this.loginPanel.TabIndex = 2;
            // 
            // passTextBox
            // 
            this.passTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passTextBox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passTextBox.Location = new System.Drawing.Point(216, 158);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(562, 63);
            this.passTextBox.TabIndex = 5;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginTextBox.Location = new System.Drawing.Point(216, 59);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(562, 63);
            this.loginTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.FlatAppearance.BorderSize = 5;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Myriad Pro Light", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(284, 242);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(296, 95);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passText
            // 
            this.passText.AutoSize = true;
            this.passText.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passText.Location = new System.Drawing.Point(0, 158);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(204, 60);
            this.passText.TabIndex = 1;
            this.passText.Text = "Пароль:";
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginText.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginText.Location = new System.Drawing.Point(31, 57);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(172, 60);
            this.loginText.TabIndex = 0;
            this.loginText.Text = "Логин:";
            // 
            // exitButton2
            // 
            this.exitButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton2.FlatAppearance.BorderSize = 5;
            this.exitButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.exitButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.exitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton2.Font = new System.Drawing.Font("Myriad Pro Light", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton2.Location = new System.Drawing.Point(1313, 0);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(155, 53);
            this.exitButton2.TabIndex = 10;
            this.exitButton2.Text = "Выход";
            this.exitButton2.UseVisualStyleBackColor = false;
            this.exitButton2.Click += new System.EventHandler(this.exitButton2_Click);
            // 
            // backButton1
            // 
            this.backButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.backButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backButton1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton1.FlatAppearance.BorderSize = 5;
            this.backButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.backButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton1.Font = new System.Drawing.Font("Myriad Pro Light", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton1.Location = new System.Drawing.Point(284, 360);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(296, 95);
            this.backButton1.TabIndex = 6;
            this.backButton1.Text = "Назад";
            this.backButton1.UseVisualStyleBackColor = false;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::Coffee.Properties.Resources.background_zerna_texture_coffee_beans_kofe_fon_roasted_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1468, 746);
            this.Controls.Add(this.exitButton2);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.authorizatioMenu);
            this.Name = "LoginMenu";
            this.Text = "Кофемат";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label authorizatioMenu;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label passText;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button exitButton2;
        private System.Windows.Forms.Button backButton1;
    }
}