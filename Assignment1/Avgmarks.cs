using System;

namespace Assignment1
{
    internal class Avgmarks
    {
        static void Main(string[] args)
        {
            int avgmark1;
            int avgmark2;
            int avgmark3;
            int avgmark4;
            int avgmark5;
            Console.WriteLine("Enter avgmark1 = ");
            avgmark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter avgmark2 = ");
            avgmark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter avgmark3 = ");
            avgmark3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter avgmark4 = ");
            avgmark4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter avgmark5 = ");
            avgmark5 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Highest Mark = " + Math.Max(Math.Max(Math.Max(Math.Max(avgmark1, avgmark2), avgmark3), avgmark4), avgmark5));
            Console.WriteLine("Highest Mark = {0} ",Math.Max(Math.Max(Math.Max(Math.Max(avgmark1, avgmark2), avgmark3), avgmark4), avgmark5));
            Console.ReadKey();
        }

    }
}
