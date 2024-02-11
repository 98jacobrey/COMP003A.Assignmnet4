using System;
/*
 * Author:  Jacob Autrey
 * Course:  COMP-003A-L01
 * Purpose: ASsignment 4
 */

namespace COMP003A.Assignmnet4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a positive integer!");
            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(output);
                output += "#";
            }

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
            foreach (var friend in friends)
            {
                Console.WriteLine(friend);
            }

            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter += 5;
            } while (counter <= 50);

            int counter2 = 1;
            while (counter <= 20)
            {
                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else
                {
                    Console.WriteLine(counter2);
                }
                counter2 += 1;
            }

        }
    }
}
