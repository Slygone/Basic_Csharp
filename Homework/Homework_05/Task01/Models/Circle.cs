
namespace Task01.Models
{
    public class Circle : Shape
    {
        private int _radius;

        public Circle(string name, string color, int[] position, int radius)
            : base(name, color, position)
        {
            _radius = radius;
        }
        public override void getArea()
        {
            Console.WriteLine($"The area of the circle with the radius of: {_radius} " +
                $"is: {Math.PI * _radius * _radius}");
        }
        public override void getPerimeter()
        {
            Console.WriteLine($"The perimeter of the circle with the radius of: {_radius} " +
                $"is: {2 * Math.PI * _radius}");
        }

        public override void Move()
        {
            Position[0] += 5;
            Position[1] += 5;
            Console.WriteLine($"The position for x axis is increasing by: " +
                $"{Position[0]} and for y axis is increasing by: {Position[1]}");
        }
    }
}
