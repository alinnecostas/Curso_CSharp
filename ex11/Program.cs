namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal1;


            Console.WriteLine("Digite seu salário:");
            sal1 = Convert.ToDouble(Console.ReadLine());

 

            if (sal1 > 2500)
            {
                Console.WriteLine("Seu salário é mais 5%: {0}, sendo o total de {1}", sal1, sal1 * 0.05 + sal1);
            }
            else if (sal1 > 1250)
            {
                Console.WriteLine("Seu salário é mais 10%: {0}, sendo o total de {1}", sal1, sal1 * 0.10 + sal1);
            }
            else 
            {
                Console.WriteLine("Seu salário é mais 15%: {0}, sendo o total de {1}", sal1, sal1 * 0.15 + sal1);
            }

        }
    }
}
