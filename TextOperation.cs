using System;
using System.Collections.Generic;
using System.Text;

namespace Contorl11
{
    public class TextOperation

    {
        public delegate string TextOperationDelegate(string text);
        
        public static string ToUpperCase(string text)
        {
            return text.ToUpper();
        }
        public static string CountChars(string text)
        {
            return text.Length.ToString();
        }
        public static string CountWords(string text)
        {
            string [] words = text.Split( new char[] { '\r', '\n', '\t' },StringSplitOptions.RemoveEmptyEntries);
            return words.Length.ToString();
        }



    }
}
