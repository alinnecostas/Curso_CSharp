namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            float num = 3.14f; 
            char letra = 'A';
            string nome = "Alinne";


            Console.WriteLine("O número é {0}", numero);
            Console.WriteLine("O valor é R${0}...", num);
            Console.WriteLine("A primeira letra do meu nome é {0}", letra);
            Console.WriteLine("Eu me chamo {0}!", nome);

            Console.WriteLine("Saí com {0} reais de casa, e o valor do meu chocolate foi {1}! A primeira letra do meu nome é {2} - me chamo {3}.", numero, num, letra, nome);  

        }
    }
}
