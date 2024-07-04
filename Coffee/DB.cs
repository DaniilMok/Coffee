using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=1111;database=coffeemat");
        //подключение к бд через локальный сервер

        public void openConnection() //открывает соединение
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection() //закрывает соединение
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection() //возвращает соединение с БД
        {
            return connection;
        }
    }
}
