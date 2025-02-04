namespace ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um numero para a conta:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha um numero para a conta:");
            int b = Convert.ToInt32(Console.ReadLine());

            soma (a, b);
            sub(a, b);
            div(a, b);
            mult(a, b);

        }

        static void soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine("A soma de " + a + " + " + b + " = " + resultado);
        }

        static void sub(int a, int b)
        {
            int resultado = a - b;
            Console.WriteLine("A soma de " + a + " - " + b + " = " + resultado);
        }

        static void div(int a, int b)
        {
            int resultado = a / b;
            Console.WriteLine("A soma de " + a + " / " + b + " = " + resultado);
        }

        static void mult(int a, int b)
        {
            int resultado = a * b;
            Console.WriteLine("A soma de " + a + " * " + b + " = " + resultado);
        }
    }
}
