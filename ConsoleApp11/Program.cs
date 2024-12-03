using ConsoleApp11;
using System;

namespace Practice
{
    class Program
    {
            static void Main(string[] args)
            {
                 
                 MyUserInput input = new MyUserInput();

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("                  Calculator                     ");
                Console.WriteLine("-------------------------------------------------");

                while (true)
                {
                    input.GetUserInput(); // Prompt user input
                    input.CalculateValues(); // Perform calculations
                }
            }

        
    }
}