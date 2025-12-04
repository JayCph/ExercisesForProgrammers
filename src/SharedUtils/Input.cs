using System;

namespace SharedUtils
{
    public static class Input
    {
        // Helper to get a string ensuring it's not empty
        public static string GetString(string prompt)
        {
            Console.Write(prompt + " ");
            string output = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
                Console.Write(prompt + " ");
                output = Console.ReadLine();
            }

            return output;
        }

        // Helper to safely get an Integer
        public static int GetInt(string prompt)
        {
            int result;
            string input = GetString(prompt); // Reuse the method above!

            // Loop until the parse is successful
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("That is not a valid number. Please enter an integer.");
                // Ask again recursively or iteratively
                input = GetString(prompt);
            }

            return result;
        }

        // Helper to safely get a Double (for currency/math)
        public static double GetDouble(string prompt)
        {
            double result;
            string input = GetString(prompt);

            while (!double.TryParse(input, out result))
            {
                Console.WriteLine("That is not a valid number. Please enter a number.");
                input = GetString(prompt);
            }

            return result;
        }
    }
}

/**
  Phase 3: How to use it (Example: Task 1)
 Now, when you tackle Exer*cise 1 (Saying Hello), you don't need to write low-level console logic. You can focus purely on the business logic.

 File: src/Ex01/Program.cs
using SharedUtils; // Import your library

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // The prompt is handled by your Utils
            string name = Input.GetString("What is your name?");

            // The logic
            string greeting = $"Hello, {name}, nice to meet you!";

            // Output
            Console.WriteLine(greeting);
        }
    }
}

File: src/Ex05/Program.cs (Simple Math) You can see how much cleaner the math exercises become:
C#

using SharedUtils;

// ... inside Main ...
int firstNum = Input.GetInt("What is the first number?");
int secondNum = Input.GetInt("What is the second number?");

Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
// etc...

# Usage: make run p=01
**/
