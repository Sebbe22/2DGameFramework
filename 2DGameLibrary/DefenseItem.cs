using _2DGameLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLibrary
{
    /// <summary>
    /// Item for defense can be "equipped" by creatures
    /// </summary>
    public class DefenseItem : Item
    {
        /// <summary>
        /// constructor for defense item
        /// </summary>
        /// <param name="name">name of the item</param>
        /// <param name="hit">the amount of damage you want the item to reduce</param>
        public DefenseItem(string name, int hit)
        {
            Name = name;
            Hit = hit;
        }
        public string Name { get; set; }

        public int Hit { get; set; }
    }
}
