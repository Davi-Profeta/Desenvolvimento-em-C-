namespace Atv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] weaponDamage = new int[7];

            Console.WriteLine("Tem 7 registro de dano de armas");

            for (int i = 0; i < weaponDamage.Length; i++)
            {
                Console.Write("Qual o dano da arma " + (i+1) + ": ");
                weaponDamage[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            
            for (int i = 0;i < weaponDamage.Length; i++)
            {

                if(weaponDamage[i] >= 100)
                {
                    Console.WriteLine("A arma " + (i+1) + " deu mais que 100 de dano: " + weaponDamage[i]);
                }
                
            }
        }
    }
}
