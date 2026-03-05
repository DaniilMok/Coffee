using Coffee.Data;
using Coffee.Services;
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
        public int rub = 0;
        public int sugarClick = 0;
        //private PreparingDrink preparingDrink;
        //private DataBase dataBase;

        public MainMenu() // Создание формы
        {
            InitializeComponent();
        }

        public void balance() //методы вывода информационного окна
        {
            balanceLabel.Text = "Баланс: " + rub.ToString() + " руб.";
        }

        public void drink(ref int rub, ref int sugarClick)
        {
            MessageBox.Show("Ваш напиток готов!");
        }

        private void UpdateLabel()
        {
            balanceLabel.Text = "Баланс: " + rub.ToString() + " руб.";
            valueSugarLabel.Text = sugarClick.ToString();
        }

        private void sdachaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваша сдача: " + rub.ToString() + " руб.");
            rub = 0;
            UpdateLabel();
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
            int price = 25;
            int water = 250;
            int cups = 1;
            int coffee = 50;
            string nameCoffee = "Americano";
            PreparingDrink preparingDrink = new PreparingDrink();

            preparingDrink.coffeeNoMilk(ref sugarClick, ref rub, price, water, cups, coffee, nameCoffee);
            UpdateLabel();
        }

        private void latteButton_Click(object sender, EventArgs e)
        {
            int price = 30;
            int water = 150;
            int cups = 1;
            int coffee = 25;
            int milk = 100;
            string nameCoffee = "Latte";
            PreparingDrink preparingDrink = new PreparingDrink();

            preparingDrink.coffeeOnMilk(ref sugarClick, ref rub, price, water, cups, coffee, milk, nameCoffee);
            UpdateLabel();
        }

        private void espresButton_Click(object sender, EventArgs e)
        {
            int price = 30;
            int water = 250;
            int cups = 1;
            int coffee = 25;
            string nameCoffee = "Espresso";
            PreparingDrink preparingDrink = new PreparingDrink();

            preparingDrink.coffeeNoMilk(ref sugarClick, ref rub, price, water, cups, coffee, nameCoffee);
            UpdateLabel();
        }

        private void cappButton_Click(object sender, EventArgs e)
        {
            int price = 20;
            int water = 200;
            int cups = 1;
            int coffee = 50;
            int milk = 50;
            string nameCoffee = "Cappuccino";
            PreparingDrink preparingDrink = new PreparingDrink();

            preparingDrink.coffeeOnMilk(ref sugarClick, ref rub, price, water, cups, coffee, milk, nameCoffee);
            UpdateLabel();
        }




        private void sugar1_Click(object sender, EventArgs e)
        {
            if (sugarClick <= 0) //создание проверки
            {
                MessageBox.Show("Сахар не добавлен!");
            }
            else
            {
                DataBase dataBase = new DataBase();
                int valueSugar = dataBase.ObtainingIngredients("sugar");
                valueSugar += 25;
                dataBase.UpdateSugar(valueSugar);

                sugarClick -= 1;

                UpdateLabel();
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
                DataBase dataBase = new DataBase();
                int valueSugar = dataBase.ObtainingIngredients("sugar");

                if (valueSugar > 25)
                {
                    valueSugar -= 25;
                    sugarClick += 1;
                    dataBase.UpdateSugar(valueSugar);
                    UpdateLabel();
                }
                else
                {
                    MessageBox.Show("В автомате мало сахара: " + valueSugar.ToString() + " гр.");
                }

            }
        }
    }
}
