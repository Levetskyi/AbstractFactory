namespace AbstractFactory.Client
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("Client: Configuring Porsche 911...");
            ConfigurationSummary(new Porsche911Factory());
            Console.WriteLine();

            Console.WriteLine("Client: Configuring Porsche Cayenne...");
            ConfigurationSummary(new PorscheCayenneFactory());
        }

        public void ConfigurationSummary(IPorscheFactory factory)
        {
            var car = factory.CreateCar();

            var color = factory.CreateColor();
            var wheels = factory.CreateWheels();

            var totalPrice = car.GetPriceInEUR() + color.GetPrice() + wheels.GetPrice();

            Console.WriteLine($"Client: Configured a {car.GetType()} with {wheels.GetType()} and {color.GetType()}");
            Console.WriteLine($"Total Price: {totalPrice:C}");
        }
    }
}