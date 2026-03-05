using Coffee.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Coffee.Services
{
    public class PreparingDrink
    {
        private MainMenu mainMenu;
        private DataBase dataBase;
        int valueWater;
        int valueCups;
        int valueCoffeeBeeans;
        int valueMilk;

        public PreparingDrink()
        {
            mainMenu = new MainMenu();
            dataBase = new DataBase();
            valueWater = dataBase.ObtainingIngredients("water");
            valueCups = dataBase.ObtainingIngredients("cups");
            valueCoffeeBeeans = dataBase.ObtainingIngredients("coffee");
            valueMilk = dataBase.ObtainingIngredients("milk");
        }

        public void NotEnoughUnits(int water, int cups, int coffee, int milk)
        {
            if (valueWater < water)
                MessageBox.Show("Мало воды: " + valueWater.ToString() + " мл.");
            else if (valueCups < cups)
                MessageBox.Show("Мало стаканчиков: " + valueCups.ToString() + " шт.");
            else if (valueCoffeeBeeans < coffee)
                MessageBox.Show("Мало кофе: " + valueCoffeeBeeans.ToString() + " гр.");
            else if (valueMilk < milk)
                MessageBox.Show("Мало молока: " + valueMilk.ToString() + " мл.");
        }

        public void UpdateValue(string nameCoffee, int price)
        {
            dataBase.UpdateIngredients("water", valueWater);
            dataBase.UpdateIngredients("cups", valueCups);
            dataBase.UpdateIngredients("coffee", valueCoffeeBeeans);
            dataBase.UpdateIngredients("milk", valueMilk);
            dataBase.AddPurchase(nameCoffee, price);
        }

        public void coffeeNoMilk(ref int sugarClick, ref int rub, int price, int water, int cups, int coffee, string nameCoffee)
        {
            if (rub >= price) //проверка на внесенную оплату
            {
                try //проверка подключения к БД
                {
                    if ((valueCoffeeBeeans >= coffee) & (valueCups >= cups) & (valueWater >= water)) //проверка на наличие ингредиентов в автомате
                    {
                        valueWater -= water;
                        valueCups -= cups;
                        valueCoffeeBeeans -= coffee;

                        UpdateValue(nameCoffee, price);

                        rub -= price;
                        sugarClick = 0;

                        mainMenu.drink(ref rub, ref sugarClick);
                    }
                    else
                    {
                        NotEnoughUnits(water, cups, coffee, 0);
                    }

                }
                catch (Exception) //что произойдет, если будет ошибка
                {
                    MessageBox.Show("Ошибка подключения!");
                }
            }
            else
                MessageBox.Show("Недостаточно средств!");
        }

        public void coffeeOnMilk(ref int sugarClick, ref int rub, int price, int water, int cups, int coffee, int milk, string nameCoffee)
        {
            if (rub >= price) //проверка на внесенную оплату
            {
                try //проверка подключения к БД
                {

                    if ((valueCoffeeBeeans >= coffee) & (valueCups >= cups) & (valueWater >= water) & (valueMilk >= milk)) //проверка на наличие ингредиентов в автомате
                    {
                        valueWater -= water;
                        valueCups -= cups;
                        valueCoffeeBeeans -= coffee;
                        valueMilk -= milk;

                        UpdateValue(nameCoffee, price);

                        rub -= price;
                        sugarClick = 0;

                        mainMenu.drink(ref rub, ref sugarClick);
                    }
                    else
                    {
                        NotEnoughUnits(water, cups, coffee, milk);
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
    }
}
