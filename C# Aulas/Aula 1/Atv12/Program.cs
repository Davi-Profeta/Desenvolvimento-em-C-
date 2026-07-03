using System.Diagnostics;

namespace Atv12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strength = 0;
            int speed = 0;
            int defense = 0;
            
            Console.WriteLine("========== EVOLUÇÃO =========");
            Console.WriteLine("O que você vai evoluir?");
            Console.WriteLine();
            Console.WriteLine("Força - " +strength);
            Console.WriteLine("Defesa - " +defense);
            Console.WriteLine("Velocidade -" +speed);
            Console.WriteLine();
            Console.Write("Digite qual quer evoluir: ");
            string attribute = Console.ReadLine();

            if(attribute == "Força" ||
                attribute == "força" ||
                attribute == "FORÇA")
            {
                Console.WriteLine("Sua força aumentou em 10");
                strength += 10;
            }
            else if (attribute == "Defesa" ||
                attribute == "defesa" ||
                attribute == "DEFESA")
            {
                Console.WriteLine("Sua Defesa aumentou em 10");
                defense += 10;
            }
            else if (attribute == "Velocidade" ||
                   attribute == "velocidade" ||
                   attribute == "VELOCIDADE")
            {
                Console.WriteLine("Sua Velocidade aumentou em 10");
                speed += 10;
            }
            else
            {
                Console.WriteLine("Não exite essa habilidade");
            }


        }
    }
}
