﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    { 
        static void Main(string[] args)
        {
            int idade = 37;
            Console.WriteLine(idade);
            idade = 10;
            Console.WriteLine(idade);
            idade = 10 + 5;
            Console.WriteLine(idade);
            idade = 10 + 5 * 2;
            Console.WriteLine(idade);
            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é {0}",idade);
            Console.ReadKey();
        }
    }
}
