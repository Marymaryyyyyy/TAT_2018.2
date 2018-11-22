using System;

namespace Task_DEV_7
{
    /// <summary>
    ///Converts the number in other notation system.
    /// </summary>
    public class NumeralSystemsConvertor
    {
        /// <summary>
        /// Converts the number in other notation system.
        /// </summary>
        /// <param name="decimalNumber">input decimal number</param>
        /// <param name="systemRadix">new number notation</param>
        /// <returns>output number of the new notation system </returns>

        public string ConvertTo(int decimalNumber, int systemRadix)
        {
            string convertedValue = String.Empty;
            int indexString = 0;

            if (decimalNumber < 0)
            {
                decimalNumber *= -1;
                indexString++;
                convertedValue = ("-") + convertedValue;
            }
            do
            {
                int rest = decimalNumber % systemRadix;
                decimalNumber = decimalNumber / systemRadix;
                convertedValue = ChooseSymbol(rest) + convertedValue;
            }
            while (decimalNumber > 0);
            return convertedValue;
        }
        private char ChooseSymbol(int rest)
        {
            const string elements = "0123456789ABCDEFGHIJ";
            return elements[rest];
        }
    }
}
