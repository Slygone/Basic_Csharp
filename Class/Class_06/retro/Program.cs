using retro.Models;

Students[] students = new Students[5];
//Call the constructor with parms from the Students class, to initialize objects
students[0] = new Students("Tanja", "Stojanovska", "Programing", "G2");
students[1] = new Students("Stefan", "Trajkov", "Programing", "G4");
students[2] = new Students("Bojan", "Dimchevski", "QA", "G4");
students[3] = new Students("Jovana", "Jovanovska", "Networks", "G3");
students[4] = new Students("Nikola", "Nikolovski", "Design", "G7");

Console.Write("Enter a first name: ");
string input = Console.ReadLine();

Students foundStudent = FindStudent(students, input);
if(foundStudent != null)
{
    Console.WriteLine("We found the student!");
}
else
{
    Console.WriteLine("Student was not found!");
}
Students FindStudent(Students[] studentsArray, string firstName)
{
    foreach(Students student in studentsArray)
    {
        if(student.FirstName.ToLower()== firstName.ToLower())
        {
            return student;// stop the loop, exit the method
        }
    }
    return null;
}
