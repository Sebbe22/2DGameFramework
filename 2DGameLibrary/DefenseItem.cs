using _2DGameLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLibrary
{
    public class DefenseItem : Item
    {

        public DefenseItem(string name, int hit)
        {
            Name = name;
            Hit = hit;
        }
        public string Name { get; set; }

        public int Hit { get; set; }
    }
}
