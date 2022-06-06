//using System;
//namespace Interface
//{ 
//    interface IAnimal
//    {
//         void animalSound(); // interface method (does not have a body)
//        //void run();
//    }
//    // Pig "implements" the IAnimal interface
//    class Pig : IAnimal
//    {
//        public void animalSound()
//        {
//            // The body of animalSound() is provided here
//            Console.WriteLine("The Pig says : Weee Weee");
//        }
//    }
//    class program
//    {
//         static void Main(string[] args)
//        {
//            Pig mypig = new Pig(); // Create a Pig object
//            mypig.animalSound();
//        }
//    }
//}

using System; ///multiple interfaces
namespace Interface{
    interface IfirstInterface
    {
       public void Method();
    }
    interface IsecondInterface
    {
      public  void Method2();
    }
    class car : IfirstInterface,IsecondInterface  //inherit multiple interfaces
    {
        public void Method()
        {
            Console.WriteLine("My first Interface");

        }
        public void Method2()
        {
            Console.WriteLine("My second Interface");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            car obj = new car();
            obj.Method();
            obj.Method2();
        }
    }
}