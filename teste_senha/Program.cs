namespace teste_senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //enquanto o usuário não digitar a senha, não entrará

            /*
            string senha = "123";
            string senhaDigitada;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++;

            } while (senha != senhaDigitada);

            Console.Clear() ;
            Console.WriteLine("Senha Correta! Tentativas: " + tentativas + " por hoje é só " + tentativas);
            */

            string senha = "123";
            string senhaDigitada;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++;

                if (tentativas > 2) { break; }
            } while (senha != senhaDigitada);

            if (senha != senhaDigitada)
            {
                Console.Clear();
                Console.WriteLine("Você tentou muitas vezes! Tentativas: " + tentativas );

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Senha Correta! Tentativas: " + tentativas + " sua senha: " + senha);

            }
        }
    }
}
