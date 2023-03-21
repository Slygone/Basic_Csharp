
namespace Inheritance.Models
{
    public class Cat : Animal
    {
        //gets the public and protected properties and methods from Animal
        public bool isLazy { get; set; }
        //Using the protected properties
        public void PrintAge()
        {
            Console.WriteLine($"The cat is {Age} years old.");
        }
        //first call the default constructor from the base class(Animal),
        //Then execute the default constructor from the Cat class
        public Cat() : base()
        {
            Console.WriteLine("Calling default Cat constructor");
        }

        //public void PrintIdentifierForCat()
        //{
        //    Console.WriteLine($"Identifier: {Identifier}");
        //}

        //OVERRIDING METHODS
        public override void PrintIdentifier()
        {
            Console.WriteLine($"Identifier: {Identifier}");
        }
    }
}
