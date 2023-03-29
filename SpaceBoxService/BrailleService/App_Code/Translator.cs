using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SpaceBoxService.BrailleService.App_Code
{
    public class Translator
    {
        private static readonly Dictionary<char, string> BrailleMap = new Dictionary<char, string>
        {
            //letters
            { 'a', "⠁" }, { 'b', "⠃" }, { 'c', "⠉" }, { 'd', "⠙" },
            { 'e', "⠑" }, { 'f', "⠋" }, { 'g', "⠛" }, { 'h', "⠓" },
            { 'i', "⠊" }, { 'j', "⠚" }, { 'k', "⠅" }, { 'l', "⠇" },
            { 'm', "⠍" }, { 'n', "⠝" }, { 'o', "⠕" }, { 'p', "⠏" },
            { 'q', "⠟" }, { 'r', "⠗" }, { 's', "⠎" }, { 't', "⠞" },
            { 'u', "⠥" }, { 'v', "⠧" }, { 'w', "⠺" }, { 'x', "⠭" },
            { 'y', "⠽" }, { 'z', "⠵" }, { ' ', "⠀" },

            //numbers
            { '1', "⠁" }, { '2', "⠃" }, { '3', "⠉" }, { '4', "⠙" },
            { '5', "⠑" }, { '6', "⠋" }, { '7', "⠛" }, { '8', "⠓" },
            { '9', "⠊" }, { '0', "⠚" },

            //symbols
            {'*', "⠐⠔"}, {'%', "⠨⠴"}, {'\'', "⠠"}, {'[', "⠨⠣"},
            {']', "⠨⠜" }, {'-', "⠤" }, {'$', "⠈⠎"}, {':', "⠒"},
            {';', "⠆" }, {',',"⠂"}, {'—', "⠠⠤"}, {'…', "⠲⠲⠲"},
            {'!', "⠖"}, {'(', "⠐⠣"}, {')', "⠐⠜"}, {'?', "⠦"},
            {'“', "⠦" }, {'”', "⠴"}, {'+', "⠐⠖"}, {'>', "⠈⠜"},
            {'<', "⠈⠣"}, {'‘', "⠠⠦"}, {'’', "⠠⠴"}, {'.', "⠲"},
            {'@', "⠈⠁"}, {'&', "⠈⠯"}

        };

        private static readonly Dictionary<string, string> ContractionMap = new Dictionary<string, string>
        {
            {"but", "⠃" }, {"can", "⠉" }, {"do", "⠙" }, {"every", "⠑" },
            {"from", "⠋" }, {"go", "⠛" }, {"have", "⠓" }, {"just", "⠚" },
            {"knowledge", "⠅" }, {"like", "⠇" }, {"more", "⠍" }, {"not", "⠝" },
            {"people", "⠏" }, {"quite", "⠟" }, {"rather", "⠗" }, {"so", "⠎" },
            {"that", "⠞" }, {"us", "⠥" }, {"very", "⠧" }, {"will", "⠺" },
            {"it", "⠭" }, {"you", "⠽" }, {"as", "⠵" },

            {"and", "⠯" }, {"for", "⠿"}, {"of", "⠷"}, {"the", "⠮"}, {"with", "⠾"},
            {"child", "⠡" }, {"shall", "⠩"}, {"this", "⠹"}, {"which", "⠱"}, 
            {"out", "⠳"}, {"still", "⠌"}, {"be", "⠆"}, {"enough", "⠢"},
            {"were", "⠶"}, {"his", "⠦"}, {"in", "⠔"}, {"was", "⠴"}, 
            
            {"day", "⠐⠙"}, {"ever", "⠐⠑"}, {"father", "⠐⠋"}, {"here", "⠐⠓"},
            {"know", "⠐⠅" }, {"lord", "⠐⠇"}, {"mother", "⠐⠍"}, {"name", "⠐⠝"},
            {"one", "⠐⠕" }, {"part", "⠐⠏"}, {"question", "⠐⠟"}, {"right", "⠐⠗"},
            {"some", "⠐⠎" }, {"time", "⠐⠞"}, {"under", "⠐⠥"}, {"work", "⠐⠺"}, 
            {"young", "⠐⠽"}
        };

        public string ConvertToBraille(string input)
        {
            input = input.ToLower();
            var sb = new StringBuilder();
            int i = 0;
            while (i < input.Length)
            {
                bool contractionFound = false;

                // Check for contractions
                foreach (var kvp in ContractionMap)
                {
                    if (input.Length - i >= kvp.Key.Length
                        && input.Substring(i, kvp.Key.Length) == kvp.Key
                        && (i == 0 || !char.IsLetter(input[i - 1])) // Check that the previous character is not a letter
                        && (i + kvp.Key.Length == input.Length || !char.IsLetter(input[i + kvp.Key.Length]))) // Check that the next character is not a letter
                    {
                        sb.Append(kvp.Value);
                        i += kvp.Key.Length;
                        contractionFound = true;
                        break;
                    }
                }

                if (!contractionFound)
                {
                    // Check for regular characters
                    if (BrailleMap.TryGetValue(input[i], out var brailleSymbol))
                    {
                        sb.Append(brailleSymbol);
                    }
                    else
                    {
                        // If the character is not in the map, just ignore it
                    }
                    i++;
                }
            }
            return sb.ToString();
        }
    }
}