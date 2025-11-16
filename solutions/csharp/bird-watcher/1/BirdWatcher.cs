class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)=>this.birdsPerDay = birdsPerDay;


    public static int[] LastWeek()=>new int[]{0,2,5,3,7,8,4};


    public int Today()=>birdsPerDay[birdsPerDay.Length-1];


    public void IncrementTodaysCount()=>birdsPerDay[birdsPerDay.Length-1]++;


    public bool HasDayWithoutBirds()
    {
        foreach (int i in birdsPerDay)
        {
            if (i == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int days = 0;
        for (int i =0; i < numberOfDays; i++)
        {
            days += birdsPerDay[i];
        }

        return days;
    }

    public int BusyDays()
    {
        int busyDays = 0;

        foreach (int b in birdsPerDay)
        {
            if (b >= 5)
                busyDays++;
        }

        return busyDays;
    }
}
