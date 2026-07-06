namespace Atv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool connection = true;
            bool ban = false;
            bool podeJogar = true; 

            Console.WriteLine("====== Ranqueada ======");
            Console.Write("Você está em qual nivel: ");
            int level = Convert.ToInt32(Console.ReadLine());

            Console.Write("Possui conexão estável (sim ou não): ");
            string stable = Console.ReadLine().ToLower();

            Console.Write("Você está banido (sim ou não): ");
            string banimento = Console.ReadLine().ToLower();

            if (level < 20)
            {
                Console.WriteLine("Erro: Sua conta não tem level suficiente.");
                podeJogar = false;
            }

            if (stable == "não")
            {
                connection = false;
                Console.WriteLine("Erro: Conexão ruim. Você precisa de internet estável.");
                podeJogar = false;
            }

            if (banimento == "sim")
            {
                ban = true;
                Console.WriteLine("Erro: Você está banido e não pode jogar.");
                podeJogar = false;
            }

            if (podeJogar == true)
            {
                Console.WriteLine("Tudo pronto! Entrando no Matchmaking Competitivo");
            }

        }
    }
}
