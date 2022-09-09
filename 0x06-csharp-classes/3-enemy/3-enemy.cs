using System;

namespace Enemies
{
    /// <summary>
    /// Zombie enemy class
    /// </summary>
    class Zombie
    {
        // The health of the zombie
        private int health;

        /// <summary>Constructor for Zombie, sets health to 0</summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>Initialized an instance of Zombie</summary>
        /// <param name="value">health</param>
        /// <exception cref="ArgumentException"><paramref name="value"/> can be greater or equal at 0</exception>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");

            this.health = value;
        }

        /// <summary>Get health</summary>
        /// <returns>The health</returns>
        public int GetHealth()
        {
            return this.health;
        }
    }
}
