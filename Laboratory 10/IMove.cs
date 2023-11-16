using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_10
{
    internal interface IMove
    {
        Coordinates MoveVert(int distance);
        Coordinates MoveHoriz(int distance);
    }
}
