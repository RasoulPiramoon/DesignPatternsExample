namespace FactoryMethod
{
    public class TapsiFoodMarketplaceFactory : MarketplaceFactory
    {
        protected override IMarketplace CreateMarketplace()
        {
            return new TapsiFoodMarketplace();
        }
    }
}
