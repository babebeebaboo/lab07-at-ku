/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: cuteCube.cs                       
//DATE: 13 Oct 2016                          
/////////////////////////////////////////////
using System;
namespace lab07{
    class Program{
        static void Main()
        {
            Console.Write("N: ");
            int n;
            string nn = Console.ReadLine();
            while (true)
            {
                if (Int32.TryParse(nn, out n)) break;
                else
                {
                    Console.Write("N: ");
                    nn = Console.ReadLine();
                }
            }
            int ntimn = n * n, pat;
            Console.Write("PATTERN: ");
            nn = Console.ReadLine();
            while (true)
            {
                if (Int32.TryParse(nn, out pat)) break;
                else
                {
                    Console.Write("PATTERN: ");
                    nn = Console.ReadLine();
                }
            }
            if (pat == 1)
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++) Console.Write("{0:00} ", j + 1 + (i * n));
                    Console.WriteLine();
                }
            if (pat == 2)
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++) Console.Write("{0:00} ", i + 1 + (j * n));
                    Console.WriteLine();
                }
            int odd = 1,even = 2;
            if (pat == 3)
            {
                if (n % 2 == 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (i % 2 == 1)
                            for (int j = 1; j <= n; j++)
                            {
                                Console.Write("{0:00} ", odd);
                                odd += 2;
                            }
                        else
                            for (int j = 1; j <= n; j++)
                            {
                                Console.Write("{0:00} ", even);
                                even += 2;
                            }
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int i = 1; i <= n - 1; i++)
                    {
                        if (i % 2 == 1)
                            for (int j = 1; j <= n; j++)
                            {
                                Console.Write("{0:00} ", odd);
                                odd += 2;
                            }
                        else
                            for (int j = 1; j <= n; j++)
                            {
                                Console.Write("{0:00} ", even);
                                even += 2;
                            }
                        Console.WriteLine();
                    }
                    for (int i = 1; i <= n; i++)
                    {
                        if (i % 2 == 1)
                        {
                            Console.Write("{0:00} ", odd);
                            odd += 2;
                        }
                        else
                        {
                            Console.Write("{0:00} ", even);
                            even += 2;
                        }
                    }
                }
            }
            if (pat == 4)
                for (int i = n - 1; i >= 0; i--)
                {
                    for (int j = 0; j < n; j++) Console.Write("{0:00} ", j + 1 + (i * n));
                    Console.WriteLine();
                }
        }
    }
}
