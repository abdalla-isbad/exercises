static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        bool isTenAndFour = (speed>=1 && speed<=4);
        bool isFiveAndEight = (speed>=5 && speed <=8);
         if (isTenAndFour)
        {
            return 1.0;
        }
        else if (isFiveAndEight)
        {
            return 0.9;
        }

        else if (speed == 9)
        {
            return 0.8;
        }
        else if (speed == 10)
        {
            return 0.77;
        }
        else 
        {
            return 0;
        }
    }
    
    public static double ProductionRatePerHour(int speed)=>speed*SuccessRate(speed)*221;

    public static int WorkingItemsPerMinute(int speed)
    {
        int items = (int)(ProductionRatePerHour(speed) / 60);
        return items;
    }
}
