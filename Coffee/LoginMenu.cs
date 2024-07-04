using MySql.Data.MySqlClient;
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
        DB db = new DB(); //подключение к БД

        public LoginMenu()
        {
            InitializeComponent();

            this.passTextBox.AutoSize = false;
            this.passTextBox.Size = new Size(562, 61); //установление высоты поля ввода пароля
        }

        private void loginButton_Click(object sender, EventArgs e) //действие, которое срабатывает при нажатии на кнопку "Войти"
        {
            String loginUser = loginTextBox.Text;
            String passUser = passTextBox.Text; //получение данных от пользователя

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @uL AND pass = @uP", db.getConnection()); 
            //создание заглушек и указание БД
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser; //указание переменных
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command; //выбор команды для выполнения
            adapter.Fill(table); //заполнение таблицы

            if (table.Rows.Count > 0)
            {
                //проверка введённых данных
                this.Hide();
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
            else
                MessageBox.Show("Логин или пароль неверные!");
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
