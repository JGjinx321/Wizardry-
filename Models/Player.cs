using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizardry_.Models
{
    public class Player
    {
        public int Health { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public string FirstName { get; set;  }

        public string LastName { get; set; }

        public Player(string firstName = "", string lastName = "")
        {
            Health = 100;
            FirstName = firstName;
            LastName = lastName;
            Attack = 10;
            Defense = 10;
        }

        public static void PlayerDeath()
        {
            Console.WriteLine("You are dead!");
        }

        public static void GetPlayer(Player player)
        {
            Console.WriteLine($"Your attack sits at {player.Attack}");

            Console.WriteLine($"Your defense sits at {player.Defense}");

            Console.WriteLine($"Your health sits at {player.Health}");
        }

        public static void PlayerAttack()
        {
            PlayerAttack
        }

    }


}
