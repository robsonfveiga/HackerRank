﻿
using AlgorithmsPlatform.Algorithms;
using AlgorithmsPlatform.Algorithms.GraphTheory;
using AlgorithmsPlatform.Algorithms.Implementation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform
{
    class app
    {
        static void Main(String[] args)
        {
            StreamReader input = new StreamReader("input2txt");
            ITestable algorithm = new KthAncestorV3();
            algorithm.run(input);
            Console.ReadLine();

        }
    }
}
