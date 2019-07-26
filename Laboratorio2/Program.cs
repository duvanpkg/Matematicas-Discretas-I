using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("How many test cases do you wanna do?");
            string input = Console.ReadLine();
            int t = int.Parse(input);

            for (int i = 1; i < (t+1); i++)
            {
                Console.WriteLine("\nThis is the test case number: " + i);
                Console.WriteLine("\nWrite 2 numbers n and k separated by a comma(,) \nin which n is the number of integers in the list and k is any integer\n ");
                var nk = Console.ReadLine();
                var nksplit = nk.Split(','); //separar el input entre comas
                var n = int.Parse(nksplit[0]); //Primer entero del input (n) 
                var k = int.Parse(nksplit[1]); //Segundo entero del input (k)

                Console.WriteLine("\nOk, now write a number of n digits (remember you said the value of n)");
                var n_list = Console.ReadLine();
            }

        }
    }
}
