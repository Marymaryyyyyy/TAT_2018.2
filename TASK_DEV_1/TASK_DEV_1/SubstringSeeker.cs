using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK_DEV_1
{
    /// <summary>
    /// Searches for all unique substrings
    /// </summary>
    public class SubstringSeeker
    {
        /// <summary>
        /// Find maximum number of non-identical consecutive characters in a string 
        /// </summary>
        /// <param name="inputString"> input string</param>
        /// <param name="countCollection"> collection of maximum string lengths</param>
        public void FindUniqSubstring(string inputString, ref List<int> countCollection)
        {
            // null cheсk
            if (string.IsNullOrEmpty(inputString))
            {
                throw new ArgumentNullException(nameof(inputString));
            }

            // identical substring
            var partString = new StringBuilder();

            // add first element to substring
            partString.Append(inputString[0]);

            // get all non-repeating elements 
            for (int j = 1; (j < inputString.Length && partString.ToString().Contains(inputString[j]) == false); j++)
            {
                partString.Append(inputString[j]);
            }

            if (partString.Length < inputString.Length)
            {
                //recursion
                FindUniqSubstring(partString.ToString(), ref countCollection);
            }
            else
            {
                countCollection.Add(partString.Length);
            }
        }
    }
}
