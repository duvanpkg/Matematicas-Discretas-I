using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3y4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int t = int.Parse(input);

            string final_output = "";

            for (int i = 1; i < t + 1; i++)
            {
                string x_string = Console.ReadLine();
                int x = int.Parse(x_string);

                List<int> residuos = new List<int>();
                List<int> residuosINV = new List<int>();

                if (x != 0)
                {
                    while (x != 0)
                    {
                        int r = x % (-2);
                        if (r < 0)
                        {
                            r = r * -1;
                            if (x < 0)
                            {
                                x -= 1;
                            }
                            if (x > 0)
                            {
                                x += 1;
                            }
                        }
                        residuos.Add(r);
                        x = x / (-2);
                    }

                    for (int g = residuos.Count - 1; g >= 0; g--) //Para voltear la lista
                    {
                        residuosINV.Add(residuos[g]);
                    }

                    string final_number = string.Join("", residuosINV.ToArray());

                    final_output += "Case #" + i + ": " + final_number + "\n";

                }
                else
                {
                    final_output += "Case #" + i + ": 0" + "\n";
                }
            }
            Console.WriteLine(final_output);
        }
    }
}