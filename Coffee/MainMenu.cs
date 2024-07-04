using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class MainMenu : Form
    {
        int rub;
        int sugarClick;

        public MainMenu() // Создание формы
        {
            InitializeComponent();
        }

        public void balance() //методы вывода информационного окна
        {
            MessageBox.Show("Сейчас на балансе: " + rub.ToString() + " руб.");
        }

        public void drink()
        {
            MessageBox.Show("Ваш напиток готов, остаток на счету: " + rub.ToString() + " руб.");
        }

        private void sdachaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваша сдача: " + rub.ToString() + " руб.");
            rub = 0;
        }

        private void rub1_Click(object sender, EventArgs e) //методы на пополнение баланса при нажатии кнопок
        {
            rub += 1;
            balance();
        }

        private void rub2_Click(object sender, EventArgs e)
        {
            rub += 2;
            balance();
        }

        private void rub5_Click(object sender, EventArgs e)
        {
            rub += 5;
            balance();
        }

        private void rub10_Click(object sender, EventArgs e)
        {
            rub += 10;
            balance();
        }

        private void rub50_Click(object sender, EventArgs e)
        {
            rub += 50;
            balance();
        }

        private void rub100_Click(object sender, EventArgs e)
        {
            rub += 100;
            balance();
        }

        private void rub200_Click(object sender, EventArgs e)
        {
            rub += 200;
            balance();
        }

        private void adminButton_Click(object sender, EventArgs e) //переход на окно авторизации по нажатию кнопки "Меню администратора"
        {
            this.Hide();
            LoginMenu logMenu = new LoginMenu();
            logMenu.Show(); 
        }

        private void exitButton1_Click(object sender, EventArgs e) //выход из программы по нажатию кнопки "Выход"
        {
            Application.Exit(); 
        }

        private void americButton_Click(object sender, EventArgs e)
        {
            int proverkaRub = 25;
            int idWater = 1;
            int idCups = 3;
            int idCoffee = 5;
            int water = 250;
            int cups = 1;
            int coffee = 50;
            string nameCoffee = "Americano";

            coffeeNoMilk(proverkaRub, idWater, idCups, idCoffee, water, cups, coffee, nameCoffee);
        }

        private void latteButton_Click(object sender, EventArgs e)
        {
            int proverkaRub = 30;
            int idWater = 1;
            int idCups = 3;
            int idMilk = 4;
            int idCoffee = 5;
            int water = 150;
            int cups = 1;
            int coffee = 25;
            int milk = 100;
            string nameCoffee = "Latte";

            coffeeOnMilk(proverkaRub, idWater, idCups, idMilk, idCoffee, water, cups, coffee, milk, nameCoffee);
        }

        private void espresButton_Click(object sender, EventArgs e)
        {
            int proverkaRub = 30;
            int idWater = 1;
            int idCups = 3;
            int idCoffee = 5;
            int water = 250;
            int cups = 1;
            int coffee = 25;
            string nameCoffee = "Espresso";

            coffeeNoMilk(proverkaRub, idWater, idCups, idCoffee, water, cups, coffee, nameCoffee);
        }

        private void cappButton_Click(object sender, EventArgs e)
        {
            int proverkaRub = 20;
            int idWater = 1;
            int idCups = 3;
            int idMilk = 4;
            int idCoffee = 5;
            int water = 200;
            int cups = 1;
            int coffee = 50;
            int milk = 50;
            string nameCoffee = "Cappuccino";

            coffeeOnMilk(proverkaRub, idWater, idCups, idMilk, idCoffee, water, cups, coffee, milk, nameCoffee);
        }

        private void coffeeNoMilk(int rubli, int idWateR, int idCupS, int idCoffeE, int wateR, int cupS, int coffeE, string nameCoffeE)
        {
            if (rub >= rubli) //проверка на внесенную оплату
            {
                try //проверка подключения к БД
                {
                    string connectionString = "server=localhost;port=3306;username=root;password=1111;database=coffeemat"; //создание запросов
                    string cmd = $"SELECT valuess FROM ingredients WHERE id={idWateR}";
                    string cmd2 = $"SELECT valuess FROM ingredients WHERE id={idCupS}";
                    string cmd3 = $"SELECT valuess FROM ingredients WHERE id={idCoffeE}";

                    using (MySqlConnection connection = new MySqlConnection(connectionString)) //подключение к БД
                    {
                        connection.Open(); //открытие подключения к БД

                        MySqlCommand command = new MySqlCommand(cmd, connection);
                        MySqlCommand command2 = new MySqlCommand(cmd2, connection);
                        MySqlCommand command3 = new MySqlCommand(cmd3, connection);

                        int valueWater = (int)command.ExecuteScalar();
                        int valueCups = (int)command2.ExecuteScalar();
                        int valueCoffee = (int)command3.ExecuteScalar();

                        if ((valueCoffee >= coffeE) & (valueCups >= cupS) & (valueWater >= wateR)) //проверка на наличие ингредиентов в автомате
                        {
                            valueWater -= wateR;
                            valueCups -= cupS;
                            valueCoffee -= coffeE;

                            cmd = $"UPDATE ingredients SET valuess = {valueWater} WHERE id={idWateR}";
                            cmd2 = $"UPDATE ingredients SET valuess = {valueCups} WHERE id={idCupS}";
                            cmd3 = $"UPDATE ingredients SET valuess = {valueCoffee} WHERE id={idCoffeE}";
                            string cmd4 = $"INSERT INTO purchases (product, price) VALUES ('{nameCoffeE}', {rubli})";

                            MySqlCommand command5 = new MySqlCommand(cmd, connection);
                            MySqlCommand command6 = new MySqlCommand(cmd2, connection);
                            MySqlCommand command7 = new MySqlCommand(cmd3, connection);
                            MySqlCommand command8 = new MySqlCommand(cmd4, connection);

                            command5.ExecuteNonQuery();
                            command6.ExecuteNonQuery();
                            command7.ExecuteNonQuery();
                            command8.ExecuteNonQuery();

                            rub -= rubli;
                            sugarClick = 0;

                            drink();
                        }
                        else
                        {
                            if (valueWater < wateR)
                                MessageBox.Show("Мало воды: " + valueWater.ToString() + " мл.");
                            else if (valueCups < cupS)
                                MessageBox.Show("Мало стаканчиков: " + valueCups.ToString() + " шт.");
                            else if (valueCoffee < coffeE)
                                MessageBox.Show("Мало кофе: " + valueCoffee.ToString() + " гр.");
                        }

                        connection.Close(); //закрытие подключения
                    }

                }
                catch (Exception) //что произойдет, если будет ошибка в коде
                {
                    MessageBox.Show("Ошибка подключения!");
                }
            }
            else
                MessageBox.Show("Недостаточно средств!");
        }

        private void coffeeOnMilk(int rubli, int idWateR, int idCupS, int idMilK, int idCoffeE, int wateR, int cupS, int coffeE, int milK, string nameCoffeE)
        {
            if (rub >= rubli) //проверка на внесенную оплату
            {
                try //проверка подключения к БД
                {
                    string connectionString = "server=localhost;port=3306;username=root;password=1111;database=coffeemat"; //создание запросов
                    string cmd = $"SELECT valuess FROM ingredients WHERE id={idWateR}";
                    string cmd2 = $"SELECT valuess FROM ingredients WHERE id={idCupS}";
                    string cmd3 = $"SELECT valuess FROM ingredients WHERE id={idCoffeE}";
                    string cmd4 = $"SELECT valuess FROM ingredients WHERE id={idMilK}";

                    using (MySqlConnection connection = new MySqlConnection(connectionString)) //подключение к БД
                    {
                        connection.Open(); //открытие подключения к БД

                        MySqlCommand command = new MySqlCommand(cmd, connection);
                        MySqlCommand command2 = new MySqlCommand(cmd2, connection);
                        MySqlCommand command3 = new MySqlCommand(cmd3, connection);
                        MySqlCommand command4 = new MySqlCommand(cmd4, connection);

                        int valueWater = (int)command.ExecuteScalar();
                        int valueCups = (int)command2.ExecuteScalar();
                        int valueCoffee = (int)command3.ExecuteScalar();
                        int valueMilk = (int)command4.ExecuteScalar();

                        if ((valueCoffee >= coffeE) & (valueCups >= cupS) & (valueWater >= wateR) & (valueMilk >= milK)) //проверка на наличие ингредиентов в автомате
                        {
                            valueWater -= wateR;
                            valueCups -= cupS;
                            valueCoffee -= coffeE;
                            valueMilk -= milK;

                            cmd = $"UPDATE ingredients SET valuess = {valueWater} WHERE id={idWateR}";
                            cmd2 = $"UPDATE ingredients SET valuess = {valueCups} WHERE id={idCupS}";
                            cmd3 = $"UPDATE ingredients SET valuess = {valueCoffee} WHERE id={idCoffeE}";
                            cmd4 = $"UPDATE ingredients SET valuess = {valueMilk} WHERE id={idMilK}";
                            string cmd5 = $"INSERT INTO purchases (product, price) VALUES ('{nameCoffeE}', {rubli})";

                            MySqlCommand command5 = new MySqlCommand(cmd, connection);
                            MySqlCommand command6 = new MySqlCommand(cmd2, connection);
                            MySqlCommand command7 = new MySqlCommand(cmd3, connection);
                            MySqlCommand command8 = new MySqlCommand(cmd4, connection);
                            MySqlCommand command9 = new MySqlCommand(cmd5, connection);

                            command5.ExecuteNonQuery();
                            command6.ExecuteNonQuery();
                            command7.ExecuteNonQuery();
                            command8.ExecuteNonQuery();
                            command9.ExecuteNonQuery();

                            rub -= rubli;
                            sugarClick = 0;

                            drink();
                        }
                        else
                        {
                            if (valueWater < wateR)
                                MessageBox.Show("Мало воды: " + valueWater.ToString() + " мл.");
                            else if (valueCups < cupS)
                                MessageBox.Show("Мало стаканчиков: " + valueCups.ToString() + " шт.");
                            else if (valueCoffee < coffeE)
                                MessageBox.Show("Мало кофе: " + valueCoffee.ToString() + " гр.");
                            else if (valueMilk < milK)
                                MessageBox.Show("Мало молока: " + valueMilk.ToString() + " мл.");
                        }

                        connection.Close(); //закрытие подключения
                    }

                }
                catch (Exception) //что произойдет, если будет ошибка в коде
                {
                    MessageBox.Show("Ошибка подключения!");
                }
            }
            else
                MessageBox.Show("Недостаточно средств!");
        }

        private void sugar1_Click(object sender, EventArgs e)
        {
            if (sugarClick <= 0) //создание проверки
            {
                MessageBox.Show("Сахар не добавлен!");
            }
            else
            {
                try //проверка подключения к БД
                {
                    string connectionString = "server=localhost;port=3306;username=root;password=1111;database=coffeemat";
                    string cmd = "SELECT valuess FROM ingredients WHERE id=2";

                    using (MySqlConnection connection = new MySqlConnection(connectionString)) //подклюючение к БД
                    {
                        connection.Open(); //открытие подключения

                        MySqlCommand command = new MySqlCommand(cmd, connection); //создание запросов

                        int valueSugar = (int)command.ExecuteScalar();

                        valueSugar += 25;
                        sugarClick -= 1;

                        MessageBox.Show("Добавлено ложек сахара: " + sugarClick.ToString());

                        cmd = $"UPDATE ingredients SET valuess = {valueSugar} WHERE id=2";
                        MySqlCommand command2 = new MySqlCommand(cmd, connection);
                        command2.ExecuteNonQuery();

                        connection.Close(); //закрытие подключения
                    }

                }
                catch (Exception) //что произойдет, если будет ошибка в коде
                {
                    MessageBox.Show("Ошибка подключения!");
                }
            }
        }

        private void sugar2_Click(object sender, EventArgs e)
        {
            if (sugarClick >= 4) //создание проверки
            {
                MessageBox.Show("Максимальное количество сахара!");
            }
            else
            {
                try //проверка подключения к БД
                {
                    string connectionString = "server=localhost;port=3306;username=root;password=1111;database=coffeemat";
                    string cmd = "SELECT valuess FROM ingredients WHERE id=2";

                    using (MySqlConnection connection = new MySqlConnection(connectionString)) //подклюючение к БД
                    {
                        connection.Open(); //открытие подключения

                        MySqlCommand command = new MySqlCommand(cmd, connection); //создание запросов

                        int valueSugar = (int)command.ExecuteScalar();

                        if (valueSugar > 25)
                        {
                            valueSugar -= 25;
                            sugarClick += 1;
                            MessageBox.Show("Добавлено ложек сахара: " + sugarClick.ToString());
                            cmd = $"UPDATE ingredients SET valuess = {valueSugar} WHERE id=2";
                            MySqlCommand command2 = new MySqlCommand(cmd, connection);
                            command2.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("В автомате мало сахара: " + valueSugar.ToString() + " гр.");
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
}
