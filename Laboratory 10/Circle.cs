using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Laboratory_10.Coordinates;

namespace Laboratory_10
{
    internal class Circle : Point
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
        }
        public Circle(Color color, State state, Coordinates coordinates, double radius) : base(color, state, coordinates)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {radius}, Площадь: {CalculateArea()}");
        }
    }
}
