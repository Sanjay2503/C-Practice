//using System;
//namespace thiskeyword
//{
//    class Test
//    {
//        public Test(int num1, int num2) {
//            Console.WriteLine("Constructor with two parametres :");
//        }
//        public Test(int num) :this(4,3)
//        {
//            Console.WriteLine("Constructor with one parameter");
//        }
//        public static void Main(string[] args)
//        {
//            Test t1 = new Test(4);
//        }
//    }
//}

using System;
namespace thiskeyword
{
    class stringdata
    {
        private string[] name = new string[3];

        public string this[int index]
        {
            get
            {
                return name[index];
            }
            set
            {
                name[index] = value;
            }
        }
    }
        class program { 
        public static void Main(string[] args)
        {
            stringdata s1 = new stringdata();
            s1[0] = "sanjay";
            s1[1] = "rahul";
            s1[2] = "suresh";

            for (int i =0;i<3;i++)
            {
                Console.WriteLine(s1[i]);
            }
        }
    }
}