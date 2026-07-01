
namespace CsharpTask1
 {
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Personal Info Card
            //string name = "Sara";
            //int age = 21;
            //double height = 1.65;
            //bool isStudent = true;

            //Console.WriteLine("Name :" + name + " , Age: "+age +", height:"+height + ", student :" +isStudent);


            ////////////////////////////////////////////////////////////////////////////
            /////

            ////Rectangle Calculator

            //Console.WriteLine("Enter the length :");
            //float length = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the width :");
            //float width = float.Parse(Console.ReadLine());


            //float area = length * width;
            //float Perimeter = 2 * (length + width);

            //Console.WriteLine("AREA:" + area);
            //Console.WriteLine("Perimeter:" + Perimeter);

            ////////////////////////////////////////////////////////////
            
            ////Even or Odd Checker

            //Console.WriteLine("enter a whole number :");
            //float number = float.Parse(Console.ReadLine());

            //float remainder = number % 2;

            //if (remainder == 0)
            //{
            //    Console.WriteLine("The number is even");

            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");


            //}

            ///////////////////////////////////////////////////////////////////////////

            ////voting eligibility

            //Console.WriteLine("enter your age :");
            //int age1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("whether they hold a valid national");
            //string nationalID = Console.ReadLine();
            //bool withNationalID =( nationalID == "yes");

            //if  (age1 >= 18 && withNationalID)
            //{
            //    Console.WriteLine("You are eligible to vote");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to vote");
            //}

            //////////////////////////////////////////////////////////////////////////

            ////Grade Letter Lookup

            //Console.WriteLine("Enter your grade letter :");
            //Console.WriteLine("A");
            //Console.WriteLine("B");
            //Console.WriteLine("C");
            //Console.WriteLine("D");
            //Console.WriteLine("F");

            //Console.WriteLine("please choose your grade letter from the above options :");
            //int option = int.Parse(Console.ReadLine());

            //switch (option)
            //{
            //    case 1:
            //        Console.WriteLine("Excellent");
            //        break;
            //    case 2:
            //        Console.WriteLine("Good");
            //        break;
            //    case 3:
            //        Console.WriteLine("Average");
            //        break;
            //    case 4:
            //        Console.WriteLine("Below Average");
            //        break;
            //    case 5:
            //        Console.WriteLine("Failing");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid option");
            //        break;
            //}
            /////////////////////////////////////////////////////////////////////////
            ///
            // task 6

            Console.WriteLine("Enter the temperature in Celsius :");
            float C = float.Parse(Console.ReadLine());
            float F = (C * 9 / 5) + 32;
            if (C <= 10)
            {
                Console.WriteLine("It's cold");

            }
            else if (C > 10 && F <= 30)
            {
                Console.WriteLine("It's Mild");
            }
            else
            {
                Console.WriteLine("It's hot");
            }
            Console.WriteLine("The temperature in Fahrenheit is :" + F);









        }
    }
}