public static class LineUp
{
    public static string Format(string name, int number)
    {
        int lastDigit = number % 10;
        int lastTwoDigit = number % 100;
        string suffix;
        if (lastDigit == 1 && !(lastTwoDigit == 11))
            suffix = "st";
        else if (lastDigit == 2 && !(lastTwoDigit == 12))
            suffix = "nd";
        else if (lastDigit == 3 && !(lastTwoDigit == 13))
            suffix = "rd";
        else
            suffix = "th";

        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
    }
}
