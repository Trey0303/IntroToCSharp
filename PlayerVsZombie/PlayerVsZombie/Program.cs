using System;

namespace PlayerVsZombie
{
    class Program
    {
        //to do:
        //add block
        //add mp
        //add healing
        //zombie not attack when player quits game, player checks health, player checks if alive or not
        //add fire attack

        static void Main(string[] args)
        {
            // introduction text
            Console.WriteLine("Welcome to the Zombie Arena");

            // controls whether battle should continue
            bool isBattleOver = false; ;

            // declare and instantiate new player
            Player player = new Player();
            Zombie zombo = new ArmoredZombie();

            //magic point cost for spells
            float healCost = 10.0f;
            float fireCost = 20.0f;

            // battle loop
            while (!isBattleOver)
            {
                // prompt the player for input
                Console.WriteLine("What would you like to do?");
                string playerInput = Console.ReadLine();

                // TODO: check if the player wants to quit
                if (playerInput == "quit")// if player types quit, end loop
                {
                    isBattleOver = true;//ends loop
                }
                else if (playerInput == "check_health")//see current health
                {
                    Console.WriteLine("Health: " + player.healthPoints);
                }
                else if (playerInput == "am_i_alive")//check if alive
                {
                    if (player.healthPoints > 0)
                    {
                        Console.WriteLine("your still alive ");
                    }
                    else if (player.healthPoints <= 0)
                    {
                        Console.WriteLine("you are dead ");
                    }
                }
                else if (playerInput == "attack") //player attack
                {
                    float damageDealt = player.Attack();
                    zombo.TakeDamage(damageDealt);
                    Console.WriteLine("Player dealt " + damageDealt + " points of damage.");
                    Console.WriteLine("Zombie has " + zombo.health + " points of health left.");
                    Console.WriteLine(" ");
                }
                else if (playerInput == "block")//player block
                {
                    float zomboAttack = zombo.Attack();
                    player.Block(zomboAttack);
                    Console.WriteLine("Zombie dealt " + zomboAttack + " points of damage.");
                    Console.WriteLine("Player has " + player.healthPoints + " points of health left.");
                    Console.WriteLine(" ");
                }
                else if (playerInput == "check_mp")//check magic points
                {
                    Console.WriteLine("Magic_Points: " + player.magicPoints);
                    Console.WriteLine(" ");
                }
                else if (playerInput == "heal")// player heals
                {
                    
                    if (player.magicPoints >= healCost)
                    {
                        player.Heal(healCost);
                        Console.WriteLine("Player has " + player.healthPoints + " points of health left.");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("not enough Magic_Points ");
                        Console.WriteLine(" ");
                    }
                }
                else if (playerInput == "fire")// player uses fire to attack
                {
                    
                    if (player.magicPoints >= fireCost) 
                    {
                        float damageDealt = player.Fire(fireCost);
                        zombo.TakeDamage(damageDealt);
                        Console.WriteLine("Player dealt " + damageDealt + " points of damage.");
                        Console.WriteLine("Zombie has " + zombo.health + " points of health left.");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("not enough Magic_Points ");
                        Console.WriteLine(" ");
                    }
                }
                else if (playerInput == "help")// tell player how to play game
                {
                    Console.WriteLine("Try to defeat zombie by typing in any of the commands listed below, type \"quit\" if you want to exit game.");
                    Console.WriteLine("commands: ");
                    Console.WriteLine("help ");
                    Console.WriteLine("check_health ");
                    Console.WriteLine("am_i_alive ");
                    Console.WriteLine("attack ");
                    Console.WriteLine("block ");
                    Console.WriteLine("check_mp ");
                    Console.WriteLine("heal ");
                    Console.WriteLine("fire ");
                    Console.WriteLine("quit ");
                    Console.WriteLine(" ");
                }
                
                //zombie attack
                if (playerInput == "attack" || playerInput == "heal" && player.magicPoints > healCost 
                    || playerInput == "fire" && player.magicPoints > fireCost) 
                {
                    float zomboAttack = zombo.Attack();
                    player.TakeDamage(zomboAttack);
                    Console.WriteLine("Zombie dealt " + zomboAttack + " points of damage.");
                    Console.WriteLine("Player has " + player.healthPoints + " points of health left.");
                    Console.WriteLine(" ");
                }
                

                if(player.IsDefeated || zombo.IsDefeated)
                {
                    if (player.IsDefeated)
                    {
                        Console.WriteLine("You Lose");
                    }
                    else if (zombo.IsDefeated)
                    {
                        Console.WriteLine("You Win");
                    }
                    isBattleOver = true;
                }
            }

            // good-bye text
            Console.WriteLine("Thanks for playing! Press ENTER to exit.");
            Console.ReadLine();

            return;
        }
    }
}
