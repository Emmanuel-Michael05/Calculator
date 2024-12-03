using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class MyUserInput
    {
        public int UserInput { get; set; } // Store the user choice

        public void GetUserInput()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("What do you want to do:");
                    Console.WriteLine("1. ADDITION");
                    Console.WriteLine("2. SUBTRACTION");
                    Console.WriteLine("3. MULTIPLICATION");
                    Console.WriteLine("4. DIVISION");
                    Console.WriteLine("5. PERCENTAGE");
                    Console.WriteLine("6. MODULUS");
                    Console.WriteLine("7. SQUARE-ROOT");
                    Console.WriteLine("8. EXIT");

                    int num = int.Parse(Console.ReadLine());

                    UserInput = num;

                    if (UserInput < 1 || UserInput > 8)
                    {
                        Console.WriteLine("Invalid choice! Please select a number between 1 and 8.");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }
        }

        // Method to calculate based on user input
        public void CalculateValues()
        {
            double result = 0;

            switch (UserInput)
            {
                case 1: // Addition
                    Console.WriteLine("Enter first value: ");
                    double addFirst = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second value: ");
                    double addSecond = double.Parse(Console.ReadLine());

                    result = addFirst + addSecond;
                    Console.WriteLine($"The result of addition is: {result}");
                    break;

                case 2: // Subtraction
                    Console.WriteLine("Enter first value: ");
                    double subFirst = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second value: ");
                    double subSecond = double.Parse(Console.ReadLine());

                    result = subFirst - subSecond;
                    Console.WriteLine($"The result of subtraction is: {result}");
                    break;

                case 3: // Multiplication
                    Console.WriteLine("Enter first value: ");
                    double mulFirst = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second value: ");
                    double mulSecond = double.Parse(Console.ReadLine());

                    result = mulFirst * mulSecond;
                    Console.WriteLine($"The result of multiplication is: {result}");
                    break;

                case 4: // Division
                    Console.WriteLine("Enter first value: ");
                    double divFirst = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second value: ");
                    double divSecond = double.Parse(Console.ReadLine());

                    if (divSecond == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                    else
                    {
                        result = divFirst / divSecond;
                        Console.WriteLine($"The result of division is: {result}");
                    }
                    break;

                case 5: // Percentage
                    Console.WriteLine("Enter the value: ");
                    double percentageValue = double.Parse(Console.ReadLine());

                    result = percentageValue / 100;
                    Console.WriteLine($"The percentage is: {result}");
                    break;

                case 6: // Modulus
                    Console.WriteLine("Enter the value: ");
                    double modulusValue = double.Parse(Console.ReadLine());

                    result = modulusValue % 2;
                    Console.WriteLine($"The modulus is: {result}");
                    break;

                case 7: // Square Root
                    Console.WriteLine("Enter the value: ");
                    double sqrtValue = double.Parse(Console.ReadLine());

                    if (sqrtValue < 0)
                    {
                        Console.WriteLine("Cannot calculate square root of a negative number!");
                    }
                    else
                    {
                        result = Math.Sqrt(sqrtValue);
                        Console.WriteLine($"The square root is: {result}");
                    }
                    break;

                case 8: // Exit
                    Console.WriteLine("Exiting the program. Thank you!");
                    Environment.Exit(0); // Terminate the program
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.WriteLine("-------------------------------------------------");
        }

    }
}
