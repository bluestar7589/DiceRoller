namespace DieRoller
{
    /// <summary>
    /// Prepresent six side of the die (1 -> 6)
    /// </summary>
    public class Die
    {
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
        /// Roll the die and set the value for the <see cref="FaceValue">
        /// if the die is not currently held
        /// Return the <see cref="FaceValue">
        /// </summary>
        /// <return>Return new random number</return>
        public byte Roll() {
            if (!IsHeld) { 
                // Generate random number from 1 -> 6
                Random random = new Random();

                byte newValue = (byte)random.Next(1, 7);
                // set the face value

                FaceValue = newValue;
                // return new number
                return FaceValue;
            }
            return FaceValue;
        }
    }
}
