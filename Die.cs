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
        public byte FaceValue { get; set; }

        /// <summary>
        /// To determine to hold the die or not
        /// Yes for hold and No for not hold
        /// </summary>
        public bool IsHeld { get; set; }

        // Roll the die (set a new random face up value)

        /// <summary>
        /// Roll the die and set the value for the <see cref="FaceValue">
        /// Return new face value
        /// </summary>
        /// <return>Return new random number</return>
        public byte Roll() {
            // Generate random number from 1 -> 6

            // set the face value

            // return new number
            throw new System.NotImplementedException();
        }
    }
}
