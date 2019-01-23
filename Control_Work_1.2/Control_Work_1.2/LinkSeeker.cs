using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Control_Work_1._2
{
    public struct LinkItem
    {
        public string hRef;
        public string inputString;

        public override string ToString()
        {
            return hRef + "\n\t" + inputString;
        }
    }

    public class LinkSeeker
    {
        public static List<LinkItem> Find(string str)
        {
            List<LinkItem> list = new List<LinkItem>();

          
            MatchCollection m1 = Regex.Matches(str, @"(<a.*?>.*?</a>)",RegexOptions.Singleline);

           
            foreach (Match m in m1)
            {
                string value = m.Groups[1].Value;
                LinkItem i = new LinkItem();

               
                Match m2 = Regex.Match(value, @"href=\""(.*?)\""",RegexOptions.Singleline);
                if (m2.Success)
                {
                    i.hRef = m2.Groups[1].Value;
                }

                string t = Regex.Replace(value, @"\s*<.*?>\s*", "",RegexOptions.Singleline);
                i.inputString = t;

                list.Add(i);
            }
            return list; 
        }
    }

}
