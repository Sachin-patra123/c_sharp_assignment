using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Paramarray
    {
        static int add(params int[] allnumber)
        {
            int sum = 0;
            foreach (int n in allnumber)
            {
                sum = sum + n;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum;
            // passing four parameters
            sum = Paramarray.add(1, 2, 3, 4);
            Console.WriteLine("Sum of 1,2,3,4 is:\t{0}", sum);
            Console.ReadLine();
        }
    }
}