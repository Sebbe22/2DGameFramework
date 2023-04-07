using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLibrary.Moveing
{
    public class StateMachineMove
    {
        private Istate _state;

        public StateMachineMove()
        {
            _state = new StateNorth();
        }
        public Position MoveTrigger(char input)
        {
            Position output = _state.NextMove(input);
            _state = _state.NextState(input);
            return output;
        }
    }
}
