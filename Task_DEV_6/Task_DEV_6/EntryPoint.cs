using System;

namespace Task_DEV_6
{
    class EntryPoint
    {
        private static void Main(string[] args)
        {
            FormatsConverter converter = new FormatsConverter();
            string[] sourceFile = args[0].Split('.');
            if (sourceFile[1] == "json")
            {
                Console.WriteLine(converter.ParseToXml(args[0]));
            }
        }
    }
}
