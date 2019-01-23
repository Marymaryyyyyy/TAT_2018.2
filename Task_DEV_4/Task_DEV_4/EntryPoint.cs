using System;

namespace Task_DEV_4
{
    /// <summary>
    /// Entry point to the programm.
    /// </summary>
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                XMLParser str = new XMLParser(args[0]);
                str.OutputtingDataToConsole();
            }
            catch (FormatException)
            {
                Console.WriteLine("You entered incorrect arguments!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You entered the wrong path to the file!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You entered incorrect arguments!");
            }
        }
    }
}
