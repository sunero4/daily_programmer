using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.HexColors369
{
    public class HexColors
    {
        public string ConvertToHexColor(int red, int green, int blue)
        {
            var hexColorString = $"#{red:X}{green:X}{blue:X}";
            return hexColorString;
        }

        public string BlendHexColors(string[] hexColors)
        {
            int totalRed = 0, totalGreen = 0, totalBlue = 0;
            var length = hexColors.Length;
            foreach (var hexColor in hexColors)
            {
                var colorValues = GetChannelValuesFromHexColorString(hexColor);
                totalRed += colorValues[0];
                totalGreen += colorValues[1];
                totalBlue += colorValues[2];
            }

            var averageHexColor = $"#{totalRed / length:X}{totalGreen / length:X}{totalBlue / length:X}";
            return averageHexColor;
        }

        private int[] GetChannelValuesFromHexColorString(string hexColor)
        {
            var red = int.Parse(hexColor.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
            var green = int.Parse(hexColor.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
            var blue = int.Parse(hexColor.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);

            return new[] {red, green, blue};
        }
    }
}
