using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commit_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hey i am:" + myAge, "i love it here");
            if (myAge > 18)
            {
                Console.WriteLine("You are a grown up,Victor");
            }
            else if(myAge <=20  || myAge >=25){
                Console.WriteLine("Victor remain in school life only needs grown up personas only," + myAge, "such ages");
            }
            else
            {
                Console.WriteLine("You are underage");
            }
        }
    }
}
