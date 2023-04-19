using _2DGameLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLibrary
{
    /// <summary>
    /// Item for attacking can be "equipped" by creatures
    /// </summary>
    public class AttackItem : Item
    {
        /// <summary>
        /// constructor for attack item
        /// </summary>
        /// <param name="name">name of the item</param>
        /// <param name="hit">amount you want the item to increase the wearers damage delt</param>
        public AttackItem(string name, int hit)
        {
            Name = name;
            Hit = hit;
        }
        public string Name { get; set; }

        public int Hit { get; set; }

    }
}
