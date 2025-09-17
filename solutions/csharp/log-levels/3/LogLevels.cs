static class LogLine
{
    public static string Message(string logLine)
    {
        int messagePos = logLine.IndexOf(": ");
        string message = logLine.Substring(messagePos+2);

        
        
        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int logLinePos = logLine.IndexOf("]");
        string level = logLine.Substring(1,logLinePos-1);
        return level.ToLower();
    }

    public static string Reformat(string logLine)=> $"{LogLine.Message(logLine)} ({LogLine.LogLevel(logLine)})";

}
