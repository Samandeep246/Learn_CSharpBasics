static class LogLine
{
    public static string Message(string logLine)
    {
        string[] result = logLine.Split(':');
        return ($"{result[1]}").Trim();
    }

    public static string LogLevel(string logLine)
    {
       string[] result = logLine.Split(':');    
       return $"{result[0].Trim('[',']').ToLower()}";
    }

    public static string Reformat(string logLine)
    {
        string[] result = logLine.Split(':');
        return $"{result[1].Trim()} ({result[0].Trim('[',']').ToLower()})";
    }
}
