using _2DGameLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLibrary
{
    public class AttackItem : Item
    {
        public AttackItem(string name, int hit, int range)
        {
            Name = name;
            Hit = hit;
            Range = range;
        }
        public string Name { get; set; }

        public int Hit { get; set; }

        public int Range { get; set; }
    }
}
