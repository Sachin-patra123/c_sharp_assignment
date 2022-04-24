using System;

namespace Assignment1
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.Write("Enter Choice(1-4):");
            int ch = Int32.Parse(Console.ReadLine());
            int a, b, c;

            Console.Write("Enter A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B:");
            b = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine("Sum = {0}", c);
                    break;
                case 2:
                    c = a - b;
                    Console.WriteLine("Difference = {0}", c);
                    break;
                case 3:
                    c = a * b;
                    Console.WriteLine("Multiplication = {0}", c);
                    break;
                case 4:
                    c = a / b;
                    Console.WriteLine("Division = {0}", c);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.ReadKey();

        }
    }
}
