using GroupingListProject.Models;
using System.Collections.Generic;

namespace GroupingListProject.Services
{
    public class PlayerService
    {

        public List<Player> GetData()
        {
            return new List<Player>()
            {
                new Player
                {
                    FullName = "Didier Deschamps",
                    Position = PlayerPosition.Coach
                },
                new Player
                {
                    FullName = "Hugo Lloris",
                    Number = 23,
                    Position = PlayerPosition.Goalkeeper
                },
                new Player
                {
                    FullName = "Steve Mandanda",
                    Number = 23,
                    Position = PlayerPosition.Goalkeeper
                },
                new Player
                {
                    FullName = "Alphonse Areola",
                    Number = 23,
                    Position = PlayerPosition.Goalkeeper
                },
                new Player
                {
                    FullName = "Benjamin Pavard",
                    Number = 2,
                    Position = PlayerPosition.Defender
                },
                new Player
                {
                    FullName = "Djibril Sidibé",
                    Number = 19,
                    Position = PlayerPosition.Defender
                },
                new Player
                {
                    FullName = "Presnel Kimpembe",
                    Number = 3,
                    Position = PlayerPosition.Defender
                },
                new Player
                {
                    FullName = "Adil Rami",
                    Number = 17,
                    Position = PlayerPosition.Defender
                },
                new Player
                {
                    FullName = "Raphaël Varane",
                    Number = 4,
                    Position = PlayerPosition.Defender
                },
                new Player
                {
                    FullName = "Samuel Umtiti",
                    Number = 5,
                    Position = PlayerPosition.Defender
                },
                new Player
                {
                    FullName = "Raphaël Varane",
                    Number = 4,
                    Position = PlayerPosition.Defender
                },
                new Player
                {
                    FullName = "Lucas Hernandez",
                    Number = 21,
                    Position = PlayerPosition.Defender
                },
                new Player
                {
                    FullName = "Benjamin Mendy",
                    Number = 22,
                    Position = PlayerPosition.Defender
                },
                new Player
                {
                    FullName = "N'Golo Kanté",
                    Number = 13,
                    Position = PlayerPosition.Midfielder
                },
                new Player
                {
                    FullName = "Blaise Matuidi",
                    Number = 14,
                    Position = PlayerPosition.Midfielder
                },
                new Player
                {
                    FullName = "Steven Nzonzi",
                    Number = 15,
                    Position = PlayerPosition.Midfielder
                },
                new Player
                {
                    FullName = "Paul Pogba",
                    Number = 6,
                    Position = PlayerPosition.Midfielder
                },
                new Player
                {
                    FullName = "Corentin Tolisso",
                    Number = 12,
                    Position = PlayerPosition.Midfielder
                },
                new Player
                {
                    FullName = "Ousmane Dembélé",
                    Number = 11,
                    Position = PlayerPosition.Striker
                },
                new Player
                {
                    FullName = "Nabil Fekir",
                    Number = 18,
                    Position = PlayerPosition.Striker
                },
                new Player
                {
                    FullName = "Olivier Giroud",
                    Number = 9,
                    Position = PlayerPosition.Striker
                },
                new Player
                {
                    FullName = "Antoine Griezmann",
                    Number = 7,
                    Position = PlayerPosition.Striker
                },
                new Player
                {
                    FullName = "Thomas Lemar",
                    Number = 8,
                    Position = PlayerPosition.Striker
                },
                new Player
                {
                    FullName = "Kylian Mbappé",
                    Number = 10,
                    Position = PlayerPosition.Striker
                },
                new Player
                {
                    FullName = "Florian Thauvin",
                    Number = 20,
                    Position = PlayerPosition.Striker
                }
            };
        }
    }
}
