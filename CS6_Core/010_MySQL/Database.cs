using System;
using static System.Console;
using System.Data;
using MySql.Data.MySqlClient;

namespace _010_MySQL
{
    class Database
    {
        public void SelectPerson()
        {
            WriteLine("Loading PERSON table content");
            using(MySqlConnection conn = new MySqlConnection("server=192.168.248.131;uid=root;pwd=maalen;database=Test"))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from PERSON", conn);
                MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while(reader.Read())
                    WriteLine($"    Id: {reader["ID"]}, Name: {reader["NAME"]}");
                reader.Close();

                conn.Close();
            }
        }
    }
}