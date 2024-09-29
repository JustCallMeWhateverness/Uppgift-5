using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Välkommnar användaren
            Console.WriteLine("Welcome to the simple Calculator! :)");


            char operation = ValidOperation();


            double number1 = ValidNumber("\nEnter the first number: ");

            double number2 = ValidNumber("Enter the second number: ");

            double result = 0;

            //Kör kontroll om operationen som är vald är division 
            if (operation == '/')
            {
                number2 = DivisionByZero(number2);
            }


            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine(operation + "Invalid input");

                    break;
            }


            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
        //Kontrollerar om användaren skriver in en giltigt operation
        static char ValidOperation()
        {
            char operation;
            while (true)
            {
                Console.WriteLine("Enter the operator: (+, -, *,/):");
                operation = Console.ReadKey().KeyChar;
                if (operation == '+' || operation == '-' || operation == '*' || operation == '/')
                {
                    break;  // Lämnar loopen om operationen är giltig
                }
                else
                {
                    Console.WriteLine("\nInvalid operation");
                }
            }
            return operation;
        }
        //Kontrollerar använding av 0 vid division
        static double DivisionByZero(double number2)
        {
            while (number2 == 0)
            {

                Console.WriteLine("Sorry! Dividing by zero is not allowed. Enter another number:");
                number2 = Convert.ToDouble(Console.ReadLine());
            }
            return number2;
        }
        //Kontrollerar om användaren skriver in giltiga nummer
        static double ValidNumber(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if (double.TryParse(input, out double number))
                {
                    return number;
                }
                Console.WriteLine("Invalid number.");
            }
        }

    }
}
