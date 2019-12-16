using System;

namespace calculator_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double first;
            double second;
            double third;
            string symbol;
            Console.WriteLine("Enter First Number:");
            first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select an operator + for addition, - for subtraction, * for multiplication, / for division.");
            symbol = Console.ReadLine();

            if (symbol == "-")
            {
                third = first - second;
                Console.WriteLine("{0} {1} {2} = {3}.", first, symbol, second, third);
                Console.ReadLine();
            }
            else if (symbol == "+")
            {
                third = first + second;
                Console.WriteLine("{0} {1} {2} = {3}.", first, symbol, second, third);
                Console.ReadLine();
            }
            else if (symbol == "*")
            {
                third = first * second;
                Console.WriteLine("{0} {1} {2} = {3}.", first, symbol, second, third);
                Console.ReadLine();
            }
            else if (symbol == "/")
            {
                third = first / second;
                Console.WriteLine("{0} {1} {2} = {3}", first, symbol, second, third);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }
        }
    }
}