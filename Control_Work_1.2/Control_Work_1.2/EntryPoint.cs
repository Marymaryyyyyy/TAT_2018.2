using System;

namespace Control_Work_1._2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                LinkSeeker linkSeeker = new LinkSeeker();
                if (args.Length != 1)
                {
                    throw new Exception("Incorrect number of arguments"); 
                }

                if (args[0].Length == 0)
                {
                    throw new Exception("Your string is empty"); 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
