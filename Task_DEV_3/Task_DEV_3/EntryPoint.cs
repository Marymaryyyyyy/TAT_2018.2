using System;
namespace Task_DEV_3
{
    /// <summary>
    /// This is the entry point of the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int decimalNumber
;
            int convertedToValue;
            if (args.Length < 2)
            {
                Console.WriteLine("Error! Incorrect format of the input data!");
                return;
            }

            try
            {
                decimalNumber = Int32.Parse(args[0]);
                convertedToValue = Int32.Parse(args[1]);
                if (convertedToValue > 1 && convertedToValue < 21)
                {
                    Convertor converter = new Convertor();
                    Console.WriteLine("Output: {0}", converter.ConvertTo(decimalNumber, convertedToValue));
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