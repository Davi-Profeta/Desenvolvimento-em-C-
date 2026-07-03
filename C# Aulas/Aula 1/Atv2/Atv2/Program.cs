namespace Atv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanto de HP o boss tem: ");
            int HP = Convert.ToInt32(Console.ReadLine());

            if(HP > 50)
            {
                Console.WriteLine("Boss saudável");
            }
            else if(HP <= 50 && HP > 0)
            {
                Console.WriteLine("Boos enfraquecido");
            }
            else if(HP == 0)
            {
                Console.WriteLine("Boos derrotado");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }
    }
}
