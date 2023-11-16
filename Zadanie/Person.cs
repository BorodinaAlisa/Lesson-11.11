using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    internal abstract class Person
    {
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Person(string name)
        {
            this.name = name;
        }
        public abstract void Print();
    }
}
