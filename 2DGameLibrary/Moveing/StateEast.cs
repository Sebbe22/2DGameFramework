using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLibrary.Moveing
{
    public class StateEast : Istate
    {
        public Position NextMove(char input)
        {
            switch (input)
            {
                case 'a':
                    return new Position(0, 1);
                case 'd':
                    return new Position(0, -1);
                case 'w':
                    return new Position(1, 0);
                default: return new Position(0, 0);
            }
        }

        public Istate NextState(char input)
        {
            switch (input)
            {
                case 'a':
                    return new StateNorth();
                case 'd':
                    return new StateSouth();
                default: return new StateEast();
            }
        }
    }
}
