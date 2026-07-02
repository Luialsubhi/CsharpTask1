namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // countdown Timer
           Console.WriteLine("enter a starting number :");
            int  sN = Convert.ToInt32(Console.ReadLine());

            for (int i = sN; i >= 1; i--) 
            {
                Console.WriteLine(i);
                
            }
            //////////////////////////////////////////////////////////////

            //sum of numbers from 1 to N
            Console.WriteLine("enter a positive whole number"); 
            int N = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
               
                sum += i;

            }
            Console.WriteLine("sum ="+ sum);

            //////////////////////////////////////////////////////////////////

            //multiplication table 

            Console.WriteLine("enter a number to get its multiplication table");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
            /////////////////////////////////////////////////////////////////////
            

        }
    }
}
