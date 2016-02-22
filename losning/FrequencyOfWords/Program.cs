using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FrequencyOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = null;

                Console.WriteLine("Läser textfilen '{0}'...", args[0]);

                // Öppna textfilen...
                using (StreamReader reader = new StreamReader(args[0]))
                {
                    // ... samt läs hela textfilen och konvertera bokstäverna till gemener.
                    text = reader.ReadToEnd().ToLower();
                }

                Console.WriteLine("Analyserar texten...");

                // Dela upp texten i separata ord...
                string[] words = WordFactory.GetWords(text);

                // ...och räkna förekomsten av respektive ord.
                IDictionary<string, int> frequencyTable = WordFactory.CountWords(words);

                // Presentera lite statistik...
                Console.WriteLine("Hittade {0} unika \"ord\"...", frequencyTable.Keys.Count);

                // ...och skriv resulatet till en textfil.
                Console.WriteLine("Skriver frekvenstabell till '{0}'...", args[1]);

                // Öppna textfil för skrivning,...
                using (StreamWriter writer = new StreamWriter(args[1]))
                {
                    // ...skriv rubrik och...
                    writer.WriteLine("Ord                       Antal");
                    writer.WriteLine("------------------------- -----");
                    // ...därefter ord för...
                    foreach (string word in frequencyTable.Keys)
                    {
                        // ...ord i en kolumn om 25 tecken och antalet högerjusterat.
                        writer.WriteLine("{0, -25} {1, 5}", word, frequencyTable[word]);
                    }
                }

                Console.WriteLine("Analysen klar!");
            }
            catch (IOException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ett oväntat fel inträffade. Misslyckades med att analysera texten.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }
}
