using System.Text;

public static class RomanNumeralExtension
{
    private static readonly Dictionary<int, string> NumeralThresholds = new()
    {
        { 1000, "M"  },
        { 900,  "CM" },
        { 500,  "D"  },
        { 400,  "CD" },
        { 100,  "C"  },
        { 90,   "XC" },
        { 50,   "L"  },
        { 40,   "XL" },
        { 10,   "X"  },
        { 9,    "IX" },
        { 5,    "V"  },
        { 4,    "IV" },
        { 1,    "I"  },
    };

    public static string ToRoman(this int value)
    {
        var remaining = value;
        var output = new StringBuilder();

        foreach (var (threshold, numeral) in NumeralThresholds)
        {
            while (remaining / threshold > 0)
            {
                remaining -= threshold;
                output.Append(numeral);
            }
        }

        return output.ToString();
    }

    public static string ToRoman2(this int value)
    {
        Dictionary<int, string[]> data = new()
        {
            [1] = ["", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"],
            [10] = ["", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"],
            [100] = ["", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"],
            [1000] = ["", "M", "MM", "MMM",]
        };

        return value.ToString().Reverse()
            .Select((ch, chIndex) => data[(int)Math.Pow(10, chIndex)][(int)char.GetNumericValue(ch)])
            .Reverse()
            .Aggregate("", (a, b) => a + b);
    }

    public static string ToRoman3(this int value)
    {
        var remaining = value;
        var output = new StringBuilder();
        while (remaining > 0)
        {
            if (remaining >= 1000)
            {
                remaining -= 1000;
                output.Append("M");
            }
            else if (remaining >= 900)
            {
                remaining -= 900;
                output.Append("CM");
            }
            else if (remaining >= 500)
            {
                remaining -= 500;
                output.Append("D");
            }
            else if (remaining >= 400)
            {
                remaining -= 400;
                output.Append("CD");
            }
            else if (remaining >= 100)
            {
                remaining -= 100;
                output.Append("C");
            }
            else if (remaining >= 90)
            {
                remaining -= 90;
                output.Append("XC");
            }
            else if (remaining >= 50)
            {
                remaining -= 50;
                output.Append("L");
            }
            else if (remaining >= 40)
            {
                remaining -= 40;
                output.Append("XL");
            }
            else if (remaining >= 10)
            {
                remaining -= 10;
                output.Append("X");
            }
            else if (remaining == 9)
            {
                remaining -= 9;
                output.Append("IX");
            }
            else if (remaining >= 5)
            {
                remaining -= 5;
                output.Append("V");
            }
            else if (remaining == 4)
            {
                remaining -= 4;
                output.Append("IV");
            }
            else if (remaining >= 1)
            {
                remaining -= 1;
                output.Append("I");
            }
        }
        return output.ToString();
    }
}