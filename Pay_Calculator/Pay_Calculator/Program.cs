using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pay Calculator
             //The code provided will print ‘Hello World’ to the console.
             //Press Ctrl+F5(or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Please enter the number of hours worked.");
            double hoursWorked = double.Parse(Console.ReadLine());
            double payRate = 7.25;

            double totalPay = hoursWorked * payRate;

            Console.WriteLine(totalPay);
            Console.ReadLine();



            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
