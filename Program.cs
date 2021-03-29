using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int choice = 0;

            Console.WriteLine("---Calculator---");
            Console.WriteLine("----------------");

            Console.WriteLine();
            Console.WriteLine("[ 1 ] for Sum");
            Console.WriteLine("[ 2 ] for Subtraction");
            Console.WriteLine("[ 3 ] for Multiplication");
            Console.WriteLine("[ 4 ] for Division");
            Console.WriteLine("[ 5 ] for Rest of Division");
            Console.WriteLine("[ 6 ] Exit Program");

            Console.WriteLine();
            Console.WriteLine("What Mathematical Operation do you want to do?");
            choice = int.Parse(Console.ReadLine());

            try
            {
                while (choice != 6)
                {
                    Console.Clear();

                    if (choice == 1)
                    {
                        Console.WriteLine("Enter with two numbers in the same line: ");
                        string[] vet = Console.ReadLine().Split(' ');
                        firstNumber = int.Parse(vet[0]);
                        secondNumber = int.Parse(vet[1]);
                        Console.WriteLine($"The sum between {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Enter with two numbers in the same line: ");
                        string[] vet = Console.ReadLine().Split(' ');
                        firstNumber = int.Parse(vet[0]);
                        secondNumber = int.Parse(vet[1]);
                        Console.WriteLine($"The subtraction between {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");

                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Enter with two numbers in the same line: ");
                        string[] vet = Console.ReadLine().Split(' ');
                        firstNumber = int.Parse(vet[0]);
                        secondNumber = int.Parse(vet[1]);
                        Console.WriteLine($"The multiplication between {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Enter with two numbers in the same line: ");
                        string[] vet = Console.ReadLine().Split(' ');
                        firstNumber = int.Parse(vet[0]);
                        secondNumber = int.Parse(vet[1]);
                        Console.WriteLine($"The divison between {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Enter with two numbers in the same line: ");
                        string[] vet = Console.ReadLine().Split(' ');
                        firstNumber = int.Parse(vet[0]);
                        secondNumber = int.Parse(vet[1]);
                        Console.WriteLine($"The rest of division between {firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
                    }
                    else
                    {
                        Console.WriteLine("Error: We don't have that option!");
                    }

                    Console.WriteLine();
                    Console.WriteLine("[ 1 ] for Sum");
                    Console.WriteLine("[ 2 ] for Subtraction");
                    Console.WriteLine("[ 3 ] for Multiplication");
                    Console.WriteLine("[ 4 ] for Division");
                    Console.WriteLine("[ 5 ] for Rest of Division");
                    Console.WriteLine("[ 6 ] Exit Program");
                    Console.WriteLine();

                    Console.WriteLine("Do you want to do any more Mathematical Operation?");
                    choice = int.Parse(Console.ReadLine());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: You typed something wrong!");
            }
        }
    }
}
