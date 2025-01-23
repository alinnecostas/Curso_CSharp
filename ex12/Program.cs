using System.Runtime.ConstrainedExecution;

namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ", i);
                }
            }*/


            /*for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0) { Console.WriteLine(i); }
            } O != significa "diferente" de zero. */


            int final;

            Console.WriteLine("Digite o final do intervalo: ");
            final = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= final; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ", i);
                }
            }
        }
    }
}
