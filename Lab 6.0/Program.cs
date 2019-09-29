using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string final_output = "";
            List<int> thickness = new List<int>();
            List<int> heights = new List<int>();
            int coins = 1;
            int tables = 1;
            while (coins != 0 && tables != 0)
            {
                string line1 = Console.ReadLine();
                var l1 = line1.Split(' ');
                coins = int.Parse(l1[0]);
                tables = int.Parse(l1[1]);

                for (int c = 0; c < coins; c++)
                {
                    string input1 = Console.ReadLine();
                    thickness.Add(int.Parse(input1));
                }
                for (int t = 0; t < tables; t++)
                {
                    string input2 = Console.ReadLine();
                    heights.Add(int.Parse(input2));
                }


                for (int h = 0; h < tables; h++)
                {
                    int maxHeigth = (heights[h] / thickness.Max()) * thickness.Max(); //la altura maxima que no se pase de la deseada
                    int minHeigth = 0;
                    if (maxHeigth == heights[h])
                    {
                        minHeigth = maxHeigth;
                    }
                    else
                    {
                        minHeigth = ((heights[h] / thickness.Max()) + 1) * thickness.Max();
                    }

                    //mcd entre la moneda mas grande y la mas pequeña
                    int smallestCoin = thickness.Min();
                    int biggestCoin = thickness.Max();
                    int r = 1;
                    while (r != 0)
                    {
                        r = biggestCoin % smallestCoin;
                        biggestCoin = smallestCoin;
                        smallestCoin = r;
                    }

                    int mcd = biggestCoin;

                    bool f = true;
                    while (f == true && maxHeigth >= 0)
                    {
                        int contmax = 0;
                        for (int i = 0; i < coins; i++)
                        {
                            if (maxHeigth % thickness[i] == 0)
                            {
                                contmax += 1;
                            }
                        }
                        if (contmax != coins)
                        {
                            maxHeigth = maxHeigth - mcd;
                        }
                        else
                        {
                            f = false;
                        }
                    }

                    bool d = true;
                    while (d == true && minHeigth >= 0)
                    {
                        int contmin = 0;
                        for (int i = 0; i < coins; i++)
                        {
                            if (minHeigth % thickness[i] == 0)
                            {
                                contmin += 1;
                            }
                        }

                        if (contmin != coins)
                        {
                            minHeigth = minHeigth + mcd;
                        }
                        else
                        {
                            d = false;
                        }

                    }
                    final_output += maxHeigth + " " + minHeigth + "\n";
                }
            }
            Console.WriteLine(final_output);
        }
    }
}