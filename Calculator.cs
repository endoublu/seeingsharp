using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int condition = 0;
            int trigger = 0;
            String operation = "PlaceHolder";
            
            while (condition != 7)
            {
                while (trigger == 0)
                {
                    Console.WriteLine("Enter Operation: (+,-,*,/)");
                    operation = Console.ReadLine();
                    if (operation != "+" || operation == "-" || operation == "*" || operation == "/")
                    {
                        Console.WriteLine("That is not a valid operation.");
                    }
                    else
                    {
                        trigger += 1;
                    }
                }

                Console.WriteLine("What numbers would you like to " + operation + " by?");

                String num1 = Console.ReadLine();
                String num2 = Console.ReadLine();

                int numm1 = Convert.ToInt32(num1);
                int numm2 = Convert.ToInt32(num2);

                switch (operation)
                {
                    case "*":
                        Console.WriteLine("Your number is: " + (numm1 * numm2));
                        break;
                    case "+":
                        Console.WriteLine("Your number is: " + (numm1 + numm2));
                        break;
                    case "-":
                        Console.WriteLine("Your number is: " + (numm1 - numm2));
                        break;
                    case "/":
                        Console.WriteLine("Your number is: " + (numm1 / numm2));
                        break;
                }
                Console.WriteLine("Would you like to use the calculator again? Y/N");
                String yen = Console.ReadLine();
                if (yen == "N")
                {
                    condition = 7;
                }
            }
        }
    }
}
