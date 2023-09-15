using System;
namespace Uppgift_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en multiplikation");
            string problem = Console.ReadLine();

            byte multIndex = (byte)problem.IndexOf("*");
            float tal1 = float.Parse(problem[..multIndex]);
            float tal2 = float.Parse(problem[(multIndex + 1)..]);

            Console.WriteLine($"={tal1*tal2}");
            
            Console.ReadKey();
        }
    }
}