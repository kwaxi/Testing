using System;

namespace Testing.Models
{
    public class Square : Shape
    {
        public Square(double edge) : base("Square")
        {
            Edge = edge;
        }

        public double Edge { get; private set; }

        public override double Area { get => Math.Pow(Edge, 2); }

        public override double Perimeter { get => Edge * 4d; }
    }
}