using System;

namespace ReplaceWordRecursively
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string textToReplace = Console.ReadLine();
            string textToReplaceWith = Console.ReadLine();
            Console.WriteLine(RecursiveReplace(text, textToReplace, textToReplaceWith));
        }

        static string RecursiveReplace(string text, string textToReplace, string textToReplaceWith)
        {
            if (!text.Contains(textToReplace))
            {
                return text;
            }

            return text.Substring(0, text.IndexOf(textToReplace)) + textToReplaceWith + RecursiveReplace(text.Substring(text.IndexOf(textToReplace) + 1), textToReplace, textToReplaceWith);
        }
    }
}
