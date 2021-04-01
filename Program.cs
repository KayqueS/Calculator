using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MathematicalOperations sum, sub, multi, div, mod;
            sum = new MathematicalOperations();
            sub = new MathematicalOperations();
            multi = new MathematicalOperations();
            div = new MathematicalOperations();
            mod = new MathematicalOperations();
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
                        sum.A = int.Parse(Console.ReadLine());
                        sum.B = int.Parse(Console.ReadLine());
                        Console.WriteLine($"The sum between {sum.A} + {sum.B} = {sum.Sum()}");
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Enter with two numbers in the same line: ");
                        sub.A = int.Parse(Console.ReadLine());
                        sub.B = int.Parse(Console.ReadLine());
                        Console.WriteLine($"The subtraction between {sub.A} - {sub.B} = {sub.Sub()}");

                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Enter with two numbers in the same line: ");
                        multi.A = int.Parse(Console.ReadLine());
                        multi.B = int.Parse(Console.ReadLine());
                        Console.WriteLine($"The multiplication between {multi.A} * {multi.B} = {multi.Multi()}");
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Enter with two numbers in the same line: ");
                        div.A = int.Parse(Console.ReadLine());
                        div.B = int.Parse(Console.ReadLine());
                        Console.WriteLine($"The divison between {div.A} / {div.B} = {div.Div()}");
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Enter with two numbers in the same line: ");
                        div.A = int.Parse(Console.ReadLine());
                        div.B = int.Parse(Console.ReadLine());
                        Console.WriteLine($"The rest of division between {mod.A} % {mod.B} = {mod.Mod()}");
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
