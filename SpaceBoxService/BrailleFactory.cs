using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceBoxService
{
    public class BrailleFactory
    {
        private Dictionary<char, string> brailleDictionary;

        public BrailleFactory()
        {
            // Initialize the braille dictionary with the mappings between characters and their braille representation
            brailleDictionary = new Dictionary<char, string>
        {
            {'a', "1"},
            {'b', "12"},
            {'c', "14"},
            {'d', "145"},
            {'e', "15"},
            {'f', "124"},
            {'g', "1245"},
            {'h', "125"},
            {'i', "24"},
            {'j', "245"},
            {'k', "13"},
            {'l', "123"},
            {'m', "134"},
            {'n', "1345"},
            {'o', "135"},
            {'p', "1234"},
            {'q', "12345"},
            {'r', "1235"},
            {'s', "234"},
            {'t', "2345"},
            {'u', "136"},
            {'v', "1236"},
            {'w', "2456"},
            {'x', "1346"},
            {'y', "13456"},
            {'z', "1356"},
            {'0', "123456"},
            {'1', "1"},
            {'2', "12"},
            {'3', "14"},
            {'4', "145"},
            {'5', "15"},
            {'6', "124"},
            {'7', "1245"},
            {'8', "125"},
            {'9', "24"}
        };
        }

        public string[] GetBrailleDots(string text)
        {
            // Convert the text to lowercase and split it into characters
            char[] characters = text.ToLower().ToCharArray();

            // Convert each character to its corresponding braille representation
            List<string> brailleDots = new List<string>();
            foreach (char c in characters)
            {
                if (brailleDictionary.ContainsKey(c))
                {
                    brailleDots.Add(brailleDictionary[c]);
                }
            }

            // Return the braille representation as an array of strings
            return brailleDots.ToArray();
        }
    }
}