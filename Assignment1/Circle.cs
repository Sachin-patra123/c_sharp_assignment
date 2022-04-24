using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Circle
    {
        static void circle(int r)
        {
            
            Console.WriteLine("Area = " + Math.PI * Math.Pow(r, 2));
            Console.WriteLine("Circumference = " + 2 * Math.PI * r);
        }
        static void Main(string[] args)
        {
            int r = 3;
            circle(r);
            //Circle.circle(r);
            Console.ReadLine();
        }
    }
}
