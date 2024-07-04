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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        public void adminMenuMessage1 () //методы вывода информационного окна
        {
            MessageBox.Show("Ингредиенты пополнены!");
        }

        public void adminMenuMessage2()
        {
            MessageBox.Show("Максимум ингредиентов!");
        }

        private void exitButton3_Click(object sender, EventArgs e) //выход из приложения по нажатию кнопки
        {
            Application.Exit();
        }

        private void mainMenuButton_Click(object sender, EventArgs e) //переход в главное меню по нажатию кнопки
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void waterButton_Click(object sender, EventArgs e)
        {
            int id = 1;
            int value = 2500;

            popolnenie(id, value);
        }

        private void sugarButton_Click(object sender, EventArgs e)
        {
            int id = 2;
            int value = 500;

            popolnenie(id, value);
        }

        private void coffeeButton_Click(object sender, EventArgs e)
        {
            int id = 5;
            int value = 500;

            popolnenie(id, value);
        }

        private void milkButton_Click(object sender, EventArgs e)
        {
            int id = 4;
            int value = 1000;

            popolnenie(id, value);
        }

        private void capButton_Click(object sender, EventArgs e)
        {
            int id = 3;
            int value = 100;

            popolnenie(id, value);
        }
        private void popolnenie(int iD, int valueUp)
        {
            try //проверка подключения к БД
            {
                string connectionString = "server=localhost;port=3306;username=root;password=1111;database=coffeemat"; //создание запросов
                string cmd = $"SELECT valuess FROM ingredients WHERE id={iD}";

                using (MySqlConnection connection = new MySqlConnection(connectionString)) //подключение к БД
                {
                    connection.Open(); //открытие подключения к БД

                    MySqlCommand command = new MySqlCommand(cmd, connection);

                    int value = (int)command.ExecuteScalar();

                    if (value < valueUp) //проверка на наличие ингредиентов в автомате
                    {
                        value = valueUp;

                        cmd = $"UPDATE ingredients SET valuess = {value} WHERE id={iD}";

                        MySqlCommand command5 = new MySqlCommand(cmd, connection);

                        command5.ExecuteNonQuery();

                        adminMenuMessage1();
                    }
                    else
                    {
                        adminMenuMessage2();
                    }

                    connection.Close(); //закрытие подключения
                }

            }
            catch (Exception) //что произойдет, если будет ошибка в коде
            {
                MessageBox.Show("Ошибка подключения!");
            }
        }
    }
}
