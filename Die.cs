namespace DieRoller
{
    /// <summary>
    /// Prepresent six side of the die (1 -> 6)
    /// </summary>
    public class Die
    {
        /// <summary>
        /// To generate the random number
        /// </summary>
        private static Random _random;
        /// <summary>
        /// The face value of the die (1 -> 6)
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// To determine to hold the die or not
        /// Yes for hold and No for not hold
        /// </summary>
        public bool IsHeld { get; set; }


        /// <summary>
        /// Create the constructor, roll the die to get random number
        /// </summary>
        public Die()
        {
            Roll();
        }

        /// <summary>
        /// This constructor is used to initialize any static data once when program start
        /// </summary>
        static Die() {
            _random = new Random();
        }

        /// <summary>
        /// Roll the die and set the value for the <see cref="FaceValue">
        /// if the die is not currently held
        /// Return the <see cref="FaceValue">
        /// </summary>
        /// <return>Return new random number</return>
        public byte Roll() {
            if (!IsHeld) { 
                // Generate random number from 1 -> 6
                byte newValue = (byte)_random.Next(1, 7);
                // set the face value

                FaceValue = newValue;
                // return new number
                return FaceValue;
            }
            return FaceValue;
        }
    }
}
