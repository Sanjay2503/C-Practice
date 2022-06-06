//using System;
//namespace tryy_catch
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                int[] mynumber = { 1, 2, 3 };
//                Console.WriteLine(mynumber[10]);

//            }
//            catch(Exception e)
//            {
//                Console.WriteLine("You have passed Wrong index");
//            }
//        }
//    }
//}


using System;

namespace Exception
{
   
    class program
    {
        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Acces denied--- You are not alligible for this criteria");
            }
            else
            {
                Console.WriteLine("Congrats you have old enough");
            }
        }

        static void Main(string[] args)
        {
            CheckAge(2);
        }
    }
}
