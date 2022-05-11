using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizardry_.Models
{
    class Enemies
    {
        public int Health { get; set; }

        public int Attack { get; set; }

        public string Name { get; set; }

        public Goblin()
        {
            Health = 30;

            Attack = 5;

            Name = "Goblin";
        }
    }
}
