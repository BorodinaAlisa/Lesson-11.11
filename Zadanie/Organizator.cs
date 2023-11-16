using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zadanie
{
    internal class Organizator : Person
    {
        public Organizator(string name) : base(name)
        {

        }
        public override void Print()
        {
            Console.WriteLine($"Организaтор: {name}");
        }
    }
}
