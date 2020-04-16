using System;

namespace cssbs_Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Nav();
        }
        public static void Nav()
        {
            int input, baseInt, result;
            while ( 1== 1)
            {
                l1: 
                Console.Write("Please enter the integer to convert(-1 will close the application): ");
                input = Parse(Console.ReadLine());
                if (input == -1)
                    Environment.Exit(0);
                if (input == -2)
                {
                    Console.Write("Please enter a valid integer");
                    Console.ReadLine();
                    goto l1;
                }
                Console.Write("Please enter the base to convert from (2, 8, 10): ");
                baseInt = Parse(Console.ReadLine());
                if (baseInt == 2)
                {
                    result = input.Decimal(baseInt);
                    Console.WriteLine($"The decimal is {result}");
                    result = input.Octal(baseInt);
                    Console.WriteLine($"The Octal is {result}");
                }
                else if (baseInt == 8)
                {
                    result = input.Decimal(baseInt);
                    Console.WriteLine($"The decimal is {result}");
                    result = input.Binary(baseInt);
                    Console.WriteLine($"The Binary is {result}");
                }
                else if (baseInt == 10)
                {
                    result = input.Binary(baseInt);
                    Console.WriteLine($"The binary is {result}");
                    result = input.Octal(baseInt);
                    Console.WriteLine($"The Octal is {result}");
                }
                else Console.WriteLine("Please choose a valid base");
            }
        }
        public static int Parse(string s)
        {
            int num;
            try
            {
                num = int.Parse(s);
                return num;
            }
            catch (Exception ex)
            {
                return -2;
            }
        }
    }
}
