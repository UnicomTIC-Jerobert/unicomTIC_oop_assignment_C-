abstract class Animal{
    // by default access modifier is public
    int noOfLegs;
    
    abstract void sleep();
    abstract void eat();
    abstract void makeSound();
}

class Dog extends Animal{
    public void sleep(){
         System.out.println("Dog is Sleeping");
     }
    public void eat(){
        System.out.println("Dog is eating");
    }
    public void makeSound(){
         System.out.println("Dog sound is wowf.... ");
    }
}

public class HelloWorld {
    public static void main(String[] args) {
     Dog dog=new Dog();
      dog.noOfLegs=4;
       dog.sleep();
       dog.eat();
       dog.makeSound();
    }
}