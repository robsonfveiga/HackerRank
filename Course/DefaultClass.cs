﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPlatform.Course
{
    public class DefaultClass
    {
        static void Mainx(String[] args)
        {
            int aux;
            int value = int.Parse(Console.ReadLine());
            List<int> coins = new List<int>();

            coins.Add(10);
            coins.Add(5);
            coins.Add(1);

            int retorno = 0;
            while (value > 0)
            {
                aux = value - coins[0];
                if (aux < 0)
                {
                    coins.RemoveAt(0);
                    continue;
                }
                retorno++;
                value = aux;
            }
            System.Console.WriteLine(retorno);
        }
        
    }
}
