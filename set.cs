/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: set.cs                            
//DATE: 13 Oct 2016                          
/////////////////////////////////////////////
﻿
using System;

namespace lab07
{
    class Program
    {
    	static int Main()
        {
            Console.Write("Input set1: ");
            string inp = Console.ReadLine();
            string[] input = inp.Split(' ');
            int[] set1 = new int[input.Length];
            for (int i = 0; i < input.Length; i++) set1[i] = int.Parse(input[i]);
            
            Array.Sort(set1);
            //for (int i = 0; i < set1.Length; i++) Console.WriteLine(set1[i]);

            Console.Write("Input set2: ");
            inp = Console.ReadLine();
            string[] inputt = inp.Split(' ');
            int[] set2 = new int[inputt.Length];
            for (int i = 0; i < inputt.Length; i++) set2[i] = int.Parse(inputt[i]);
            bool error1 = false;
            bool error2 = false;
            
            for (int i = 0; i < set1.Length; i++)
            {
                if (set1[i] > 100) { /*Console.WriteLine("<{0}>", set1[i]);*/ error1 = true; }
                /*else Console.WriteLine("{0}", set1[i]);*/
            }
            for (int i = 0; i < set2.Length; i++)
            {
                if (set2[i] > 100) { /*Console.WriteLine("<{0}>", set2[i]);*/ error2 = true; }
                /*else Console.WriteLine("{0}", set2[i]);*/
            }
            if (error1)
            {
					Console.Write("Input Error: ");
                for (int i = 0; i < set1.Length; i++)
                {
                    if (set1[i] > 100) { Console.Write("<{0}> ", set1[i]);}
                    else Console.Write("{0} ", set1[i]);
                }
					 Console.WriteLine();
            }
            if (error2)
            {
					Console.Write("Input Error: ");
                for (int i = 0; i < set2.Length; i++)
                {
                    if (set2[i] > 100) { Console.Write("<{0}> ", set2[i]); }
                    else Console.Write("{0} ", set2[i]);
                }
					 Console.WriteLine();
            }
            if (error1) return 0;
            if (error2) return 0;
            Array.Sort(set2);
            //for (int i = 0; i < set2.Length; i++) Console.WriteLine(set2[i]);
            bool printed = false;
            Console.WriteLine();
            Console.Write("A Intersect B: ");
            for (int i = 0; i < set1.Length; i++) for (int j = 0; j < set2.Length; j++) if (set1[i] == set2[j])
                    {
                        Console.Write("{0} ", set1[i]);
                        printed = true;
                    }
            if (!printed) Console.Write("empty set");
            Console.WriteLine();
            Console.Write("A minus B: ");
            printed = false;
            for (int i = 0; i < set1.Length; i++)
            {
                bool found = false;
                for(int j = 0; j < set2.Length; j++)
                {
                    if (set1[i] == set2[j]) found = true;
                }
                if (!found) { Console.Write("{0} ", set1[i]); printed = true; }
            }
            if (!printed) Console.Write("empty set");
            printed = false;
            Console.WriteLine();
            Console.Write("B minus A: ");
            for (int i = 0; i < set2.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < set1.Length; j++)
                {
                    if (set2[i] == set1[j]) found = true;
                }
                if (!found) { Console.Write("{0} ", set2[i]); printed = true; }
            }
            if (!printed) Console.Write("empty set");
            Console.WriteLine();

            Console.Write("A union B: ");
            int o = 0;
            int same = 0;
            for(int i = 0; i < set1.Length; i++)
            {
                for(int j = 0; j < set2.Length; j++)
                {
                    if (set1[i] == set2[j]) same++;
                }
            }
            int[] setu = new int[set1.Length + set2.Length - same];
            for(int i = 0; i < set1.Length; i++)setu[o++] = set1[i];

            for (int i = 0; i < set2.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < set1.Length; j++)
                {
                    if (set2[i] == set1[j]) found = true;
                }
                if (!found)
                {
                    setu[o++] = set2[i];
                }
            }
            Array.Sort(setu);
            for (int i = 0; i < setu.Length; i++) Console.Write("{0} ",setu[i]);
            return 0;

        }
    }
}
