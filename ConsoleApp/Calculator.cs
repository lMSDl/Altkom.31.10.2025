namespace ConsoleApp
{
    /// <summary>
    /// Provides basic arithmetic operations for float numbers.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Returns the sum of two float numbers as an integer.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The integer result of a + b.</returns>
        public int Sum(float a, float b) => (int)(a + b);

        /// <summary>
        /// Subtracts the second float number from the first and returns the result as an integer.
        /// </summary>
        /// <param name="a">The number to subtract from.</param>
        /// <param name="b">The number to subtract.</param>
        /// <returns>The integer result of a - b.</returns>
        public int Subtract(float a, float b)
        {
            return (int)(a - b);
        }

        /// <summary>
        /// Multiplies two float numbers and returns the result as an integer.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The integer result of a * b.</returns>
        public int Multiply(float a, float b)
        {
            return (int)(a * b);
        }

        /// <summary>
        /// Divides the first float number by the second and returns the result as a nullable float.
        /// Returns null if the divisor is zero.
        /// </summary>
        /// <param name="a">The dividend.</param>
        /// <param name="b">The divisor.</param>
        /// <returns>The result of a / b, or null if b is zero.</returns>
        public float? Divide(float a, float b)
        {
            if (b == 0)
            {
                return null;
            }
            return a / b;
        }
    }
}