using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            string input = Console.ReadLine();
            int a = int.Parse(input);
            /*a es el numero que ingresa el usuario,
             *es decir la posición en la sucesión*/
            int integer = a - 1;

            List<int> penta = new List<int>();
            List<int> fibo = new List<int>() { 0, 1 };

            for (int n = 1; n < (a + 1); n++)
            {
                int pn = (n * ((3 * n) - 1)) / 2;
                penta.Add(pn);
            }

            for (int y = 1; y < a - 1; y++) //a-1 porque ya hay dos elementos iniciales en la lista fibo, y necesitamos el numero de elemntos que sean ingresados en a mas el 1 del for
            {
                var fn = (fibo[fibo.Count - 1]) + (fibo[fibo.Count - 2]);
                fibo.Add(fn);
            }

            int p_acum = 0;
            foreach (int p in penta)
            {
                p_acum += p; //550
            }

            int f_acum = 0;
            foreach (int f in fibo)
            {
                f_acum += f; //88
            }

            int product = p_acum * f_acum;
            Console.WriteLine(product);
        }
    }
}