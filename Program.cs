using System;

namespace Loops_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxNum();
        }

        /// <summary>Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console</summary>
        public static void CountNumbersDivisibleBy3(int number)
        {
            var count = 0;

            for (var i = 1; i < number; i++)
            {
                if (i % 3 == 0)
                {
                    ++count;
                }
            }
            Console.WriteLine($"There are {count} numbers divisible by 3 between 1 and {number}");
        }

        /// <summary>Write a program to continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console</summary>

        public static void SumUserInput()
        {
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or \"ok\" to exit");
                var userInput = Console.ReadLine();

                if(userInput.ToLower() == "ok")
                {
                    break;
                }

                sum += Convert.ToInt32(userInput);
            }
            Console.WriteLine($"The sum of all numbers entered is {sum}");
        }

        /// <summary>Write a program to ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display the result as 5! = 120</summary>

        public static void Factorial(int num)
        {
            var factorial = 1;

            for (var i = num; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"{num}! = {factorial}");
        }

        /// <summary>Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display "You won"; otherwise display "You lost".</summary>

        public static void GuessRandomNumber()
        {
            // Generate secret number
            var secretNumber = new Random().Next(1, 10);
            Console.WriteLine(secretNumber);
            var chances = 4;

            while (chances > 0)
            {
                // Ask for user input
                Console.WriteLine("Guess a number between 1 and 10");
                var userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == secretNumber)
                {
                    Console.WriteLine("You won");
                    break;
                } else
                {
                    chances--;
                    if (chances > 0)
                    {
                        Console.WriteLine($"Try again, you have {chances} chances left");
                        continue;
                    }
                    Console.WriteLine("You lost");
                }
            }

        }

        /// <summary>Write a program to ask the user enter a series of numbers separated by commas. Find the maximum of the numbers and display it on the console. For example, if the user enter enters "5, 1, 6, 4", the program should display 6.</summary>

        public static void MaxNum()
        {
            // Ask the user to enter comma separated numbers
            Console.WriteLine("Enter a series of number separated by comma:");
            var userSeries = Console.ReadLine();

            // convert userSeries to an array of strings
            var numbers = userSeries.Split(",");

            // set an initial max num to any index
            var maxNum = Convert.ToInt32(numbers[0]);

            // loop through the array and compare each number against maxNum

            for (var i = 0; i < numbers.Length; i++)
            {
                var number = Convert.ToInt32(numbers[i]);

                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
            Console.WriteLine($"The max number is {maxNum}");
        }
    }

}
