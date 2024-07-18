public class PorscheCayenneFactory : IPorscheFactory
{
    public ICar CreateCar()
    {
        return new PorscheCayenne();
    }

    public IColor CreateColor()
    {
        return new BlackColor();
    }

    public IWheels CreateWheels()
    {
        return new PorscheCayenneWheels();
    }
}