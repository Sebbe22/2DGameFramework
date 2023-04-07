using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLibrary.Interface
{
    public interface WorldEntety
    {
        public string Name { get; set; }
        public Position Position { get; set; }
    }
}
