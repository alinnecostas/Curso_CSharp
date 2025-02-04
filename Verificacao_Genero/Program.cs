namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;

            Console.Write("Digite o gênero: ");
            genero = Console.ReadLine().ToUpper();
            
            while (genero != "F" && genero != "M") 
            {
                Console.Write("Digite novamente o gênero: ");
                genero = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Bem-vindo ao curso de C#!");
        }
       
    }
}
