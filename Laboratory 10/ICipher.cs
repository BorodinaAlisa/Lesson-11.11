using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_10
{
    public interface ICipher
    {
        string Encode (string text);
        string Decode (string text);
    }
}
