using System;

namespace SubmissionOfInheritance
{
    public class Animal
    {
        string Name;
        int Age;

        // create Constructor of Animal class
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        // Create Method of Animal class that is virtual
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // create Subclass dog
    class Dog : Animal
    {
        //calling the animal class constructor
        public Dog(string name, int age) : base(name, age) { }
        public override void MakeSound()//overridden method
        {
            Console.WriteLine("Dog barks.");

        }
    }
    //create Subclass cat
    class Cat : Animal
    {
        //calling the animal class constructor
        public Cat(string name, int age) : base(name, age) { }
        public override void MakeSound()//overridden method
        {
            Console.WriteLine("Cat meows.");
        }
    }
    //create Subclass bird inherited by animal class
    class Bird : Animal
    {
        //calling the animal class constructor
        public Bird(string name, int age) : base(name, age) { }
        public override void MakeSound()//overridden method 
        {
            Console.WriteLine("Bird Chirps.");
        }
    }
}