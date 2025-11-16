class RemoteControlCar
{

    public int Distance {get; set;}
    public int Battery {get; set;} = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {Distance} meters";
        
    }

    public string BatteryDisplay()
    {
        if(Battery==0)
        {
            return $"Battery empty";
        }
        return $"Battery at {Battery}%";
    }

    public void Drive()
    {
        if(Battery==0)
        {
            BatteryDisplay();
            return;
        }
        Distance+=20;
        Battery-=1;
    }
}
