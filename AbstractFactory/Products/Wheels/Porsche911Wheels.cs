public class Porsche911Wheels : IWheels
{
    private readonly string _type = "Porsche 911 Spider Wheels";
    private readonly int _price = 3000;
    public decimal GetPrice()
    {
        return _price;
    }

    string IWheels.GetType()
    {
        return _type;
    }
}