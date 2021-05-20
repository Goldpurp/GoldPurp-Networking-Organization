using System;

namespace Goldpurp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("GoldPurp Networking Organization Employee intake");

            Console.WriteLine("Enter Your Age");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 0 || age > 100)

            {
                Console.WriteLine("Invalid age");
            }
            else if (age < 21)
            {
                Console.WriteLine("You're an underage");
            }
            else if (age > 45)
            {
                Console.WriteLine("You're too old for the task");
            }
            else
            {
                Console.WriteLine("Welcome TO G.N.O");
            }

        }
    }
}
