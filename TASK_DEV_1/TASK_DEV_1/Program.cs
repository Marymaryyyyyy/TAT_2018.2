using System;
using System.Collections.Generic;
using System.Linq;

namespace TASK_DEV_1
{
    /// <summary>
    /// Entry point
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // input string
            var inputString = Console.ReadLine();

            // null check
            if (string.IsNullOrEmpty(inputString))
            {
                Console.WriteLine("There is an empty string!!!");
            }
            // reference to SubstringSeeker class
            var findMaxCount = new SubstringSeeker();

            // collection of maximum string lengths
            List<int> countCollection = new List<int>();

            // get all variants of unique sequences
            for (int i = 0; i < inputString.Length; i++)
            {
                findMaxCount.FindUniqSubstring(inputString.Substring(i), ref countCollection);
            }

            Console.WriteLine(countCollection.Max());
            Console.ReadKey();
        }
    }
}
