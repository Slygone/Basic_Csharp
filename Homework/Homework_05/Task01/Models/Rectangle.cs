

namespace Task01.Models
{
    public class Rectangle : Shape
    {
        private int _length;
        private int _width;

        public Rectangle(string name, string color, int[] position, int length, int width) 
            : base(name, color, position)
        {
            _length = length;
            _width = width;
        }
        public override void getArea()
        {
            Console.WriteLine($"The area has length of: {_length}, and width of: {_width}," +
                $"and has the area of {(_length) + (_width)}");
        }

        public override void getPerimeter()
        {
            Console.WriteLine($"The perimeter of the rectangle is: {2 + (_length + _width)}");
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
