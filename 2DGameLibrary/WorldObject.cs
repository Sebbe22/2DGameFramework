using _2DGameLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLibrary
{
    public class WorldObject : WorldEntety
    {
        public Position Position { get; set; }
        public List<Item> ItemList { get; set; }
        public string Name { get; set; }
        public bool Removable { get; set; }
    }
}
