using System;
namespace hello
{ class car2
    {
        string brand;
        car2(string thebrand);
        {
    brand=thebrand;
        } }
    class program
    {
        public static void Main(string[] args)
        {
            // new program();    // call a constructor with new keyword
            //console.readline();

            car2 car1 = new car2("Mustang");
            Console.WriteLine(car1.brand);
        }
    }
}


//using System;
//namespace hello
//{
//    class Car
//    {

//        string brand;

//        Car(string newbrand)//create constructor
//        {
//            brand = newbrand;
//        }
//        Car(Car c1)//copy constructor
//        {
//            brand = c1.brand;
//        }

//        public static void Main(string[] args)
//        {
//            Car car1 = new Car("Bugati");
//            Console.WriteLine("brand :" + car1.brand);

//            Car car2 = new Car(car1); 
//            Console.WriteLine("brand :" + car2.brand);
//        }
//    }
//}