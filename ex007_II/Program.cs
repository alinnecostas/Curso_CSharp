using System.Timers;

namespace ex007_II
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            int nota_final = 70;
            string resultado = "Reprovado";

            if (nota_final > 70)
            {
                resultado = "Aprovado";
            }

            Console.WriteLine("O aluno foi: {0}", resultado);
        }*/


        /*static void Main(string[] args)
        {
            int nota_final = 60;
            string resultado;

            if (nota_final >= 70)
            {
                resultado = "Aprovado!";
            }
            else
            {
                resultado = "Reprovado!";
            }

            Console.WriteLine("O aluno foi: {0}", resultado);
        }*/

        /*static void Main(string[] args)
        {
            int nota_final = 40;
            string resultado;

            if (nota_final >= 70)
            {
                resultado = "Aprovado!";
            }
            else if (nota_final >= 45)
            {
                resultado = "Recuperação";
            }
            else {
                resultado = "Reprovado!";
            }

            Console.WriteLine("O aluno foi: {0}", resultado);
        }*/

        /*static void Main(string[] args)
        {
            double nota_final;
            string resultado;

            Console.Write("Digite a nota final do aluno: ");
            nota_final = (Convert.ToDouble(Console.ReadLine()));

            if (nota_final >= 70)
            {
                resultado = "Aprovado!";
            }
            else if (nota_final >= 45)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado!";
            }

            Console.WriteLine("A nota do aluno foi: {0} - Resultado: {1}!", nota_final, resultado);
        }*/

        static void Main(string[] args)
        {
            double nota_final;
            string resultado;

            Console.Write("Digite a nota final do aluno: ");
            nota_final = (Convert.ToDouble(Console.ReadLine()));

            if (nota_final >= 70)
            {
                resultado = "Aprovado!";

                if (nota_final >= 95)
                {
                    resultado = "Aprovado com louvor";
                }
                else
                {
                    resultado = "Muito bem!";
                }
            }
            else if (nota_final >= 45)
            {
                resultado = "Recuperação";

            }
            else
            {
                resultado = "Reprovado!";
            }

            Console.WriteLine("A nota do aluno foi: {0} - Resultado: {1}!", nota_final, resultado);
        }
    }
}
