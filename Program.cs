using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.If_Staments_Using_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter number 1");
            int num1 = Console.Read();
            Console.WriteLine("Enter number 2");
            int num2 = Console.Read();

            Console.WriteLine(GetMax(num1,num2));

            //freeze console
            Console.ReadLine();

        }
        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
               Console.WriteLine("The max is ");
                return num1;
            }
            else
            {
                Console.WriteLine("The max is ");
                return num2;
            }

        }
        
            
    }

}
