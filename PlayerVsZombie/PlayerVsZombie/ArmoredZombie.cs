using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerVsZombie
{
    class ArmoredZombie: Zombie
    {
        public float defensePoints = 10.0f;

        public override void TakeDamage(float damagePoints)
        {
            float actualDamage = damagePoints - defensePoints;
            health -= actualDamage;
        }
    }
}
