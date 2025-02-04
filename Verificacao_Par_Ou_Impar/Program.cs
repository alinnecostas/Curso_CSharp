namespace ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //impar ou par

            int numero;

            Console.Write("Digite um numero: ");
            numero = (Convert.ToInt32(Console.ReadLine()));

            numero = (numero % 2);

            if (numero == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

        }
    }
}
