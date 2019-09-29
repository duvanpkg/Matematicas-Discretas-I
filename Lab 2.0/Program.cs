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
            string input = Console.ReadLine();
            int t = int.Parse(input);
            Console.WriteLine(" ");
            string final_output = "";
            for (int i = 1; i < (t + 1); i++)
            {
                string nk = Console.ReadLine();//n y k
                var nksplit = nk.Split(' '); //separar el input entre espacios
                int n = int.Parse(nksplit[0]); //Primer entero del input (n)
                int k = int.Parse(nksplit[1]); //Segundo entero del input (k)

                string n_list_str = Console.ReadLine();
                string[] n_list = n_list_str.Split(new Char[] { ' ' });
                int[] array_n = n_list.Select(int.Parse).ToArray();

                Array.Sort(array_n); // Ordenador del array

                int cont = 0;
                var pairs = new List<string>();

                for (int p = 0; p != n; p++)
                {
                    for (int j = p + 1; j != n; j++)
                    {
                        int p1 = array_n[p];
                        string p_str = p1.ToString();
                        int j1 = array_n[j];
                        string j_str = j1.ToString();
                        pairs.Add(string.Format("{0}{1}{2}", p_str, " ", j_str)); //guarda las parejas como strings con un espacio
                    }
                }

                IEnumerable<string> distinctPairs = pairs.Distinct();

                foreach (var elem in distinctPairs)
                {
                    var elemSplit = elem.Split(' ');
                    //Convierte cada uno de los numeros de la pareja nuevamente a int
                    int elem0 = int.Parse(elemSplit[0]);
                    int elem1 = int.Parse(elemSplit[1]);

                    //comprueba si su suma es divisible entre k
                    int suma = elem0 + elem1;
                    if ((suma % k) == 0)
                    {
                        cont += 1;
                    }
                }
                Console.WriteLine("\n");
                final_output += "Case " + i + ": " + cont + "\n";
            }
            Console.Write(final_output);
        }
    }
}