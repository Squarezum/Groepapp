using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DA_Games : DA
    {
        public static void GetGames()
        {
            //Hier komt de code om de games op te halen uit de database

            //connectie aanmaken
            MySqlConnection conn = new MySqlConnection(return_constring());

            //commando opstellen
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM games", conn);

            //connectie openen
            conn.Open();

            //commando uitvoeren
            MySqlDataReader reader = cmd.ExecuteReader();

            //connectie sluiten
            conn.Close();

            return;
        }
    }
}
