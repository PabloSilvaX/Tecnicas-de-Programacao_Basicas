using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, fim, linhas, y;
            
            Console.Write("Escolha até que numero sera multiplicado: ");
            fim = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escolha quantidade de tabuada por linha: ");
            linhas = Convert.ToInt32(Console.ReadLine());

            for (n = 1; n <= 10; n+=linhas) //repetição
            {
                Console.Write("\n--- tabuada {0} a {1} ---\n", n, n-1+linhas);
                for (x = 1; x <= fim; x++)
                {
                    for (y = 0; y < linhas; y++)
                    {
                        Console.Write("{0} x {1} = {2}\t  ", n + y, x, (n + y) * x);
                    }
                    Console.Write("\n");
                }
            }
            //  \t tabulação, alinha em tabela
        }
    }
}
