using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Coffee.Data
{
    public class DataBase
    {
        protected readonly SqliteConnection _connection;

        public DataBase()
        {
            var connectionString = new SqliteConnectionStringBuilder
            {
                DataSource = Path.Combine(Application.StartupPath, "coffee.db")
            }.ToString();
            _connection = new SqliteConnection(connectionString);
            _connection.Open();
            LoginAndPass();
            CreateTablePurchases();
            CreateTableIngredients();
        }

        public void LoginAndPass()
        {
            var command = _connection.CreateCommand();
            try
            {
                command.CommandText = """
                CREATE TABLE IF NOT EXISTS users (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    login TEXT NOT NULL,
                    pass TEXT NOT NULL
                );
                """;

                if (command.ExecuteScalar() == null)
                {
                    command.CommandText = """
                    INSERT INTO users (login, pass) VALUES ('admin', '1111');
                    """;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка логина и пароля!");
            }
        }

        public void CreateTablePurchases()
        {
            var command = _connection.CreateCommand();
            try
            {
                command.CommandText = """
                CREATE TABLE IF NOT EXISTS purchases (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    product TEXT NOT NULL,
                    price INTEGER NOT NULL
                );
                """;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка создания таблицы покупок!");
            }
        }

        public string DataBasePopolnenie(int id, int valueUp)
        {
            try //проверка подключения к БД
            {
                var command = _connection.CreateCommand();
                command.CommandText = $"""SELECT valuess FROM ingredients WHERE id={id};""";

                var result = command.ExecuteScalar();
                int value = 0;
                if (result == null)
                {
                    MessageBox.Show("Ингредиент не найден!");
                    return "Failed";
                }
                else
                {
                    value = Convert.ToInt32(result.ToString());
                }

                    if (value < valueUp) //проверка на наличие ингредиентов в автомате
                {
                    value = valueUp;

                    command.CommandText = $"""UPDATE ingredients SET valuess = {value} WHERE id={id};""";

                    command.ExecuteNonQuery();

                    return "Success";
                }
                else
                {
                    return "Failed";
                }
            }

            catch (Exception) //что произойдет, если будет ошибка в коде
            {
                MessageBox.Show("Ошибка пополнения!");
                return "Failed";
            }
        }

        public string Authorization(string value)
        {
            string result = "";
            var command = _connection.CreateCommand();
            if (value == "login")
            {
                command.CommandText = """SELECT login FROM users WHERE login IS NOT NULL;""";
                return result = (string)command.ExecuteScalar();
            }
            else if (value == "pass")
            {
                command.CommandText = """SELECT pass FROM users WHERE pass IS NOT NULL;""";
                return result = (string)command.ExecuteScalar();
            }
            else
                return result;
        }

        public void CreateTableIngredients()
        {
            var command = _connection.CreateCommand();
            try
            {
                command.CommandText = """
                CREATE TABLE IF NOT EXISTS ingredients (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL,
                    valuess INTEGER NOT NULL
                );
                """;
                command.ExecuteNonQuery();
                command.CommandText = """SELECT name FROM ingredients WHERE name IS NOT NULL;""";
                if (command.ExecuteScalar() == null)
                {
                    command.CommandText = """
                    INSERT INTO ingredients (name, valuess) VALUES ('water', 1000);
                    """;
                    command.ExecuteNonQuery();
                    command.CommandText = """
                    INSERT INTO ingredients (name, valuess) VALUES ('sugar', 1000);
                    """;
                    command.ExecuteNonQuery();
                    command.CommandText = """
                    INSERT INTO ingredients (name, valuess) VALUES ('coffee', 1000);
                    """;
                    command.ExecuteNonQuery();
                    command.CommandText = """
                    INSERT INTO ingredients (name, valuess) VALUES ('cups', 1000);
                    """;
                    command.ExecuteNonQuery();
                    command.CommandText = """
                        INSERT INTO ingredients (name, valuess) VALUES ('milk', 1000);  
                    """;
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка создания таблицы ингредиентов!");
            }
        }

        public int ObtainingIngredients(string ingredient)
        {
            var command = _connection.CreateCommand();
            try
            {
                command.CommandText = $"""SELECT valuess FROM ingredients WHERE name = '{ingredient}';""";
                var result = command.ExecuteScalar();
                int value = 0;
                if (result == null)
                {
                    MessageBox.Show("Ингредиент не найден!");
                    return 0;
                }
                else
                {
                    value = Convert.ToInt32(result.ToString());
                }
                return value;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ошибка получения ингридиента! {err}");
                return 0;
            }
        }

        public void UpdateIngredients(string ingredient, int value)
        {
            var command = _connection.CreateCommand();
            try
            {
                command.CommandText = $"""UPDATE ingredients SET valuess = {value} WHERE name = '{ingredient}';""";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка обновления ингридиента!");
            }
        }

        public void AddPurchase(string name, int price)
        {
            var command = _connection.CreateCommand();
            try
            {
                command.CommandText = $"""INSERT INTO purchases (product, price) VALUES ('{name}', {price});""";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка добавления покупки!");
            }
        }

        public void UpdateSugar(int value)
        {
            var command = _connection.CreateCommand();
            try //проверка подключения к БД
            {
                command.CommandText = $"""UPDATE ingredients SET valuess = {value} WHERE name = 'sugar';""";
                command.ExecuteNonQuery();
            }
            catch (Exception) //что произойдет, если будет ошибка в коде
            {
                MessageBox.Show("Ошибка подключения!");
            }
        }
    }
}
