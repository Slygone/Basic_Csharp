
using EmployeeApp.Domain.Enums;

namespace EmployeeApp.Domain.Models
{
    public class Manager : Employee
    {
        // always _property to make it private for convention
        private double _bonus { get; set; }
        public Manager(string firstName,string lastName, Role role, double salary) 
            : base(firstName, lastName, role, salary) 
        {
            _bonus = 0;
        }

        public void AddBonus(double bonus)
        {
            _bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}
