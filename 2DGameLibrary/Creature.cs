using _2DGameLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLibrary
{
    public class Creature : WorldEntety
    {
        public List<Item> ItemList { get; set; }
        public Position Position { get; set; }
        public int HP { get; set; }
        public string Name { get; set; }

        public Creature(Position pos, int hp, string name)
        {
            Position = pos;
            HP = hp;
            Name = name;
        }

        public int Attack(Creature target, int hit)
        {
            target.ReceiveHit(hit);
            return hit;
        }

        public Item Loot(Item drop)
        {
            return drop;
        }

        public void ReceiveHit(int hitAmount)
        {

            HP = HP - hitAmount;
        }

        public void PickUpItem(Item itemToAdd)
        {
            ItemList.Add(itemToAdd);
        }


    }
}
