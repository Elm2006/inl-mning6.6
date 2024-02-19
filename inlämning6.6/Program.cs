using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string x = Console.ReadLine();
        VartAnnatOrd(x);
    }
    static void VartAnnatOrd(string x)
    {
        string[] y = x.Split(' ');
        for (int i = 0; i < y.Length; i++)
        {
            if (i % 2 == 0)
            {
                y[i] = y[i].ToUpper();
                Console.Write(y[i]+" ");
            }
            else
            {
                y[i] = y[i].ToLower();
                Console.Write(y[i] + " ");
            }
        }
        Console.WriteLine();
    }

}
