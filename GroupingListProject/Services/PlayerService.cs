using GroupingListProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    FullName = "Hugo Lloris",
                    Number = 23,
                    TypeOfPlayer = PostPlayer.Goalkeeper
                },
                new Player
                {
                    FullName = "Steve Mandanda",
                    Number = 23,
                    TypeOfPlayer = PostPlayer.Goalkeeper
                },
                new Player
                {
                    FullName = "Alphonse Areola",
                    Number = 23,
                    TypeOfPlayer = PostPlayer.Goalkeeper
                },
                new Player
                {
                    FullName = "Benjamin Pavard",
                    Number = 2,
                    TypeOfPlayer = PostPlayer.Defender
                },
                new Player
                {
                    FullName = "Djibril Sidibé",
                    Number = 19,
                    TypeOfPlayer = PostPlayer.Defender
                },
                new Player
                {
                    FullName = "Presnel Kimpembe",
                    Number = 3,
                    TypeOfPlayer = PostPlayer.Defender
                },
                new Player
                {
                    FullName = "Adil Rami",
                    Number = 17,
                    TypeOfPlayer = PostPlayer.Defender
                },
                new Player
                {
                    FullName = "Raphaël Varane",
                    Number = 4,
                    TypeOfPlayer = PostPlayer.Defender
                },
                new Player
                {
                    FullName = "Samuel Umtiti",
                    Number = 5,
                    TypeOfPlayer = PostPlayer.Defender
                },
                new Player
                {
                    FullName = "Raphaël Varane",
                    Number = 4,
                    TypeOfPlayer = PostPlayer.Defender
                },
                new Player
                {
                    FullName = "Lucas Hernandez",
                    Number = 21,
                    TypeOfPlayer = PostPlayer.Defender
                },
                new Player
                {
                    FullName = "Benjamin Mendy",
                    Number = 22,
                    TypeOfPlayer = PostPlayer.Defender
                },
                new Player
                {
                    FullName = "N'Golo Kanté",
                    Number = 13,
                    TypeOfPlayer = PostPlayer.Middle
                },
                new Player
                {
                    FullName = "Blaise Matuidi",
                    Number = 14,
                    TypeOfPlayer = PostPlayer.Middle
                },
                new Player
                {
                    FullName = "Steven Nzonzi",
                    Number = 15,
                    TypeOfPlayer = PostPlayer.Middle
                },
                new Player
                {
                    FullName = "Paul Pogba",
                    Number = 6,
                    TypeOfPlayer = PostPlayer.Middle
                },
                new Player
                {
                    FullName = "Corentin Tolisso",
                    Number = 12,
                    TypeOfPlayer = PostPlayer.Middle
                },
                new Player
                {
                    FullName = "Ousmane Dembélé",
                    Number = 11,
                    TypeOfPlayer = PostPlayer.Striker
                },
                new Player
                {
                    FullName = "Nabil Fekir",
                    Number = 18,
                    TypeOfPlayer = PostPlayer.Striker
                },
                new Player
                {
                    FullName = "Olivier Giroud",
                    Number = 9,
                    TypeOfPlayer = PostPlayer.Striker
                },
                new Player
                {
                    FullName = "Antoine Griezmann",
                    Number = 7,
                    TypeOfPlayer = PostPlayer.Striker
                },
                new Player
                {
                    FullName = "Thomas Lemar",
                    Number = 8,
                    TypeOfPlayer = PostPlayer.Striker
                },
                new Player
                {
                    FullName = "Kylian Mbappé",
                    Number = 10,
                    TypeOfPlayer = PostPlayer.Striker
                },
                new Player
                {
                    FullName = "Florian Thauvin",
                    Number = 20,
                    TypeOfPlayer = PostPlayer.Striker
                }
            };
        }
    }
}
