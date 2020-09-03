using System;

namespace IfStatements
{
    class Program
    {
        static void Main()
        {
            int playerHealth = 100;
            int monsterDamage = 90;
            playerHealth -= monsterDamage;

            Console.WriteLine("A monster attacked you and did " + monsterDamage + " damage.You have "
             + playerHealth + " health left.");
 if (playerHealth == 0)
            {
                Console.WriteLine("You died. Game over.");
            }
            Console.ReadKey();
        }
    }
}
