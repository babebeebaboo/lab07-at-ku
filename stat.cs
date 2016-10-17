/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: stat.cs                           
//DATE: 13 Oct 2016                          
/////////////////////////////////////////////
﻿
using System;

namespace lab07
{
    class Program
    {
    	static void Main()
        {
            Console.Write("Nb. of input : ");
            int nb = int.Parse(Console.ReadLine());
            Console.Write("Input number : ");
            string inp = Console.ReadLine();
            string[] input = inp.Split(' ');
            double sum = 0;
            int[] intinput = new int[nb];
            for (int i = 0; i < nb; i++)intinput[i]=int.Parse(input[i]);
            Array.Sort(intinput);
            //for (int i = 0; i < nb; i++) Console.WriteLine(intinput[i]);
            Console.WriteLine("Max = {0}",intinput[nb-1]);
            Console.WriteLine("Min = {0}",intinput[0]);
            for (int i = 0; i < nb; i++) sum += intinput[i];
            Console.WriteLine("Mean = {0:f2}", sum/nb);
            int o = 0;
            int modemax = 0;
            Console.Write("Mode = ");
             
            for(int i = 1; i < nb; i++)
            {
                int old = intinput[i - 1];
                if (intinput[i] == old)
                {
                    o++;
                    if (o > modemax) modemax = o;
                }
                else o = 0;
            }
            bool printed = false;
            for(int i = 1; i < nb; i++)
            {
                int old = intinput[i - 1];
                if (intinput[i] == old)
                {
                    o++;

                    if (o == modemax)
                    {
                        if (printed) Console.Write(",");
                        Console.Write(intinput[i]);
                    }
                    printed = true;
                }
                else o = 0;
            }
            Console.WriteLine();
            if (nb % 2 == 1)
            {
                Console.WriteLine("Median = {0:f2}", intinput[(nb / 2)]);
            }
            else
            {
                Console.WriteLine("Median = {0:f2}", (double)(intinput[(nb / 2)-1] + intinput[(nb / 2)])/2.0 );
            }
            //Console.ReadLine();
        }
    }
}
