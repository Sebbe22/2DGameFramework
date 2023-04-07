﻿using _2DGameLibrary.Interface;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

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
            ItemList = new List<Item>();
        }

        public void Attack(Creature target, int hit)
        {
            if (ItemList is not null && ItemList.Count != 0)
            {
                int modifiedHit = hit;
                foreach (Item item in ItemList)
                {
                    if (item is AttackItem)
                    {
                        modifiedHit = modifiedHit + item.Hit;
                    }
                }
                target.ReceiveHit(modifiedHit);
                CombatLog.Instance.LogCombatAttack(target, Name, modifiedHit);
            }
            else
            {
                CombatLog.Instance.LogCombatAttack(target, Name, hit);
                target.ReceiveHit(hit);
            }
        }

        public Item Loot(Item drop)
        {
            return drop;
        }

        public void ReceiveHit(int hit)
        {
            if (ItemList is not null && ItemList.Count != 0)
            {
                int modifiedHit = hit;
                foreach (Item item in ItemList)
                {
                    if (item is DefenseItem)
                    {
                        modifiedHit = modifiedHit - item.Hit;
                    }
                }
                CombatLog.Instance.LogCombatDefense(Name, modifiedHit);
                HP = HP - modifiedHit;
            }
            else
            {
                CombatLog.Instance.LogCombatDefense(Name, hit);
                HP = HP - hit;
            }
        }

        public void PickUpItem(Item itemToAdd)
        {
            ItemList.Add(itemToAdd);
        }
    }
}
