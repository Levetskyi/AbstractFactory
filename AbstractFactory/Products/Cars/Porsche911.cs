public class Porsche911 : ICar
{
    private readonly string _name = "Porsche 911";
    private readonly int _price = 80000;


    string ICar.GetType()
    {
        return _name;
    }

    public int GetPriceInEUR()
    {
        return _price;
    }
}