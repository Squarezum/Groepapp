using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Games
    {
        //Eigenschappen van de games
        public int GameId { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }
        public double Prijs { get; set; }
        public int leeftijd { get; set; }

        //default constructor
        public Games()
        {
            GameId = 0;
            Titel = "";
            Genre = "";
            Prijs = 0.0;
            Leeftijd = 0;
        }

        //constructor met parameters
        public Games(int gameId, string titel, string genre, double prijs, int leeftijd)
        {
            GameId = gameId;
            Titel = titel;
            Genre = genre;
            Prijs = prijs;
            Leeftijd = leeftijd;
        }
    }
}
