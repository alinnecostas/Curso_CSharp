﻿namespace Area_do_Terreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("Calcular a área do terreno");
            Console.WriteLine("============================");
            Console.WriteLine();

            Console.WriteLine("Digite a largura do terreno(m): ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Digite o comprimento do terreno(m): ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            area(l, c);
        }

        static void area (double largura, double comprimento)
        {
            double a = largura * comprimento;
            Console.WriteLine($"A área do terreno de {largura} x {comprimento} é de {a:F2}M²");
        }
    }
}
