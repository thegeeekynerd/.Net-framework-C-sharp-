using System;
namespace constructor
{
    class program
    {
        int i=10; 
        int a=10;
        public static void Main(string[] args)
        {
            string i;
            int a;
            Console.WriteLine("enter any number:");
            i = (Console.ReadLine());
            a= Convert.ToInt32(i);
            if (a < 0)
            {
                Console.WriteLine("it is a negative number");
            }
            else
            {
                Console.WriteLine("it is a positive number");
            }
            Console.ReadLine();
        }
    }
}
