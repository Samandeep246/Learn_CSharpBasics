public static class LogAnalysis 
{
    public static String SubstringAfter(this String str, string del)
    {       
        int index = str.IndexOf(del);
        return str.Substring(index+del.Length);
    }
    public static String SubstringBetween(this String str, string del1, string del2)
    {     
        int lengthOfDel1=del1.Length;        
        int start = str.IndexOf(del1)+lengthOfDel1;
        int end = str.IndexOf(del2);
        return str.Substring(start, end-start);
    }
    public static String Message(this String str)
    {       
        int index = str.IndexOf(':')+1;
        return str.Substring(index).Trim();
    }
    public static String LogLevel(this String str)
    {       
        int start = str.IndexOf('[')+1;
        int end = str.IndexOf(']');
        return str.Substring(start, end-start);
    }
    // TODO: define the 'SubstringAfter()' extension method on the `string` type

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    
    // TODO: define the 'Message()' extension method on the `string` type

    // TODO: define the 'LogLevel()' extension method on the `string` type
}