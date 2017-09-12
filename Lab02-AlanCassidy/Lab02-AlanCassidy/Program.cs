using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_AlanCassidy
{
    public class Product
    {
        static void Main(string[] args)
        {
            int x; // stores first number to be entered by user
            int y; // stores second number to be entered by user
            int z; // stores third number to be entered by user
            int result; // product of numbers

            Console.Write("enter first integer:"); // prompt for input
            x = Convert.ToInt32(Console.ReadLine()); // read first integer

            Console.Write("enter second integer:"); // prompt for input
            y = Convert.ToInt32(Console.ReadLine()); // read second 

            Console.Write("enter third integer:"); // prompt for input
            z = Convert.ToInt32(Console.ReadLine()); // read third integer

            result = (x + y) * (z + 10); // calculate product of numbers

            Console.WriteLine("Product is {0}", result);
        } // end main
    } // end class addition
}


