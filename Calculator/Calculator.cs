using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Program
    {
        static void Main(string[] args)

            
        {
           //Simple Calculator

            Console.Write("Enter a number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
        }
    }
}
