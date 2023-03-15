namespace Exercise02
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human()
        {

        }
        public Human(string firstName, string lastName, int age)
        {
            if(string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine("Invalid FirstName value");
                FirstName = "Default Value";

            }
            else
            {
                FirstName = firstName;
            }
            if (string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("Invalid LastName value");
                LastName = "Default Value";
            }
            else
            {
                LastName = lastName;
            }
            if(age < 0 || age > 100)
            {
                Console.WriteLine("Invalid age value");
                Age = 0;
            }
            else
            {
                Age = age;
            }
        }
        public string GetPersonStats()
        {
            return $"{FirstName} {LastName} {Age}";
        }

    }
}
