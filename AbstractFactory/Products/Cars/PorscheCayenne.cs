public class PorscheCayenne : ICar
{
    private readonly string _name = "Porsche Cayenne";
    private readonly int _price = 60000;

    public int GetPriceInEUR()
    {
        return _price;
    }

    string ICar.GetType()
    {
        return _name;
    }
}