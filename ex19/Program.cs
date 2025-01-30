namespace ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do lado A: ");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            double ladoB = Convert.ToDouble(Console.ReadLine());

            
            area(ladoA, ladoB);

        }

        static void area(double ladoA, double ladoB)
        {
            double a = (ladoA * ladoB)/2;
            Console.WriteLine($"A area do triangulo {ladoA} x {ladoB} é de: {a:F2}");
        }
    }
}
