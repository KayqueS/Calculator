using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;

            Console.WriteLine("---Calculator---");
            Console.WriteLine("----------------");

            try
            {
                Console.WriteLine();
                Console.WriteLine("[ 1 ] for Sum");
                Console.WriteLine("[ 2 ] for Subtraction");
                Console.WriteLine("[ 3 ] for Multiplication");
                Console.WriteLine("[ 4 ] for Division");
                Console.WriteLine("[ 5 ] for Rest of Division");

                Console.WriteLine();
                Console.WriteLine("What Mathematical Operation do you want to do?");

                int choice = int.Parse(Console.ReadLine());

                Console.Clear();

                if (choice == 1)
                {
                    Console.WriteLine("Enter the first number: ");
                    firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(value: $"The sum between {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the first number: ");
                    firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(value: $"The subtraction between {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    Console.ReadKey();

                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter the first number: ");
                    firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(value: $"The multiplication between {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Enter the first number: ");
                    firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(value: $"The divison between {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    Console.ReadKey();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Enter the first number: ");
                    firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(value: $"The rest of division between {firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Error: We don't have that option!");
                    Console.ReadKey();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: You typed something wrong!");
            }
        }
    }
}
