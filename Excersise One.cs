using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of gas station: ");
            string gasStation = Console.ReadLine();

            Console.Write("Enter the price of gas: ");
            double gasprice = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many gallons: ");
            double gallons = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the tax percentage for this transaction: ");
            double taxpercent = Convert.ToDouble(Console.ReadLine());

            // calculate 
            double subtotal = gasprice * gallons;

            // calculate tax
            double tax = subtotal * (taxpercent / 100);

            // calculate total
            double total = subtotal + tax;

            // display 
            Console.WriteLine();
            Console.WriteLine("******* " + gasStation + " *******");
            Console.WriteLine("Gas price: $" + gasprice.ToString("0.00"));
            Console.WriteLine("Number of gallons: " + gallons);
            Console.WriteLine("Tax rate: " + taxpercent + "%");
            Console.WriteLine("Subtotal: $" + subtotal.ToString("0.00"));
            Console.WriteLine("Tax: $" + tax.ToString("0.00"));
            Console.WriteLine("Total: $" + total.ToString("0.00"));

           
        }
    }
}
