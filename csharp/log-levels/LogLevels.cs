using System.Reflection.Metadata.Ecma335;

static class LogLine
{
    public static string Message(string logLine)
    {
        int colonIndex = logLine.IndexOf(':');
        return logLine[(colonIndex + 1)..].Trim();
    }

    public static string LogLevel(string logLine)
    {
        int bracketIndex = logLine.IndexOf(']');
        return logLine[1..bracketIndex].ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
