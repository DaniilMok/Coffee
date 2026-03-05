
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
            authorizatioMenu = new System.Windows.Forms.Label();
            loginPanel = new System.Windows.Forms.Panel();
            backButton1 = new System.Windows.Forms.Button();
            passTextBox = new System.Windows.Forms.TextBox();
            loginTextBox = new System.Windows.Forms.TextBox();
            loginButton = new System.Windows.Forms.Button();
            passText = new System.Windows.Forms.Label();
            loginText = new System.Windows.Forms.Label();
            exitButton2 = new System.Windows.Forms.Button();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // authorizatioMenu
            // 
            authorizatioMenu.BackColor = System.Drawing.Color.Transparent;
            authorizatioMenu.Dock = System.Windows.Forms.DockStyle.Top;
            authorizatioMenu.Font = new System.Drawing.Font("Comic Sans MS", 34F, System.Drawing.FontStyle.Bold);
            authorizatioMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            authorizatioMenu.Location = new System.Drawing.Point(0, 0);
            authorizatioMenu.Name = "authorizatioMenu";
            authorizatioMenu.Size = new System.Drawing.Size(1287, 120);
            authorizatioMenu.TabIndex = 1;
            authorizatioMenu.Text = "Авторизация пользователя\r\n\r\n";
            authorizatioMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginPanel
            // 
            loginPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            loginPanel.BackColor = System.Drawing.Color.Transparent;
            loginPanel.Controls.Add(backButton1);
            loginPanel.Controls.Add(passTextBox);
            loginPanel.Controls.Add(loginTextBox);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(passText);
            loginPanel.Controls.Add(loginText);
            loginPanel.Location = new System.Drawing.Point(298, 180);
            loginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new System.Drawing.Size(707, 416);
            loginPanel.TabIndex = 2;
            // 
            // backButton1
            // 
            backButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            backButton1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            backButton1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            backButton1.FlatAppearance.BorderSize = 5;
            backButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            backButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            backButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            backButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            backButton1.Location = new System.Drawing.Point(249, 345);
            backButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            backButton1.Name = "backButton1";
            backButton1.Size = new System.Drawing.Size(259, 71);
            backButton1.TabIndex = 6;
            backButton1.Text = "Назад";
            backButton1.UseVisualStyleBackColor = false;
            backButton1.Click += backButton1_Click;
            // 
            // passTextBox
            // 
            passTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            passTextBox.Font = new System.Drawing.Font("Segoe UI", 25F);
            passTextBox.Location = new System.Drawing.Point(189, 118);
            passTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new System.Drawing.Size(495, 52);
            passTextBox.TabIndex = 5;
            passTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            loginTextBox.Font = new System.Drawing.Font("Segoe UI", 25.2F);
            loginTextBox.Location = new System.Drawing.Point(189, 44);
            loginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new System.Drawing.Size(495, 52);
            loginTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            loginButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            loginButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            loginButton.FlatAppearance.BorderSize = 5;
            loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            loginButton.Location = new System.Drawing.Point(249, 257);
            loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(259, 71);
            loginButton.TabIndex = 3;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passText
            // 
            passText.AutoSize = true;
            passText.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold);
            passText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            passText.Location = new System.Drawing.Point(0, 118);
            passText.Name = "passText";
            passText.Size = new System.Drawing.Size(168, 49);
            passText.TabIndex = 1;
            passText.Text = "Пароль:";
            // 
            // loginText
            // 
            loginText.AutoSize = true;
            loginText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            loginText.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold);
            loginText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            loginText.Location = new System.Drawing.Point(27, 43);
            loginText.Name = "loginText";
            loginText.Size = new System.Drawing.Size(142, 49);
            loginText.TabIndex = 0;
            loginText.Text = "Логин:";
            // 
            // exitButton2
            // 
            exitButton2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            exitButton2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            exitButton2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            exitButton2.FlatAppearance.BorderSize = 5;
            exitButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            exitButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            exitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            exitButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            exitButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            exitButton2.Location = new System.Drawing.Point(1139, 11);
            exitButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            exitButton2.Name = "exitButton2";
            exitButton2.Size = new System.Drawing.Size(136, 59);
            exitButton2.TabIndex = 10;
            exitButton2.Text = "Выход";
            exitButton2.UseVisualStyleBackColor = false;
            exitButton2.Click += exitButton2_Click;
            // 
            // LoginMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SaddleBrown;
            BackgroundImage = Properties.Resources.background_zerna_texture_coffee_beans_kofe_fon_roasted_1;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1287, 635);
            Controls.Add(exitButton2);
            Controls.Add(loginPanel);
            Controls.Add(authorizatioMenu);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "LoginMenu";
            Text = "Кофемат";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);

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