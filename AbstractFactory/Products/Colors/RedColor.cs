public class RedColor : IColor
{
    private readonly string _type = "Red Color";
    private readonly int _price = 2000;

    public decimal GetPrice()
    {
        return _price;
    }

    string IColor.GetType()
    {
        return _type;
    }
}