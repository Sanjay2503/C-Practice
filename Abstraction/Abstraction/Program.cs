using System;
namespace Abstraction
{
    abstract class Animal //base class 
    {
        public abstract void animalSound();//abstract method which has not body

        public void sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzz");
        }
    } 
    class Pig : Animal
    {
        public override void animalSound()///use override for the override bas class method(animal class)
        {
            Console.WriteLine("wewewewewewwwe");
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Pig mypig = new Pig();
            mypig.animalSound();
            mypig.sleep();
        }
    }
}