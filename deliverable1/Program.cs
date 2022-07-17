using System;

namespace deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("How many people are we making PB & J sandwiches for?");
                int P = int.Parse(Console.ReadLine());
                Console.WriteLine("you need:");

                Double bs = P * 2;
                Double pb = P * 2;
                Double j = P * 4;
                Double tl = Math.Ceiling(bs / 28);
                Double jpb = Math.Ceiling(pb / 32);
                Double jj = Math.Ceiling(j / 48);


                Console.WriteLine($"{j} teasoons of jelly.");
                Console.WriteLine($"{bs} slices of bread.");
                Console.WriteLine($"{pb} Tablespoons of peanutbutter.");



                Console.WriteLine("which is ...");
                Console.WriteLine($"{tl} loaves of bread");
                Console.WriteLine($"{jpb} jars of peanutbutter");
                Console.WriteLine($"{jj} jars of jelly");


                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                var s = Console.ReadLine();


                if (s.ToLower() != "yes")
                if (s.ToLower() != "y")

                 {
                    Console.WriteLine("Goodbye!");
                    break;
                 }

            }
        }
    }
}
