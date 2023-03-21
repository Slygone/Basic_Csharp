using Inheritance.Models;

Animal animal = new Animal();
animal.Name = "Test Animal";
//animal.Id = 1; private so we can't access it!!!
animal.Type = "Test";
//animal.Age = 10; protected so we cant access it
animal.PrintIdentifier();

Cat cat = new Cat();
cat.Name = "Sharko";
cat.Type = "Cat";
cat.PrintIdentifier();


Dog dog = new Dog();
dog.Name = "Lesi";
dog.Type = "Dog";
dog.Color = "Black";
dog.PrintIdentifier();


Dog newDog =  new Dog("Lesi", "Brown");

newDog.PrintInfo();