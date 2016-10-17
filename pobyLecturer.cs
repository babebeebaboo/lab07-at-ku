/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: pobyLecturer.cs                   
//DATE: 13 Oct 2016                          
/////////////////////////////////////////////
using System;

namespace lab07
{
    class Program
    {
    	static int fac(int i)
    	{
    		if (i <= 1)return 1;
    		return (i * fac(i - 1));
    	}
        static void Main(string[] args)
        {
            double money=0;
            int[] check = new int[200];
            int inp;
            Console.Write("Poby's script: ");
            while(true)
            {
                inp = Console.Read();
               if(inp == '\n')break;
               else check[inp]++;
            }
            for(int i=65;i<=90;i++)
            {
                if( check[i] >= 4 )
                {
                    money+= (check[i]/4)*5000 ;
                    check[i] -= check[i]/4*4;
                }
                if(check[i]>0)
                {
                    int y=check[i];
                    for(int j=1;j<=y;j++)
                    {
                        money += fac( ( (j%13)+1 ) ) / (100.0-j);
                    }
                    check[i]=0;
                }
            }
            for(int i='a';i<='z';i++)
            {
                if( check[i] >= 8 )
                {
                    money+= (check[i]/8)*7653 ;
                    check[i] -= check[i]/8*8;
                }
                if(check[i]>0)
                {
                    int y=check[i];
                    for(int j=1;j<=y;j++)
                    {
                        money += fac( ( (j%13)+1 ) ) / (100.0-j);
                    }
                    check[i]=0;
                }
            }
            for(int i='0';i<='9';i++)
            {
                if( check[i] >= 9 )
                {
                    money+= (check[i]/9)*1234 ;
                    check[i] -= check[i]/9*9;
                }
                if(check[i]>0)
                {
                    int y=check[i];
                    for(int j=1;j<=y;j++)
                    {
                        money += fac( ( (j%13)+1 ) ) / (100.0-j);
                    }
                    check[i]=0;
                }
            }
           	for(int i=32;i<=64;i++)
            {
                if( check[i] >= 2 )
                {
                    money+= (check[i]/2)*9753 ;
                    check[i] -= check[i]/2*2;
                }
                if(check[i]>0)
                {
                    int y=check[i];
                    for(int j=1;j<=y;j++)
                    {
                        money += fac( ( (j%13)+1 ) ) / (100.0-j);
                    }
                    check[i]=0;
                }
            }
            Console.Write("Cost: {0:f2} Rukapi",money);
        }
    }
}
