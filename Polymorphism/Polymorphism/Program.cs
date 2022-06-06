using System;
namespace polymorphism
{
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The Aniaml Sound ");
        }
    }
        class Pig : Animal
        {
            public override void AnimalSound()
            {
                Console.WriteLine("The Pig Sound");
            }
        }
        class Horse : Animal
        {
            public override void AnimalSound()
            {
                Console.WriteLine("The Horse Sound");
            }
        }

    class program
    {
        public static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Pig pig1 = new Pig();
            Horse horse1 = new Horse();

            animal1.AnimalSound();
            pig1.AnimalSound();
            horse1.AnimalSound();


            
        }
    }
}