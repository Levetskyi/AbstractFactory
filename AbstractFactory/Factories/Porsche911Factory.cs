public class Porsche911Factory : IPorscheFactory
{
    public ICar CreateCar()
    {
        return new Porsche911();
    }

    public IColor CreateColor()
    {
        return new RedColor();
    }

    public IWheels CreateWheels()
    {
        return new Porsche911Wheels();
    }
}