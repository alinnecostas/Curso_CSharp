namespace vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] num = new int[5];

            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;

            Console.WriteLine(num[3]);

            int[] n = new int[3] { 1, 2, 3 };

            Console.WriteLine(n[2]);
            Console.WriteLine();

          
            int[] numero = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numero[i] + " " + i);
            }
            */

            /*
            double[] reais = { 4.5, 3.2, 7.85, 10.64, -5.34, -2.1, 9.6, -9.5 };

            //for (int i = 0; i < 6; i++)

            for (int i = 0; i < reais.Length; i++) // fazer o pragrama automaticamente saber a quantidade de elementos no vetor
            {
                Console.WriteLine(reais [i]);
            }

            double reais_maior = reais.Max();
            Console.WriteLine("O maior valor é " + reais_maior);

            double reais_menor = reais.Min();
            Console.WriteLine("O menor valor é " + reais_menor);

            */

            /*
            string[] nomes = { "Maria", "João", "Gabriela", "Pedro", "Carla", "Ana", "José" };

            for (int i = 0; i < nomes.Length; i++)
            {
                if (i < nomes.Length - 1)
                {
                    Console.Write(nomes[i] + ", ");
                }

                else
                {
                    Console.WriteLine(nomes[i] + ".");
                }

            }
            */

            string[] nomes = { "Maria", "João", "Gabriela", "Pedro", "Carla", "Ana", "José" };


                    Console.WriteLine();
                String nome_primeiro = nomes.First();
                String nome_ultimo = nomes.Last();
                Console.WriteLine("O ultimo nome é: " + nome_ultimo + ".");
                Console.WriteLine("O primeiro nome é: " + nome_primeiro + ".");
                     Console.WriteLine();
                String nome_maior = nomes.Max();
                String nome_menor = nomes.Min();
                Console.WriteLine("O maior nome é: " + nome_maior + ".");
                Console.WriteLine("O menor nome é: " + nome_menor + ".");
                     Console.WriteLine();

        }
    }
}
