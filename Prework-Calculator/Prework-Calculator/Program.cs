using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int userSelection = 0;
            while(userSelection != 5)
            {
                float num1 = 0;
                float num2 = 0;

                Console.Clear();
                Console.WriteLine("Calculator!");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Quit");
                Console.Write("Make a selection: ");
                userSelection = int.Parse(Console.ReadLine());

                if(userSelection != 5)
                {
                    Console.Write("Enter the first number: ");
                    num1 = float.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = float.Parse(Console.ReadLine());
                }

                switch (userSelection)
                {
                    case 1:
                        displayResult(num1, num2, "+", Add(num1, num2));
                        break;
                    case 2:
                        displayResult(num1, num2, "-", Subtract(num1, num2));
                        break;
                    case 3:
                        displayResult(num1, num2, "x", Multiply(num1, num2));
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            }
        }

        static void displayResult(float num1, float num2, string calcOperator, float result)
        {
            Console.WriteLine("{0} {1} {2} = {3}", num1, calcOperator, num2, result);
            Console.ReadLine();
        }

        static float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

       

    }
}
