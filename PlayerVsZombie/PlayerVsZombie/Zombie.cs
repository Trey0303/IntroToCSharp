using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerVsZombie
{
    class Zombie
    {
        public float health = 100;

        // Accepts an attack with the given number of damage points
        public virtual void TakeDamage(float damagePoints)
        {
            // TODO: given an amount of damage points, modify the zombie's health
            health -= damagePoints;
        }

        // Returns the damage points dealt by this attack
        public virtual float Attack()
        {
            // TODO: calculate the number of points of damage to deal and return it
            return 20.0f;
        }

        public bool IsDefeated
        {
            get
            {
                // TODO: complete this part!
                if (health <= 0.0f)
                {
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
