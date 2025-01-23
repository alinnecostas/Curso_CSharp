namespace estrutura_de_repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 10; i++) - crescente

            //for (int i = 10; i >= 0; i--) - decrescente 

            // (int i = 0; i <= 10; i+=2) - soma os pares

            //for (int i = 0; i <= 10; i += 1+2) - soma os impares


            /*for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }*/

            Console.WriteLine(".....................");
            Console.WriteLine("Contagem regressiva:");
            Console.WriteLine(".....................");

            for (int i = 10; i > 0; i--)
            {
                Console.Write("{0}, ", i);
                //Console.WriteLine(i);
            }
        }
    }
}
