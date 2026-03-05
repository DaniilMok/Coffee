using Coffee.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Coffee
{
    public partial class LoginMenu : Form
    {
        DataBase dataBaseService = new DataBase(); //подключение к БД

        public LoginMenu()
        {
            InitializeComponent();
            this.loginTextBox.AutoSize = false;
            this.loginTextBox.Size = new Size(562, 61); //установление высоты поля ввода логина
            this.passTextBox.AutoSize = false;
            this.passTextBox.Size = new Size(562, 61); //установление высоты поля ввода пароля
        }

        private void loginButton_Click(object sender, EventArgs e) //действие, которое срабатывает при нажатии на кнопку "Войти"
        {
            DataBase dataBaseService = new DataBase();

            String loginUser = loginTextBox.Text;
            String passUser = passTextBox.Text; //получение данных от пользователя

            string correctLogin = dataBaseService.Authorization("login"); //получение правильного логина из БД
            string correctPass = dataBaseService.Authorization("pass"); //получение правильного пароля из БД
            if (loginUser == correctLogin && passUser == correctPass) //проверка введённых данных
            {
                this.Hide();
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
            else MessageBox.Show("Логин или пароль неверные!");
        }

        private void exitButton2_Click(object sender, EventArgs e) //выход из программы по нажатию кнопки "Выход"
        {
            Application.Exit();
        }

        private void backButton1_Click(object sender, EventArgs e) //переход на главное меню по нажатию кнопки "Назад" 
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
