using _2DGameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameImplementation
{
    public class Orc : Creature
    {
        public Orc(Position pos, int hp, string name) : base(pos, hp, name)
        {

        }

        public void AttackPrint(Creature target)
        {
            Console.WriteLine($"Orc did {Attack(target, 10)} damage!");
        }
    }
}
