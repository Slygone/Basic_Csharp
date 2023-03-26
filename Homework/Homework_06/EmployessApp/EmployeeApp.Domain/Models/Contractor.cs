
using EmployeeApp.Domain.Enums;

namespace EmployeeApp.Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Role role { get; set; }
        public Contractor(string firstName, string lastName, Role role, double salary) 
            : base(firstName, lastName, role, salary)
        {
            
        }
        public override double GetSalary()
        {
            return Salary = WorkHours * PayPerHour;
        }
        

        public void CurrentPosition()
        {
            Console.WriteLine($"The manager responsible for the ${FirstName} is {FirstName}");
        }
    }
}
