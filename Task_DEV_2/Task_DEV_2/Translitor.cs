using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_DEV_2
{
    /// <summary>
    /// This class translit text from Cyrillic to Latin and vice versa.
    /// </summary>
    public class Translitor
    {
        /// <summary>
        /// This method translit text from Cyrillic to Latin. 
        /// </summary>
        /// <param name="symbol">A symbol to translit.</param>
        /// <returns>Translit result.</returns>
        private string CyrillicToLatin(char symbol)
        {
            switch(symbol)
            {
                case 'а': return "a";
                case 'б': return "b";
                case 'в': return "v";
                case 'г': return "g";
                case 'д': return "d";
                case 'е': return "e";
                case 'ё': return "yo";
                case 'ж': return "zh";
                case 'з': return "z";
                case 'и': return "i";
                case 'й': return "y";
                case 'к': return "k";
                case 'л': return "l";
                case 'м': return "m";
                case 'н': return "n";
                case 'о': return "o";
                case 'п': return "p";
                case 'р': return "r";
                case 'с': return "s";
                case 'т': return "t";
                case 'у': return "u";
                case 'ф': return "f";
                case 'х': return "kh";
                case 'ц': return "ts";
                case 'ч': return "ch";
                case 'ш': return "sh";
                case 'щ': return "sch";
                case 'ъ': return string.Empty;
                case 'ы': return "i";
                case 'ь': return string.Empty;
                case 'э': return "e";
                case 'ю': return "yu";
                case 'я': return "ya";
                default: return symbol.ToString();
            }

        }

        /// <summary>
        /// This method translit text from Cyrillic to Latin.
        /// </summary>
        /// <param name="inputedString">String to translit.</param>
        /// <returns>Translit result.</returns>
        private string CyrillicToLatin(string inputedString)
        {
            StringBuilder translitInputedString = new StringBuilder();
            foreach(char symbol in inputedString.ToLower().ToCharArray())
            {
                translitInputedString.Append(CyrillicToLatin(symbol));
            }
            return translitInputedString.ToString();
        }

        /// <summary>
        /// This method translit text from Latin to Cyrillic.
        /// </summary>
        /// <param name="inputedString">String to translit.</param>
        /// <returns>Translit result.</returns>
        private string LatinToCirillic(string inputedString)
        {
            StringBuilder translitInputedStringBuilder = new StringBuilder();
            var symbols = inputedString.ToLower().ToCharArray();

            int i = 0;
            while (i < symbols.Length)
            {
                switch (symbols[i])
                {
                    case 'a': translitInputedStringBuilder.Append('а'); break;
                    case 'b': translitInputedStringBuilder.Append('б'); break;
                    case 'v': translitInputedStringBuilder.Append('в'); break;
                    case 'g': translitInputedStringBuilder.Append('г'); break;
                    case 'd': translitInputedStringBuilder.Append('д'); break;
                    case 'e': translitInputedStringBuilder.Append('е'); break;
                    case 'z':
                        if (i + 1 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 'h') { translitInputedStringBuilder.Append('ж'); break; }
                            else { translitInputedStringBuilder.Append('з'); i--; break; }
                        }
                        else { translitInputedStringBuilder.Append('з'); break; }
                    case 'i': translitInputedStringBuilder.Append('и'); break;
                    case 'k':
                        if (i + 1 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 'h') { translitInputedStringBuilder.Append('х'); break; }
                            else { translitInputedStringBuilder.Append('к'); i--; break; }
                        }
                        else { translitInputedStringBuilder.Append('к'); break; }
                    case 'l': translitInputedStringBuilder.Append('л'); break;
                    case 'm': translitInputedStringBuilder.Append('м'); break;
                    case 'n': translitInputedStringBuilder.Append('н'); break;
                    case 'o': translitInputedStringBuilder.Append('о'); break;
                    case 'p': translitInputedStringBuilder.Append('п'); break;
                    case 'r': translitInputedStringBuilder.Append('р'); break;
                    case 't':
                        if (i + 1 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 's') { translitInputedStringBuilder.Append('ц'); break; }
                            else { translitInputedStringBuilder.Append('т'); i--; break; }
                        }
                        else { translitInputedStringBuilder.Append('т'); break; }
                    case 'u': translitInputedStringBuilder.Append('у'); break;
                    case 'f': translitInputedStringBuilder.Append('ф'); break;
                    case 'y':
                        if (i + 1 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 'o') { translitInputedStringBuilder.Append('ё'); break; }
                            else if (symbols[i] == 'a') { translitInputedStringBuilder.Append('я'); break; }
                            else if (symbols[i] == 'u') { translitInputedStringBuilder.Append('ю'); break; }
                            else { translitInputedStringBuilder.Append('й'); i--; break; }
                        }
                        else { translitInputedStringBuilder.Append('й'); break; }
                    case 'c':
                        if (i + 1 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 'h') { translitInputedStringBuilder.Append('ч'); break; }
                            else { throw new Exception("We cann't translit this sequence of symbols!"); }
                        }
                        else { throw new Exception("We cann't translit this sequence of symbols!"); }
                    case 's':
                        if (i + 2 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 'c')
                            {
                                i++;
                                if (symbols[i] == 'h') { translitInputedStringBuilder.Append('щ'); break; }
                                else throw new Exception("We cann't translit this sequence of symbols!");
                            }
                            else if (symbols[i] == 'h') { translitInputedStringBuilder.Append('ш'); break; }
                            else { translitInputedStringBuilder.Append('c'); i--; break; }
                        }
                        else if (i + 1 < symbols.Length)
                        {
                            i++;
                            if (symbols[i] == 'h') { translitInputedStringBuilder.Append('ш'); break; }
                            else { translitInputedStringBuilder.Append('ш'); i--; break; }
                        }
                        else { translitInputedStringBuilder.Append('с'); break; }
                    case 'h': throw new Exception("We cann't translit this sequence of symbols!");
                    case 'j': throw new Exception("We cann't translit this sequence of symbols!");
                    default: translitInputedStringBuilder.Append(symbols[i]); break;
                }
                i++;
            }

            return translitInputedStringBuilder.ToString();
        }

        /// <summary>
        /// The method automatically selects the type of translit.
        /// </summary>
        /// <param name="inputedString">String to translit.</param>
        /// <returns>Check if string is Latin.</returns>
        private bool IdentifyLanguage(string inputedString)
        {
            return Regex.IsMatch(inputedString, "[a-zA-Z]");
        }

        /// <summary>
        /// The method translit text from Cyrillic to Latin and vice versa.
        /// </summary>
        /// <param name="inputedString">String to translit.</param>
        /// <returns>Translit result.</returns>
        public string Translit(string inputedString)
        {
            if (IdentifyLanguage(inputedString)) return LatinToCirillic(inputedString);
            else return CyrillicToLatin(inputedString);
        }
   }
}
