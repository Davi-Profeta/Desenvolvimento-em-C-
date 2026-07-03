namespace Atv9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valida = "GAMER2026";
            Console.WriteLine("============= Leitura de código promocional ==================");
            Console.Write("Qual seu código promocional: ");
            string codigo = Console.ReadLine();

            if( codigo == valida)
            {
                Console.WriteLine("Skin exclusiva desbloqueada");
            }
            else
            {
                Console.WriteLine("Código inválido");
            }

        }
    }
}
