using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;

namespace SpaceBoxService.ShapesService.App_Code
{
    public class Circle : Shape
    {
        public double radius { get; set; }
        public Point Center { get; set; }

        public double GetPerimeter()
        {
            return radius*3.14*2;
        }

        public string ToBrailleDots(int radius)
        {
            int diameter = radius * 2;
            int[,] braille = new int[diameter, diameter];

            for (int i = 0; i < diameter; i++)
            {
                for (int j = 0; j < diameter; j++)
                {
                    int x = i - radius;
                    int y = j - radius;
                    if (x * x + y * y <= radius * radius)
                    {
                        braille[i, j] = 1;
                    }
                }
            }

            string output = "";
            for (int i = 0; i < diameter; i += 4)
            {
                for (int j = 0; j < diameter; j += 2)
                {
                    int value = 0;
                    value += braille[i, j] * 1;
                    value += braille[i, j + 1] * 2;
                    value += braille[i + 1, j] * 4;
                    value += braille[i + 1, j + 1] * 8;
                    char brailleChar = (char)(0x2800 + value);
                    output += brailleChar;
                }
                output += "\n";
            }

            return output;
        }

    }
}