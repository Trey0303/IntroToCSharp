using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerVsZombie
{
    class Player
    {
        public float healthPoints = 100;
        public float defensePoints = 10.0f;
        public float magicPoints = 50;

        // Accepts an attack with the given number of damage points
        public void TakeDamage(float damagePoints)
        {
            // TODO: given an amount of damage points, modify the player's health
            healthPoints -= damagePoints;
        }

        public void Block(float damagePoints)
        {
            float actualDamage = damagePoints - defensePoints;
            healthPoints -= actualDamage;
        }

        public void Heal(float healCost)
        {
                healthPoints += 30.0f;
                magicPoints -= healCost;
        }
        public float Fire(float fireCost)
        {
            magicPoints -= fireCost;
            return 50.0f;
            
            
        }
        // Returns the damage points dealt by this attack
        public float Attack()
        {
            // TODO: calculate the number of points of damage to deal and return it
            return 30.0f;
        }

        public bool IsDefeated
        {
            get
            {
                // TODO: how do we know if the player has been defeated?
                if (healthPoints <= 0.0f) 
                {
                    Console.WriteLine("Game Over ");
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }
    }
}
