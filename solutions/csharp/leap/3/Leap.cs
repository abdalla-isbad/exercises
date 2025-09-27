public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool isIt = ((year % 100 != 0 && year % 4 == 0 )|| (year % 100 == 0 && year % 400 == 0));
        return isIt;
    }
}