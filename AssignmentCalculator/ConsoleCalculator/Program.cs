using System;

namespace ConsoleCalculator
{   
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Welcome to Console Calculator in C#\r");
            Console.WriteLine("-----------------------------------\n");

            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";

                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter a number: ");
                    numInput1 = Console.ReadLine();
                }

                
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter a number: ");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an operator from the following list:\n");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide \n");
                Console.Write("Your selection? ");

                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "a":
                        Addition(cleanNum1, cleanNum2);
                        break;
                    case "s":
                        Substraction(cleanNum1, cleanNum2);
                        break;
                    case "m":
                        Multiplication(cleanNum1, cleanNum2);
                        break;
                    case "d":
                        Division(cleanNum1, cleanNum2);
                        break;
                    default:
                        Console.WriteLine("Not a valid selection, please try again");
                        break;
                }

                Console.WriteLine("------------------------\n");

                
                Console.Write("Press 'e' and Enter to exit the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "e") endApp = true;

                Console.WriteLine("\n"); 
            }
            return;
        }
        private static void Addition(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
        }
        private static void Substraction(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {result}");
        }
        private static void Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
        }
        private static void Division(double num1, double num2)
        {
            double result = 0;
            if (num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result}");
            }
            else
                Console.WriteLine("Its not possible to divide by 0!");
        }
    }
}
