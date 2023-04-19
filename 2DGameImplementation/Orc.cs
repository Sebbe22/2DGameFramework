using _2DGameLibrary;
using _2DGameLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace _2DGameImplementation
{
    public class Orc : Creature
    {
        public Orc(Position pos, int hp, string name, int hit) : base(pos, hp, name, hit)
        {

        }

        public override Item Loot()
        {
            Random random = new Random();
            int chance = random.Next(1, 34);
            int chance2 = random.Next(1, 34);
            int chance3 = random.Next(1, 34);

            int[] chances = { chance, chance2, chance3 };

            IEnumerable<int> totalChances =
                from number in chances
                where number > 0
                select number;


            if(totalChances.Sum() < 10)
            {
                return new AttackItem("orc sword", 20);
            }
            else if (totalChances.Sum() > 10 && chance < 50)
            {
                return new DefenseItem("orc gloves", 7);
            }
            else
            {
                return new AttackItem("orc arrow", 4);
            }
        }
    }
}
