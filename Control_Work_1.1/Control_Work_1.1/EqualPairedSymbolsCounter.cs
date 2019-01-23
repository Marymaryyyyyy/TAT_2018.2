using System.Collections.Generic;

namespace Control_Work_1._1
{
    /// <summary>
    /// This class works with string and
    /// Count paired symbols, that meet as often as possible.
    /// </summary>
    public class EqualPairedSymbolsCounter
    {
        private string currentString;

        public EqualPairedSymbolsCounter(string ourString)
        {
            currentString = ourString;
        }

        /// <summary> 
        /// This method finds max length of idential symbols.
        /// </summary>
        /// <returns>Returns the maximum meeting duplicate symbols.</returns>
        public string FindSimilarSimbolsSequance()
        {
            var strList = new List<string>();
            for (var i = 0; i < currentString.Length-1; i++)
            {
                strList.Add(string.Concat(currentString[i], currentString[i + 1]));
            }

            var max = 0;
            var maxSymbPair = string.Empty;
            for (int i = 0; i < strList.Count; i++)
            {
                var count = 0;
                for (int j = i; j < strList.Count - 1; j++)
                {
                    if (strList[i] == strList[j + 1])
                        count++;
                }
                if (count > max)
                {
                    max = count;
                    maxSymbPair = strList[i];
                }
            }
            return maxSymbPair;
        }
    }
}
