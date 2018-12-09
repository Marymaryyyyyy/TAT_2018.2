using System;

namespace Control_Work_1._1
{
    /// <summary>
    /// Entry point.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] symbolsString)
        {
            try
            {
                EqualPairedSymbolsCounter counter = new EqualPairedSymbolsCounter(symbolsString[0]);
                if (symbolsString.Length != 1)
                {
                    throw new Exception("Incorrect number of arguments"); 
                }

                if (symbolsString[0].Length == 0)
                {
                    throw new Exception("Your string is empty");
                }
                Console.WriteLine(counter.FindSimilarSimbolsSequance());

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
