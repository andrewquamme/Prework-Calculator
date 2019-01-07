using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main flow control
            int userSelection = 0;
            while(userSelection != 5)
            {
                //Keep displaying the menu after each calculation until user exits
                float num1 = 0;
                float num2 = 0;

                userSelection = ShowMenu();

                if(userSelection != 5)
                {
                    //Get two numbers from the user
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
                        if(num2 == 0)
                        {
                            //Handle division by zero
                            Console.WriteLine("Cannot divide by zero!");
                            Console.Write("Press any key to continue");
                            Console.ReadLine();
                        } else
                        {
                            displayResult(num1, num2, "/", Divide(num1, num2));
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        static int ShowMenu()
        {
            //Clear the screen, show the menu, and get user input for option selection
            Console.Clear();
            Console.WriteLine("Calculator!");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Quit");
            Console.Write("Make a selection: ");
            return int.Parse(Console.ReadLine());
        }

        static void displayResult(float num1, float num2, string calcOperator, float result)
        {
            //Take in the two numbers entered by the user, the operator used, and the result
            //and display them in a calulator-like way (2 + 2 = 4)
            Console.WriteLine("{0} {1} {2} = {3}", num1, calcOperator, num2, result);
            Console.ReadLine();
        }

        static float Add(float num1, float num2)
        {
            // Takes two numbers and returns addition of the two
            return num1 + num2;
        }

        static float Subtract(float num1, float num2)
        {
            // Takes two numbers and returns subtraction of the two
            return num1 - num2;
        }

        static float Multiply(float num1, float num2)
        {
            // Takes two numbers and returns multiplication of the two
            return num1 * num2;
        }

        static float Divide(float num1, float num2)
        {
            // Takes two numbers and returns division of the two
            return num1 / num2;
        }
    }
}
