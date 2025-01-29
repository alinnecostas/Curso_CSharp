namespace Formatacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.54821;
            double num2 = 54781.66876;

            Console.WriteLine($"{num1:F2}"); // reduz as casas decimais 
            Console.WriteLine($"{num2:N2}"); // transforma em valores e depois da virgula indica quantos num aparecer
            Console.WriteLine($"{num1:C2}"); // transforma em formato de moedas
            Console.WriteLine($"{num2:E2}"); // notação cientifica 
            Console.WriteLine($"{num1:P2}"); // transforma em porcentagem

        }
    }
}
