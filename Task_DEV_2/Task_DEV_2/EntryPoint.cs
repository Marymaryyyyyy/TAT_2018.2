using System;
using System.Text;

namespace Task_DEV_2
{
    /// <summary>
    /// Program entry point.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Translitor translitor = new Translitor();

                Console.WriteLine(args[0]);
                Console.WriteLine(translitor.Translit(args[0]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
