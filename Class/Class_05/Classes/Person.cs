using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        //public property must start with CapitalLetter
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        //private cannot be accessed in other classes
        private long _ssn { get; set; }

        //Constructor
        //Constructor is always public and  has the name of the class
        //we need it in order to instantiate objects

        //Default Constructor
        public Person()
        {
            _ssn = new Random().Next(100000, 999999);
        }
        public Person(string firstName, string lastName, int age, long ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            if (ssn >= 100000 && ssn <= 999999)
            {
                _ssn = ssn;
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine($"FirstName: {FirstName},LastName: {LastName}, Age: {Age}, SSN: {_ssn}");
        }
        public long GetSSN()
        {
            return _ssn;
        }
        public void SetSSN(long ssn)
        {
            if (ssn >= 100000 && ssn <= 999999)
            {
                _ssn = ssn;
            }
        }
        public void Says(string message)
        {
            Console.WriteLine($"{FirstName} says {message}");
        }
    }
}
