namespace Fatorial_Calculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fatorial(5));
        }

        static int fatorial(int n, bool show = false)
        {
            int f = 1;

            for (int i = 1; i <= n; i++)
            {
                if (show)
                {
                    Console.WriteLine(i);
                    if (i < n)
                    {
                        Console.Write(" x ");
                    }
                    else
                    {
                        Console.WriteLine(" = ");
                    }
                }

                f *= i;
            }

            return f;

        }
    }
}
