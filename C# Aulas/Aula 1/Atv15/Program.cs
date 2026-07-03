namespace Atv15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("============ Final secreto ==========");
            Console.WriteLine();
            Console.Write("Você derrotou o boos final (sim ou não): ");
            string defeated = Console.ReadLine();

            if(defeated == "SIM" ||
                defeated == "sim" ||
                defeated == "Sim")
            {

                Console.Write("Você encontrou a reliquia (sim ou não): ");
                string relic = Console.ReadLine();

                if (relic == "SIM" ||
                relic == "sim" ||
                relic == "Sim")
                {
                    Console.WriteLine("Final verdadeiro");
                }
                else if (relic == "NÃO" ||
                relic == "não" ||
                relic == "Não")
                {
                    Console.WriteLine("Final normal");
                }
                else
                {
                    Console.WriteLine("Erro");
                }
            }
            else if(defeated == "NÃO" ||
                defeated == "não" ||
                defeated == "Não")
            {
                Console.WriteLine("Continue sua aventura");
            }
            else
            {
                Console.WriteLine("Errom");
            }


        }
    }
}
