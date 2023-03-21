namespace Inheritance.Models
{
    public class Dog : Animal
    {
        public string Color { get; set; }
        //first call the default constructor from the base class(Animal),
        //Then execute the default constructor from the Dog class

        //Always. When we call constructor from the inherited classes, the default constructor from the base calss
        //is being called. Unless when we specify it in a different way;
        public Dog() : base() 
        {
            Console.WriteLine("Calling default Dog constructor");
        }
        //public Dog(string name, string color)
        //{
        //    Name = name;
        //    Color = color;
        //}
        public Dog(string name, string color) : base("Dog")
        {
            Name = name;
            Color = color;
        }
        public override void PrintIdentifier()
        {
            Console.WriteLine($"Identifier: {Identifier}");
        }

    }    
}
