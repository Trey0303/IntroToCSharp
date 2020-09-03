using System;

namespace IfStatementsExercise
{
    class Program
    {
        bool playerAlive = true;
        
        static void Main()
        {
            if (playerAlive)
            {
                Console.WriteLine("player is still alive");
            }
            else {
                Console.WriteLine("player is dead");
            }
            int invulnerablilityTimer = 1;
            invulnerablilityTimer = invulnerablilityTimer - 1;
            if (invulnerablilityTimer > 0) {
                if (playerAlive) {
                    invulnerablilityTimer--;


                }
                Console.WriteLine("player is invunerable");
            }
            else if (invulnerablilityTimer == 0)
            {
                Console.WriteLine("player is vunerable");
            }
            else if (invulnerablilityTimer < 0)
            {
                invulnerablilityTimer = 0;
            }
        }
    }
}
