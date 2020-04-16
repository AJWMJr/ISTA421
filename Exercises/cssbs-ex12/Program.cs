using System;

namespace cssbs_ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Nav();
        }

        private static void Nav()
        {
            int numRight;
            Console.WriteLine("Welcome to the flashcard Game!");
            Console.Write("Which type of math problem would you like to do? (add, subtract, multiply, or divide): ");
            var choice = Console.ReadLine().ToLower();
            Console.Write("how many problems would you like to do? ");
            var numProbs = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (choice == "add")
                numRight = flashAdd(numProbs);
            else if (choice == "subtract")
                numRight = flashSubtract(numProbs);
            else if (choice == "multiply")
                numRight = flashMultiply(numProbs);
            else if (choice == "divide")
                numRight = flashDivide(numProbs);
            else
            {
                Console.WriteLine("invalid input");
                numRight = -1;
            }
            if (numRight == -1)
                Environment.Exit(0);
            var score = ((double)numRight / numProbs) * 100;
            score = (int)score;
            Console.WriteLine($"Your score is {score}%");
        }

        private static int flashDivide(int numProbs)
        {
            int numRight = 0;
            Console.WriteLine("division answers should be acurate out to the second decimal place");
            if (numProbs <= 0)
            {
                Console.WriteLine("If you don't want to do any problems then that's all you had to say");
                return -1;
            }
            do
            {
                var rando = new Random();
                double one = rando.Next(1, 100);
                double two = rando.Next(1, 100);
                Console.Write($"{one} / {two} = ");
                double answer = double.Parse(Console.ReadLine());
                if (Math.Abs(answer - (one / two)) < .009)
                {
                    Console.WriteLine("Correct!");
                    numRight++;
                }
                else
                    Console.WriteLine("sorry, that is not correct.");
                numProbs--;
            }
            while (numProbs > 0);
            return numRight;
        }

        private static int flashMultiply(int numProbs)
        {
            int numRight = 0;
            if (numProbs <= 0)
            {
                Console.WriteLine("If you don't want to do any problems then that's all you had to say");
                return -1;
            }
            do
            {
                var rando = new Random();
                int one = rando.Next(1, 100);
                int two = rando.Next(1, 100);
                Console.Write($"{one} * {two} = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == one * two)
                {
                    Console.WriteLine("Correct!");
                    numRight++;
                }
                else
                    Console.WriteLine("sorry, that is not correct.");
                numProbs--;
            }
            while (numProbs > 0);
            return numRight;
        }

        private static int flashSubtract(int numProbs)
        {
            int numRight = 0;
            if (numProbs <= 0)
            {
                Console.WriteLine("If you don't want to do any problems then that's all you had to say");
                return -1;
            }
            do
            {
                var rando = new Random();
                int one = rando.Next(50, 100);
                int two = rando.Next(1, 50);
                Console.Write($"{one} - {two} = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == one - two)
                {
                    Console.WriteLine("Correct!");
                    numRight++;
                }
                else
                    Console.WriteLine("sorry, that is not correct.");
                numProbs--;
            }
            while (numProbs > 0);
            return numRight;
        }

        private static int flashAdd(int numProbs)
        {
            int numRight = 0;
            if (numProbs <= 0)
            {
                Console.WriteLine("If you don't want to do any problems then that's all you had to say");
                return -1;
            }
            do
            {
                var rando = new Random();
                int one = rando.Next(1, 100);
                int two = rando.Next(1, 100);
                Console.Write($"{one} + {two} = ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == one + two)
                {
                    Console.WriteLine("Correct!");
                    numRight++;
                }
                else
                    Console.WriteLine("sorry, that is not correct.");
                numProbs--;
            }
            while (numProbs > 0);
            return numRight;
        }
    }
}
