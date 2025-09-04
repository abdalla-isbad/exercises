class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int x)
    {
        int y = this.ExpectedMinutesInOven();
        return y - x;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method

    public int PreparationTimeInMinutes(int layers)
    {
        return layers*2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int mins)
    {
        int prepTime = this.PreparationTimeInMinutes(layers);
        return prepTime + mins;
    }
}
