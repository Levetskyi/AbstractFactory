public class PorscheCayenneWheels : IWheels
{
    private readonly string _type = "Porsche Cayenne Spider Wheels";
    private readonly int _price = 2750;
    public decimal GetPrice()
    {
        return _price;
    }

    string IWheels.GetType()
    {
        return _type;
    }
}