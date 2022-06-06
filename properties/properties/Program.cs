using System;
namespace properties
{
    class person
    {
        //private string name;

        public string Name
        {
            //get { return name; }
            //set { name = value; }
            get;set;
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            person obj = new person();
            obj.Name = "Sanjay";
            Console.WriteLine(obj.Name);    
        }
    }
}