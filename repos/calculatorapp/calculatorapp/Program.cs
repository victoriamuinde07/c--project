using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;

            String answer; 

            Console.WriteLine("Calculator setup");
            Console.WriteLine("Please enter your first desired number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("what type of operation would you choose:");
            Console.WriteLine("Choose a for Addition, m for Multiplication, s for subtraction, d for division");

            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 +num2;
            }
            else if(answer == "m")
            {
                result = num1 * num2;
            }
            else if(answer == "s")
            {
                result = num1 - num2;
            }
            else 
            {
                result = num1 / num2;
            }
            Console.ReadKey();
            Console.WriteLine("End result" + result);
            Console.WriteLine("Done");
        }
    }
}
