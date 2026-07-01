
namespace CsharpTask1
 {
    internal class Program
    {
        static void Main(string[] args)
        {
            // Personal Info Card
            string name = "Sara";
            int age = 21;
            double height = 1.65;
            bool isStudent = true;

            Console.WriteLine("Name :" + name + " , Age: "+age +", height:"+height + ", student :" +isStudent);


            //////////////////////////////////////////////////////////////////////////
            ///

            //Rectangle Calculator

            Console.WriteLine("Enter the length :");
            float length = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width :");
            float width = float.Parse(Console.ReadLine());


            float area = length * width;
            float Perimeter = 2 * (length + width);

            Console.WriteLine("AREA:" + area);
            Console.WriteLine("Perimeter:" + Perimeter);

            //////////////////////////////////////////////////////////
            
            //Even or Odd Checker

            Console.WriteLine("enter a whole number :");
            float number = float.Parse(Console.ReadLine());

            float remainder = number % 2;

            if (remainder == 0)
            {
                Console.WriteLine("The number is even");

            }
            else
            {
                Console.WriteLine("The number is odd");
            }










            }
    }
}