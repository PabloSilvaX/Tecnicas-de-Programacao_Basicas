using System;

namespace par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, escolha_Par_Impar, num_Computador, soma;
            Console.WriteLine("Digite 0 = Par ou 1 = Impar");
            escolha_Par_Impar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um numero");
                numero = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            num_Computador = rnd.Next(0, 10);
            
            if((numero + num_Computador) % 2 == escolha_Par_Impar)
            {
                Console.WriteLine("Jogo roubado, numero anterior = " + num_Computador);
                //num_Computador++;
                num_Computador += 1;
            }

            Console.WriteLine("Numero do computador" + num_Computador);
            soma = numero + num_Computador;

            if ( soma % 2 == escolha_Par_Impar)
            {
                Console.WriteLine("Voce Ganhou!");
            }
            else
            {
                Console.WriteLine("O computador Ganhou!");
            }
        }
    }
}
