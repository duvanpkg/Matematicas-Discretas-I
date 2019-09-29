using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int test = int.Parse(input);
            string final_output = "";
            for (int t = 0; t < test; t++)
            {
                string nstr = Console.ReadLine();
                double n = int.Parse(nstr) + 1;
                bool condWhile = true;
                while (condWhile == true)
                {
                    int divN = 0;

                    while (divN < 1)
                    {
                        for (int i = 2; i < Math.Ceiling(Math.Sqrt(n)); i++) //Comprobar si n es primo
                        {
                            if (n % i == 0)
                            {
                                divN += 1;
                            }
                        }
                        if (divN < 1)
                        {
                            n = n + 1; //Si es primo, redefine n, sumandole 1
                        }
                    }

                    //Si no es primo, sigue.

                    //calcula la suma de los digitos del numero
                    string nstr2 = n.ToString();
                    int sumaDigitos = 0;
                    for (int x = 0; x < (nstr2).Length; x++)
                    {
                        int dig = int.Parse(nstr2[x].ToString());
                        sumaDigitos += dig;
                    }

                    //calcula la suma de factores primos del numero
                    string factores = "";
                    double p = 2;
                    double ntemp = n;

                    while (ntemp >= p * p)
                    {
                        if (ntemp % p == 0)
                        {
                            factores += p;
                            ntemp = ntemp / p;
                        }
                        else
                        {
                            p = p + 1;
                        }
                    }
                    factores += ntemp;

                    int sumaFactores = 0;
                    for (int y = 0; y < (factores).Length; y++)
                    {
                        int fact = int.Parse(factores[y].ToString());
                        sumaFactores += fact;
                    }

                    if (sumaDigitos == sumaFactores)
                    {
                        final_output += n + "\n";
                        condWhile = false;
                    }
                    else
                    {
                        n = n + 1;
                        condWhile = true;
                    }
                }
            }
            Console.WriteLine(final_output);

        }
    }
}