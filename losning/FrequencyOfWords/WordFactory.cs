using System;
using System.Collections.Generic;

namespace FrequencyOfWords
{
    static class WordFactory
    {
        private readonly static char[] Separators;

        static WordFactory()
        {
            // Array med tecken som ska betraktas som avskiljare 
            // mellan ord.
            Separators = new char[] { ' ', '\t', '\r', '\n', '.', 
                ',', ':', ';', '?', '!', '=', '/', '(' ,')', 
                '[', ']', '{', '}', '\\', '\'', '"' };
        }

        public static string[] GetWords(string text)
        {
            // Delar upp texten i ord.
            return text.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
        }

        public static IDictionary<string, int> CountWords(string[] words)
        {
            // Implementera den h�r metoden! Det �r "allt" du beh�ver g�ra... ;)
            throw new Exception("The method is not implemented.");
        }
    }
}
