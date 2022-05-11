using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizardry_.Models
{
    public class Dice : Random
    {
        public int sides { get; set; }

        public Dice()
        {
            _ = new Random();
        }

        public static int Roll()
        {
            Dice diceRoll = new Dice();

            int rollNum = diceRoll.Next(1,6);

            return rollNum;
        }


    }
}
