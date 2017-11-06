using System;

namespace Testing.Models
{
    public class Circle : Shape
    {
        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public double Radius { get; private set; }

        public override double Area { get => Math.Pow(Radius, 2) * Math.PI; }

        public override double Perimeter { get => Radius * Math.PI * 2d; }
    }
}