﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLibrary.Moveing
{
    public class StateSouth : Istate
    {
        public Position NextMove(char input)
        {
            switch (input)
            {
                case 'a':
                    return new Position(1, 0);
                case 'd':
                    return new Position(-1, 0);
                case 'w':
                    return new Position(0, 1);
                default: return new Position(0, 0);
            }
        }

        public Istate NextState(char input)
        {
            switch (input)
            {
                case 'a':
                    return new StateEast();
                case 'd':
                    return new StateWest();
                case 'w':
                    return new StateSouth();
                default: return new StateSouth();
            }
        }
    }
}
