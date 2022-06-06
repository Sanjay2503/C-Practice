// See https://aka.ms/new-console-template for more information
using System;
 namespace HeloWorld
{
    class Car
    {
        string model;
        string color;
        int year;
        
        public static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "Red";
            Ford.year = 2020;

            Car Toyota = new Car();
            Toyota.model = "Fortuner";
            Toyota.color = "Black";
            Toyota.year = 2018;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Toyota.color);
        }
       
    }
}