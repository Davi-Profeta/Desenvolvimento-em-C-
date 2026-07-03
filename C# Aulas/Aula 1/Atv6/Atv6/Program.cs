namespace Atv6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua senha: ");
            string password = Console.ReadLine();

            if(password == "DRAGON")
            {
                Console.Write("Você possui a key (sim ou não): ");
                string key = Console.ReadLine();

                if(key == "sim" || key == "Sim" || key == "SIM")
                {
                    Console.WriteLine("Cofre aberto");
                }
                else if(key == "não" || key == "Não" || key == "NÃO")
                {
                    Console.WriteLine("Você precisa da key");
                }
                else
                {
                    Console.WriteLine("Erro");
                }
                
            }
            else
            {
                Console.WriteLine("Senha incorreta");
            }

        }
    }
}
