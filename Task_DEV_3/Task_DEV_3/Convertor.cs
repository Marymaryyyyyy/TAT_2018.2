using System;

namespace Task_DEV_3
{
    /// <summary>
    ///Converter converts the number in other notation system.
    /// </summary>
    public class Convertor
    {

        /// <summary>
        /// ConvertTo converts the number in other notation system.
        /// </summary>
        /// <param name="decimalNumber">input decimal number</param>
        /// <param name="convertedToValue">new number notation</param>
        /// <returns>output number of the new notation system </returns>
        
        public string ConvertTo(int decimalNumber, int convertedToValue)
        {
            string convertedValue="";

            do
            {
                int rest = decimalNumber % convertedToValue;
                decimalNumber = decimalNumber / convertedToValue;
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
