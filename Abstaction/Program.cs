using System;

//Abstraction 2 vabe hoy:
// 1. Abstract class
// 2. Interface

// Abstract class er khetre abstract keyword use korte hoy.


abstract class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name; 
    }

    //abstarct method
    public abstract void MakeSound();

    public void ShowName()
    {
        Console.WriteLine($"Animal is : {Name}.");
    }
}

//akhon dog inherit korse animal ke, jar karone o , animal er sokol kisu access korte parbe, but vhitore kono abstract method thakle ta override kortei hobe,...

class Dog : Animal
{
    public Dog(string name):base(name)
    {
        
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} is dog and sounds woof woof!!");
    }

}

class Cat : Animal
{
    public Cat(string name):base(name)
    {
        
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} is cat and sounds meow meow...");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog("Tom");
        Animal cat = new Cat("Meow");
        dog.MakeSound();
        dog.ShowName();
    }
}