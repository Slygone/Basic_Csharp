using Task02.Enums;
using Task02.Models;

List<Animal> animals = new List<Animal>()
{
    new Animal("Buddy", "Brown", 5,"Dog", Gender.Male),
    new Animal("Luna", "Black", 2,"Dog", Gender.Female),
    new Animal("Max", "White", 3, "Dog", Gender.Male),
    new Animal("Sadie", "Golden", 4,"Dog", Gender.Female),
    new Animal("Aly", "White", 5,"Dog", Gender.Female),
    new Animal("Rocky", "Gray", 6,"Dog", Gender.Male),
    new Animal("Mr.Whiskers", "Gray", 4,"Cat", Gender.Male),
    new Animal("Smokey", "Black", 6,"Cat" ,Gender.Female),
    new Animal("Oliver", "Orange", 2,"Cat", Gender.Male),
    new Animal("Luna", "White", 5,"Cat", Gender.Female),
    new Animal("Sapphire", "Blue", 1,"Cat", Gender.Female),
    new Animal("Aloha", "Spotted White", 3,"Cat", Gender.Female)
};
//Find the names of all the animals aged 5 or more 
List<Animal> animalsAged5OrMore = animals.Where(x => x.Age >= 5).ToList();
foreach (Animal animal in animalsAged5OrMore)
{
    Console.WriteLine($"The {animal.Race} with the age 5 or older are: { animal.Name}");
}

//Find all the names of the animals that start with 'A' 
List<Animal> animalsNamesThatStartWithA = animals.Where(x => x.Name.StartsWith("A")).ToList();
foreach(Animal animal in animalsNamesThatStartWithA)
{
    Console.WriteLine($"The {animal.Race} that name starts with \'A\' are: {animal.Name}");
}

// Find all male, brown animals
List<Animal> allMaleBrownAnimals = animals.Where(x => x.Gender == Gender.Male && x.Color == "Brown").ToList();
foreach(Animal animal in allMaleBrownAnimals)
{
    Console.WriteLine($"The {animal.Race} that is {animal.Gender} and {animal.Color} are: {animal.Name}");
}

//Find the first animal whose name is longer than 10 characters
//List<Animal> firstAnimalThatNameIsLongerThan10 = animals
//    .Where(x => x.Name.Length > 10).ToList();
//foreach(Animal animal in firstAnimalThatNameIsLongerThan10)
//{
//    Console.WriteLine($"The first {animal.Race} who's name is longer than 10 characters is: {animal.Name}");
//}
Animal firstAnimalThatNameIsLongerThan10 = animals.FirstOrDefault(x => x.Name.Length > 10);
if (firstAnimalThatNameIsLongerThan10 != null)
{
    Console.WriteLine($"The first {firstAnimalThatNameIsLongerThan10.Race} who's name is longer than 10 characters is: {firstAnimalThatNameIsLongerThan10.Name}");
}
else
{
    Console.WriteLine("No animal found with a name longer than 10 characters.");
}
