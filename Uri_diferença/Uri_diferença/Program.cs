using System;

namespace Uri_diferença
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            /*
            5
6
7
8

DIFERENCA = -26

0
0
7
8

DIFERENCA = -56

5
6
- 7
8

DIFERENCA = 86
            */

            int A, B, C, D, DIFERENCA;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            D = Convert.ToInt32(Console.ReadLine());

            DIFERENCA = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}
