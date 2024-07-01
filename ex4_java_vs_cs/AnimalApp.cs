using System;

abstract class Animal{
    
    // by default access modifier is private
   public int noOfLegs;
    
    public abstract void sleep();
    public abstract void eat();
    public abstract void makeSound();
}

class Dog : Animal{
     public override void sleep(){
         Console.WriteLine("Dog is Sleeping");
     }
    public override void eat(){
        Console.WriteLine("Dog is eating");
    }
    public override void makeSound(){
         Console.WriteLine("Dog sound is wowf.... ");
    }
}

public class AnimalApp
{
    public static void Main(string[] args)
    {
       Dog dog=new Dog();
       dog.noOfLegs=4;
       dog.sleep();
       dog.eat();
       dog.makeSound();
    }
}