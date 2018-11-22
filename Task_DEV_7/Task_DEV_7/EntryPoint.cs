using System;

namespace Task_DEV_7
{
    /// <summary>
    /// This is the entry point of the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {

            if (args.Length < 2)
            {
                Console.WriteLine("Error! Incorrect format of the input data!");
                return;
            }

            try
            {
                int decimalNumber = Int32.Parse(args[0]);
                int systemRadix = Int32.Parse(args[1]);
                if (systemRadix > 1 && systemRadix < 21)
                {
                    NumeralSystemsConvertor convertor = new NumeralSystemsConvertor();
                    Console.WriteLine("Output: {0}", convertor.ConvertTo(decimalNumber, systemRadix));
                }
                else
                {
                    Console.WriteLine("Error! Incorrect format of the input data!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
