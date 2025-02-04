namespace ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double limite_pista;
            double km_rodado;
            string resultado;

            limite_pista = 80;

            Console.Write("Km rodados: ");
            km_rodado = (Convert.ToDouble(Console.ReadLine()));


            limite_pista = (km_rodado - limite_pista);

            if (km_rodado <= 80)
            {
                Console.WriteLine("Não foi localizado multa!");
            }


            else
            {
                resultado = "Multado!";

                Console.WriteLine("{1} A multa custará: R${0},00!", limite_pista * 7, resultado);

            }



        }
    }
}
