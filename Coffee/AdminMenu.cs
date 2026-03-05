using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Coffee.Data;

namespace Coffee
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        public void adminMenuMessage1() //методы вывода информационного окна
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

        private void popolnenie(int id, int valueUp)
        {
            DataBase dataBaseService = new DataBase();
            if (dataBaseService.DataBasePopolnenie(id, valueUp) == "Success") adminMenuMessage1(); //вызов метода информационного окна при успешном пополнении
            else if (dataBaseService.DataBasePopolnenie(id, valueUp) == "Failed") adminMenuMessage2();
            else MessageBox.Show("Ошибка подключения!");
        }
    }
}
