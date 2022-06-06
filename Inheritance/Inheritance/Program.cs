using System;
using System.Collections.Generic;
namespace Application
{
    class program
    {
         static void Main(string[] args)
        {
            Car c1 = new Car();

            c1.horn();

            Console.WriteLine(c1.brand + " " + c1.model);
        }
    }
}