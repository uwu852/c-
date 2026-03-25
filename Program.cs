using Contorl11;
using System;
using System.IO;

namespace Console11
{
    class Program
    {
        static void Main()
        {
            string fileIn = "textPD21.txt";
            string fileOut = "resultPD21.txt";
\
            if (File.Exists(fileOut))
            {
                File.Delete(fileOut);
            }

            FileProcessor.ProcessFile(fileIn, fileOut, TextOperations.ToUpper);
            FileProcessor.ProcessFile(fileIn, fileOut, TextOperations.CountChars);
            FileProcessor.ProcessFile(fileIn, fileOut, TextOperations.CountWords);

            Console.WriteLine("Готово. Натисніть Enter...");
            Console.ReadLine();
        }
    }
}