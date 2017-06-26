using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Parse and Create the Fahrenheit Variable
            Console.WriteLine("Please enter the Fahrenheit temperature you would like to convert: ");
            int Fahrenheit = int.Parse(Console.ReadLine());
            Console.WriteLine();


            // Formula needed to convert to Celsius
            int fahrenheitToCelsius = ((Fahrenheit - 32) / 9) * 5;
            Console.WriteLine("The temperature for Celsius is {0}.", fahrenheitToCelsius);
            Console.ReadLine();


            // Parse and Create the Celsius Variable
            Console.WriteLine("Please enter the Celsius temperature you would like to convert: ");
            int Celsius = int.Parse(Console.ReadLine());
            Console.WriteLine();



            // Formula needed to convert to Fahrenheit
            int celsiusToFahrenheit = ((Celsius * 9) / 5) + 32;
            Console.WriteLine("The temperature for Fahrenheit is {0}.", celsiusToFahrenheit);
            Console.ReadLine();
            
        }
    }
}
