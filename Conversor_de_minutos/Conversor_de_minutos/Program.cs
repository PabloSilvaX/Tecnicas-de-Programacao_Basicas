using System;
using System.Threading;

namespace Conversor_de_minutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int ciclos=1, total, min=0, seg=0;

            Console.Write("Escolha o tempo em minutos: ");
            total = Convert.ToInt32(Console.ReadLine());

            min = total;

            string fmt = "00"; //to string servido pra dar o alinhamento usando 2 caracteres "00"

            total = total * 60;
            Console.Clear();

            while (ciclos <= total)
            {
                Console.WriteLine("{0}:{1}\n", min.ToString(fmt), seg.ToString(fmt));
                seg--;

                if(seg <= 0)
                {
                    seg = 60;
                    min--;
                }

                Thread.Sleep(1000); //da o delay a cada mensagem (esta em milisegundos)
                Console.Clear(); //limpa 
            }
        }
    }
}
