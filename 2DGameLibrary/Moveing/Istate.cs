using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLibrary.Moveing
{
    public interface Istate
    {
        /// <summary>
        /// listens to input and takes action depending on what direction the
        /// player is currently facing.
        /// </summary>
        /// <param name="input"> a character either a or d</param>
        /// <returns>returns the direction of the movement as coordinates</returns>
        Position NextMove(char input);
        /// <summary>
        /// sets the next appropriate state depending on what the users input was
        /// </summary>
        /// <param name="input"> the users input as a character </param>
        /// <returns> returns the next state </returns>
        Istate NextState(char input);
    }
}
