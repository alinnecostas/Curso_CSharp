namespace ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruta = { "Maça", "Caju", "Banana", "Kiwi", "Uva", "Morango", "Manga", "Acerola", "Mexerica", "Goiaba" };

            double[] preco = { 10.5, 9.5, 5.99, 14.99, 10.00, 8.99, 12.45, 14.95, 7.99, 10.99 };

            String nome_primeiro = fruta.First();
            String nome_ultimo = fruta.Last();

            Console.WriteLine("A primeira em ordem é: " + nome_primeiro + ".");
            Console.WriteLine("A ultima em ordem é: " + nome_ultimo + ".");

            Console.WriteLine();

            String nome_maior = fruta.Max();
            String nome_menor = fruta.Min();

            Console.WriteLine("O primeiro nome é: " + nome_menor + ".");
            Console.WriteLine("O ultimo nome é: " + nome_maior + ".");

            Console.WriteLine();

            double maior_preco = preco.Max();
            double menor_preco = preco.Min();


            Console.WriteLine("O maior preço é: " + maior_preco + ".");
            Console.WriteLine("O menor preço é: " + menor_preco+ ".");

            Console.WriteLine();


            for (int i = 0; i < fruta.Length; i++) 
            {
                Console.WriteLine(" " + fruta[i] + " custa o valor de " + preco[i] + " na feira.");
            }




        }
    }
}
