using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    enum Country
    {
        Россия,
        Казахстан,
        Франция,
        Китай
    }
    internal class Player : Person
    {
        private Country country;
        public Player(string name, Country country) : base(name)
        {
            this.country = country;
        }
        public override void Print()
        {
            Console.WriteLine($"Страна: {country}, Имя: {name}");
        }
    }
}
