using System.ComponentModel;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// countdown Timer
            //Console.WriteLine("enter a starting number :");
            //int sN = Convert.ToInt32(Console.ReadLine());

            //for (int i = sN; i >= 1; i--)
            //{
            //    Console.WriteLine(i);

            //}
            ////////////////////////////////////////////////////////////////

            ////sum of numbers from 1 to N
            //Console.WriteLine("enter a positive whole number");
            //int N = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i <= N; i++)
            //{

            //    sum += i;

            //}
            //Console.WriteLine("sum =" + sum);

            ////////////////////////////////////////////////////////////////////

            ////multiplication table 

            //Console.WriteLine("enter a number to get its multiplication table");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(num + " x " + i + " = " + (num * i));
            //}
            ///////////////////////////////////////////////////////////////////////

            //// Password Retry
            //string password = "Spark2026";
            //string userInput = "";
            //while (userInput != password)
            //{
            //    Console.WriteLine("enter your password");
            //    userInput = Console.ReadLine();
            //    if (userInput != password)
            //    {
            //        Console.WriteLine("wrong password, try again");
            //    }
            //    else
            //    {
            //        Console.WriteLine("correct");

            //    }

            //}
            //////////////////////////////////////////////////////////////////

            ////number Guessing Game
            //int pn = 42;
            //int guess;
            //int attempts = 0;
            //do
            //{
            //    Console.WriteLine("enter your guess");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    attempts = pn + 1;

            //} 
            //while (guess != 0);

            //if (guess < pn)
            //{
            //    Console.WriteLine("too low");
            //}
            //else if (guess > pn)
            //{
            //    Console.WriteLine("too high");
            //}
            //else
            //{
            //    Console.WriteLine("correct! you guessed it in " + attempts + " attempts.");

            //}
            ////////////////////////////////////////////////////////////

            //Safe Division Calculator
            Console.WriteLine("enter the frist numper");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < 1; i++)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    double result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                /////////////////////////////////////////////////////////////////////////////////

                //Repeating Menu with Exit Option

                bool exit = false;

                while (exit)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Option 1");
                    Console.WriteLine("2. Option 2");
                    Console.WriteLine("3. Option 3");
                    Console.WriteLine("chose tne one optine ");

                }
                try
                {
                    Console.WriteLine("enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("you chose option 1");
                            break;
                        case 2:
                            Console.WriteLine("you chose option 2");
                            break;
                        case 3:
                            Console.WriteLine("you chose option 3");
                            break;
                        default:
                            Console.WriteLine("invalid choice, please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");

                } 

            }

        }
    }
}