using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double pi = Math.PI;
            double g = 9.80665;

            double velo;
            double angulo; 

            Console.WriteLine("Entre com a velocidade, em m/s..: ");
            velo = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o ângulo, em graus....: ");
            angulo = double.Parse(Console.ReadLine());

            

        }
    }
}
