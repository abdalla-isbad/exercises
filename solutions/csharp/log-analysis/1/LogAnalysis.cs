public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type

    public static string SubstringAfter(this string str,string delim){

        int index = str.IndexOf(delim);
        
        return str.Substring(index+ delim.Length);
    }

    public static string SubstringBetween(this string input, string start, string end)
    {
        int startIndex = input.IndexOf(start);
        int endIndex = input.IndexOf(end, startIndex);
        startIndex += start.Length;

        
        return input.Substring(startIndex,endIndex - startIndex);
    }


    public static string Message(this string input)=>input.SubstringAfter(": ");

    public static string LogLevel(this string input)=>input.Substring(1,input.IndexOf("]:")-1);
}