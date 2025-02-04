namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;


            Console.Write("Digite um número:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite um número:");
            n2 = Convert.ToInt32(Console.ReadLine());

            media = (n1 + n2)/2;

            Console.WriteLine("Média: {0}", media);
        }
    }
}
