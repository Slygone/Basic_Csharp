namespace retro.Models
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }
        public Students(string firstName, string lastName, string academy, string group)
        {
            //if (string.IsNullOrEmpty(firstName))
            //{
            //    Console.WriteLine($"Invalid value for {firstName}");
            //    FirstName = "Unknown";
            //}
            //if (string.IsNullOrEmpty(firstName))
            //{
            //    Console.WriteLine($"Invalid value for {lastName}");
            //    LastName = "Unknown";
            //}
            //if (string.IsNullOrEmpty(academy))
            //{
            //    Console.WriteLine($"Invalid value for {academy}");
            //    Academy = "Unknown";
            //}
            //if (string.IsNullOrEmpty(group))
            //{
            //    Console.WriteLine($"Invalid value for {group}");
            //    Group = "Unknown";
            //}

            FirstName = ValidateInput(firstName, "firstName");
            LastName = ValidateInput(lastName, "lastName");
            Academy = ValidateInput(academy, "Academy");
            Group = ValidateInput(group, "Group");        
        }
        private string ValidateInput(string input,string field)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"Invalid value for {field}: {input}");
                return "Unknown";
            }
            return input;
        }
    }
}
