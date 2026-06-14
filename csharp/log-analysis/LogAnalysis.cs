public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string logLine, string delimeter)
    {
        int delimeterIndex = logLine.IndexOf(delimeter);
        return logLine[(delimeterIndex + delimeter.Length) .. ];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string logLine, string startStr, string endChar)
    {
        int startIndex = logLine.IndexOf(startStr);
        int endIndex = logLine.IndexOf(endChar);
        return logLine[(startIndex + startStr.Length)..endIndex];
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string logLine)
    {
        return logLine.SubstringAfter(": ").Trim();
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string logLine)
    {
        return logLine.SubstringBetween("[", "]");
    }
}