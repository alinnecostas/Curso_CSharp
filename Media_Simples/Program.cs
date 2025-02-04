namespace ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int num4;


            Console.WriteLine("Digite um número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            num3 = num1 + num2;
            num4 = num3 /2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num4);
        }
    }
}
