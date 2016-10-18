﻿/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: methionine.cs                     
//DATE: 14 Oct 2016                          
/////////////////////////////////////////////
using System;
namespace lab07
{
    class Program
    {
        static void Main()
        {
            Console.Write("number of people: ");
            int numberPerson = int.Parse(Console.ReadLine());
            Console.Write("quantity of DNA per 1 person: ");
            int numberDNAPerPerson = int.Parse(Console.ReadLine());
            Console.Write("DNA(5'->3') of people: ");
            string[] DNA = new string[numberPerson];
            string[] RNA = new string[numberPerson];
            string[] ReverseDNA = new string[numberPerson];
            int iii = 0, ooo = 0;
            while (iii < numberPerson * numberDNAPerPerson)
            {
                char input = (char)(Console.Read());
                iii++;
                DNA[ooo] = DNA[ooo] + input;
                if (iii % numberDNAPerPerson == 0) ooo++;
            }
            for (int i = 0; i < numberPerson; i++) DNA[i] = DNA[i].ToUpper();
            for (int i = 0; i < numberPerson; i++)
                for (int j = numberDNAPerPerson - 1; j >= 0; j--)
                    ReverseDNA[i] = ReverseDNA[i] + DNA[i][j];
            Console.WriteLine("-- DNA of people --\n3'->5'");
            for (int i = 0; i < numberPerson; i++) Console.WriteLine("({0})", ReverseDNA[i]);
            for (int i = 0; i < numberPerson; i++)
            {
                for (int j = 0; j < numberDNAPerPerson; j++)
                {
                    if (ReverseDNA[i][j] == 'A') RNA[i] = RNA[i] + 'U';
                    else if (ReverseDNA[i][j] == 'T') RNA[i] = RNA[i] + 'A';
                    else if (ReverseDNA[i][j] == 'C') RNA[i] = RNA[i] + 'G';
                    else if (ReverseDNA[i][j] == 'G') RNA[i] = RNA[i] + 'C';
                }
            }
            Console.WriteLine("-- RNA of people --\n3'->5'");
            for (int i = 0; i < numberPerson; i++) Console.WriteLine("({0})", RNA[i]);
            Console.WriteLine("-- Quantity of Met --");
            int[] QOM = new int[numberPerson];
            for (int i = 0; i < numberPerson; i++)
            {
                bool pause = false;
                for (int j = 2; j < numberDNAPerPerson; j++)
                {
                    string RNA_3 = Convert.ToString(RNA[i][j - 2]) + Convert.ToString(RNA[i][j - 1]) + Convert.ToString(RNA[i][j]);
                    if (RNA_3 == "AUG")
                    {
                        if (pause) pause = false;
                        else QOM[i]++;
                        j += 2;
                    }
                    else if (RNA_3 == "UAA")
                    {
                        pause = true;
                        j += 2;
                    }
                    else if (RNA_3 == "UGA")
                    {
                        pause = true;
                        j += 2;
                    }
                    else if (RNA_3 == "UAG")
                    {
                        pause = true;
                        j += 2;
                    }
                }
            }
            int[] numberofMET = new int[1000001];
            for (int i = 0; i < numberPerson; i++)
            {
                Console.WriteLine("Person{1} : {0} Met", QOM[i], i + 1);
                if (QOM[i] > 0) numberofMET[QOM[i]]++;
            }
            double NCR = 0;
            for(int i = 0; i < 1000001; i++) if (numberofMET[i] > 0) NCR += ncr(numberofMET[i], 2);
            if (NCR == 0) Console.WriteLine("Have no Good Couple");
            else Console.WriteLine("Have {0} Good Couple", NCR );
        }
        static double ncr(int n, int r)
        {
            return fac(n) / (fac(n - r) * fac(r));
        }
        static int fac(int n)
        {
            if (n < 2) return 1;
            else return n * fac(n - 1);
        }
    }
}