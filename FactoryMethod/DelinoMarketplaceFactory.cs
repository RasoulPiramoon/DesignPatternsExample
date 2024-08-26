namespace FactoryMethod
{
    public class DelinoMarketplaceFactory : MarketplaceFactory
    {
        protected override IMarketplace CreateMarketplace()
        {
            return new DelinoMarketplace();
        }
    }
}
