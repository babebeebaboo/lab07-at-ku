/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: wordSearch.cs                     
//DATE: 13 Oct 2016                          
/////////////////////////////////////////////
﻿
using System;

namespace lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input sentence: ");
            string inp = Console.ReadLine().ToUpper();
            Console.Write("Input word: ");
            string word = Console.ReadLine().ToUpper();
            int linp=inp.Length;
            int o = 0;
            bool found = false;
            int lword = word.Length;
            for(int i=0;i<linp;i++)
            {
                if(inp[i] == word[o])
                {
                    o++;
                    if (o == lword)
                    {
                        o = 0;
                        found = true;
                    }
                }
            }
            if (found) Console.Write("Found");
            else Console.Write("Not Found");
            //Console.ReadLine();
        }
    }
}
