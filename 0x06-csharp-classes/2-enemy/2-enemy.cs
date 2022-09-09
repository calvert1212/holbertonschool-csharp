using System;

namespace Enemies
{
    /// <summary>
    /// Zombie enemy class
    /// </summary>
    class Zombie
    {
        /// <value>Zombie health</value>
        public int health;

        /// <summary>Constructor for Zombie, sets health to 0</summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>Zombie instance</summary>
        /// <param name="value">The value of the health</param>
        /// <exception cref="ArgumentException"><paramref name="value"/> can be greater or equal at 0</exception>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");

            this.health = value;
        }
    }
}
