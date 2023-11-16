using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_10
{
    internal interface IChangeState
    {
        State ChangeState(State state);
    }
}
