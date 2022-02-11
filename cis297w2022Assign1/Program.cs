using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis297w2022Assign1
{
    /// <summary>
    /// This program implements some arithmetic functions as a calculator
    /// </summary>
    /// <Student>John Doe</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    class Program
    {
       static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
              
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Return a string without the Whitespaces");
            Console.WriteLine("2) Reverse a string");
            Console.WriteLine("9) Find the square root of the given number");
            Console.WriteLine("10) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1"://1.	Return a string without the Whitespaces
                    RemoveWhitespace();
                    return true;
                case "2"://2.	Reverse a string
                    ReverseString();
                    return true;
                case "9": // Sqrt-Square Root. This function returns the square root of the given number.
                    SquareRoot();
                    return true;
                case "10":
                    return false;
                default:
                    return true;
            }
        }

        /// <summary>
        /// This method captures user input as a string
        /// </summary>
        /// <returns>The <see cref="System.String"/returns>
        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// 2.	Reverse a string
        /// </summary>
        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }
        /// <summary>
        /// 1.	Return a string without the Whitespaces
        /// </summary>
        
        private static void RemoveWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Remove Whitespace");

            DisplayResult(CaptureInput().Replace(" ", ""));
        }

        /// <summary>
        /// Displays the result as a modified string
        /// </summary>
        /// <param name="message">The <see cref="System.String"/> message to display.</param>
        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        /// <summary>
        /// 9. Sqrt-Square Root. This function returns the square root of the given number.
        /// </summary>
               
        private static void SquareRoot()
        {
            Console.Clear();
            Console.WriteLine("Find the square root of the given number");
            Console.Write("Enter the number: ");
            double number7 = double.Parse(Console.ReadLine());
            Console.WriteLine("Square root of {0} is {1}.", number7, Math.Sqrt(number7));
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}
