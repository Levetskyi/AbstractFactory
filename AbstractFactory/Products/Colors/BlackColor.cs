public class BlackColor : IColor
{
    private readonly string _type = "Black Color";
    private readonly int _price = 1500;

    public decimal GetPrice()
    {
        return _price;
    }

    string IColor.GetType()
    {
        return _type;
    }
}