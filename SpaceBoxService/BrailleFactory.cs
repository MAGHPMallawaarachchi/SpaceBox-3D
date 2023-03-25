using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SpaceBoxService
{
    public class BrailleFactory
    {
        private static readonly Dictionary<char, string> BrailleMap = new Dictionary<char, string>
        {
            { 'a', "⠁" }, { 'b', "⠃" }, { 'c', "⠉" }, { 'd', "⠙" },
            { 'e', "⠑" }, { 'f', "⠋" }, { 'g', "⠛" }, { 'h', "⠓" },
            { 'i', "⠊" }, { 'j', "⠚" }, { 'k', "⠅" }, { 'l', "⠇" },
            { 'm', "⠍" }, { 'n', "⠝" }, { 'o', "⠕" }, { 'p', "⠏" },
            { 'q', "⠟" }, { 'r', "⠗" }, { 's', "⠎" }, { 't', "⠞" },
            { 'u', "⠥" }, { 'v', "⠧" }, { 'w', "⠺" }, { 'x', "⠭" },
            { 'y', "⠽" }, { 'z', "⠵" }, { ' ', "⠀" }
        };

        public string ConvertToBraille(string input)
        {
            var sb = new StringBuilder();
            foreach (var c in input.ToLower())
            {
                if (BrailleMap.TryGetValue(c, out var brailleSymbol))
                {
                    sb.Append(brailleSymbol);
                }
                else
                {
                    // If the character is not in the map, just ignore it
                }
            }
            return sb.ToString();
        }
    }
}