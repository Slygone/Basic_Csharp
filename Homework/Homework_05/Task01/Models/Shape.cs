namespace Task01.Models
{
    public class Shape
    {
        private string _name { get; set; }
        private string _color { get; set; }
        public int[] Position { get; set; }

        public Shape(string name, string color, int[] position) 
        {
            Name = name;
            Color = color;
            Position = position;
        }

        public string Name 
        {
            get { return _name; }
            set
            {
                _name = value;
                if(string.IsNullOrEmpty(_name))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    Console.WriteLine($"The name of the object is: {_name}");
                }
            }
        }
        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
                if( string.IsNullOrEmpty(_color) )
                {
                    Console.WriteLine("Invalid color!");
                }
                else
                {
                    Console.WriteLine($"The color is: {_color}");
                }
            }
        }

        public  virtual void getArea ()
        {
            Console.WriteLine($"There is no special implementation for area");
        }

        public virtual void getPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }
        public virtual void Move()
        {
            Position[0] += 5;
            Position[1] += 5;
            Console.WriteLine($"The position for x axis is increasing by: " +
                $"{Position[0]} and for y axis is increasing by: {Position[1]}");
        }
    }
}
