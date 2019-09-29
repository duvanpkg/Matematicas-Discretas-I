using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Lab_7._0
{
    class Program
    {
        static void Main(string[] args)
        {
            String finaloutput = "";
            bool flag = true;
            String nstr = " ";
            while (flag == true)
            {
                nstr = Console.ReadLine();
                if (nstr == "")
                {
                    flag = false;
                }
                else
                {
                    int cont = 1;
                    
                    int n = int.Parse(nstr);
                    bool f = true;
                    int suma = ((10 % n) + 1) % n;
                    while (f==true)
                    {
                        if (suma % n == 0)
                        {
                            f = false;
                        }

                        suma = ((suma * 10) + 1) % n;
                        cont++;

                    }
                    finaloutput += cont + "\n";
                }
            }
            Console.WriteLine(finaloutput);
        }
    }
}