using Task02.Enums;

namespace Task02.Models
{
    public class Animal
    {
        public string Name { get; set; }    
        public string Color { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public Gender Gender { get; set; }
        public Animal(string name, string color, int age,string race, Gender gender)
        {
            Name = name;
            Color = color;
            Age = age;
            Race = race;
            Gender = gender;
        }
    }    
}
