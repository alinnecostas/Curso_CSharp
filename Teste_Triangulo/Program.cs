using System;

namespace TesteTriangulo
{
    internal class Program
    {
        /* static void Main(string[] args)
         {
             int ladoA, ladoB, ladoC;

             Console.Write("Digite o valor do lado A: ");
             ladoA = Convert.ToInt32(Console.ReadLine());

             Console.Write("Digite o valor do lado B: ");
             ladoB = Convert.ToInt32(Console.ReadLine());

             Console.Write("Digite o valor do lado C: ");
             ladoC = Convert.ToInt32(Console.ReadLine());

             if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
             {
                 Console.WriteLine("Os valores informados formam um triangulo.");
             }
             else
             {
                 Console.WriteLine("Os valores informados não formam um triangulo.");
             }*/

        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.Write("Digite o valor do lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("Os valores informados formam um triangulo.");
                
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("Ele é um triangulo equilátero.");    
                }
                else if ((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
                {
                    Console.WriteLine("Ele é um triangulo isósceles.");
                }
            }
            else
            {
                Console.WriteLine("Ele é um triangulo escaleno.");
            }
        }
    }
}
