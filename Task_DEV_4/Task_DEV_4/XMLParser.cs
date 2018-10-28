using System;
using System.Text;

namespace Task_DEV_4
{
    /// <summary>
    /// This class parses XML file.
    /// </summary>
    public class XMLParser
    {
        private string pathToTheFile;

        public XMLParser(string fileLocation)
        {
            pathToTheFile = fileLocation;
        }

        /// <summary> 
        /// This method outputs the generated information.
        /// </summary> 
        public void OutputtingDataToConsole()
        {
            foreach (string nextstring in CreatingArrayOfData())
            {
                Console.WriteLine(nextstring);
            }
        }

        /// <summary> 
        /// This method processes information from a file.
        /// </summary> 
        /// <returns>Array of generated information</returns>
        private string[] CreatingArrayOfData()
        {
            string[] informationFromFile = System.IO.File.ReadAllLines(pathToTheFile);
            string[] arrayOfData = new string[informationFromFile.Length];
            int counter = 0;
            StringBuilder way = new StringBuilder();
            StringBuilder value = new StringBuilder();
            foreach (string readString in informationFromFile)
            {
                string stringforWork = CastTheString(readString);
                if (stringforWork.StartsWith("<?xml") || stringforWork == String.Empty)
                {
                    continue;
                }
                if (stringforWork.StartsWith("</"))
                {
                    int begin = 0;
                    int end = 0;
                    for (int i = 0; i < stringforWork.Length; i++)
                    {
                        if (stringforWork[i] == '/')
                        {
                            begin = i;
                        }
                        if (stringforWork[i] == '>')
                        {
                            end = i;
                        }
                    }
                    way.Remove(way.Length - (end - begin), (end - begin));
                    continue;
                }
                if (stringforWork.StartsWith("<") && stringforWork.Contains("="))
                {
                    int i = 1;
                    while (stringforWork[i] != ' ')
                    {
                        way.Append(stringforWork[i]);
                        i++;
                    }
                    i++;
                    way.Append('-');
                    value.Append(way);
                    while (stringforWork[i] != '>')
                    {
                        value.Append(stringforWork[i]);
                        i++;
                    }
                    arrayOfData[counter] = value.ToString();
                    value.Remove(0, value.Length);
                    counter++;
                    continue;
                }
                if (stringforWork.StartsWith("<") && stringforWork.Contains("</"))
                {
                    int i = 1;
                    while (stringforWork[i] != '>')
                    {
                        way.Append(stringforWork[i]);
                        i++;
                    }
                    way.Append('-');
                    i++;
                    value.Append(way);
                    while (stringforWork[i] != '<')
                    {
                        value.Append(stringforWork[i]);
                        i++;
                    }
                    arrayOfData[counter] = value.ToString();
                    value.Remove(0, value.Length);
                    int begin = 0;
                    int end = 0;
                    for (int j = 0; j < stringforWork.Length; j++)
                    {
                        if (stringforWork[j] == '/')
                        {
                            begin = j;
                        }
                        if (stringforWork[j] == '>')
                        {
                            end = j;
                        }
                    }
                    way.Remove(way.Length - (end - begin), (end - begin));
                    counter++;
                    continue;
                }
                if (stringforWork.StartsWith("<"))
                {
                    int i = 1;
                    while (stringforWork[i] != '>')
                    {
                        way.Append(stringforWork[i]);
                        i++;
                    }
                    way.Append('-');
                    continue;
                }
            }
            return Sorting(arrayOfData);
        }

        private string CastTheString(string stringForChange)
        {
            StringBuilder stringForWork = new StringBuilder();
            stringForWork.Append(stringForChange);
            int numberOfItemsToDelete = 0;
            for (int i = 0; i < stringForWork.Length; i++)
            {
                if (stringForWork[i] == ' ')
                {
                    numberOfItemsToDelete++;
                }
                else
                {
                    break;
                }
            }
            stringForWork.Remove(0, numberOfItemsToDelete);
            return stringForWork.ToString();
        }

        private string[] Sorting(string[] arrayForSorting)
        {
            int sizeTheSortedArray = 0;
            foreach (string nextstring in arrayForSorting)
            {
                if (nextstring != null)
                {
                    sizeTheSortedArray++;
                }
            }
            string[] sortedArray = new string[sizeTheSortedArray];
            for (int i = 0; i < sizeTheSortedArray; i++)
            {
                sortedArray[i] = arrayForSorting[i];
            }
            Array.Sort(sortedArray, StringComparer.InvariantCulture);
            return sortedArray;
        }
    }
}
