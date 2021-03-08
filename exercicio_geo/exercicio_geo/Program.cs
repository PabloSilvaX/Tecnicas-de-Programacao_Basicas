using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, L, C;

            Console.Write("Escolha o valor de n: "); //coluninhas
            N = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nExemplo 1\n");
            for(C=0; C<N; C++)
            {
                Console.Write("X ");

            }
            Console.Write("\n\nExemplo 2\n");
            for (L = 0; L < N; L++)
            {
               
            for (C = 0; C < N; C++)
                {
                      if(L>= C) 
                    Console.Write("X ");
                      else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }

            
            //  \t tabulação, alinha em tabela
        }
    }
}
