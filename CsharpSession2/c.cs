namespace CsharpSession2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age :");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }
        }
    }
}

