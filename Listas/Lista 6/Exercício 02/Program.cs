﻿using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
       const int LIMITE_NOMES = 10;
       
       string[] nomes = new string[LIMITE_NOMES];

       for(int i = 0; i < nomes.Length; i++)
       {
        nomes[i] = Console.ReadLine();
       }

       System.Console.WriteLine();

       for(int i = nomes.Length -1; i >= 0; i--)
       {
        if(i % 2 == 0)
        {
            System.Console.WriteLine(nomes[i]);
        }
       }
    }
}