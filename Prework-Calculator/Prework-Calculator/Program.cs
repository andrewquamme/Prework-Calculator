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
                float result = 0;
                string calcOperator = "";

                Console.Clear();
                Console.WriteLine("Calculator!");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Quit");
                userSelection = int.Parse(Console.ReadLine());

                num1 = float.Parse(Console.ReadLine());
                num2 = float.Parse(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        result = Add(num1, num2);
                        calcOperator = "+";
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }

                Console.WriteLine($"{0} {1} {2} = {3}\nPress any key to continue",num1, calcOperator, num2, result);
                Console.ReadLine();
            }
            
        }

        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }
    }
}
