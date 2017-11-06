namespace Testing.Models
{
    public abstract class Shape
    {
        public Shape(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public abstract double Area { get; }

        public abstract double Perimeter { get; }
    }
}