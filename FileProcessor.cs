using Contorl11;
using System;
using System.IO;

namespace Console11
{
    public class FileProcessor
    {
        public static void ProcessFile(string fileIn, string fileOut, TextOperation op)
        {
            string text = File.ReadAllText(fileIn);
            string result = op(text);
            File.AppendAllText(fileOut, result + Environment.NewLine);
        }
    }