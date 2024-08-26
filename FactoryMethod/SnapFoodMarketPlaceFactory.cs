namespace FactoryMethod
{
    public class SnapFoodMarketPlaceFactory : MarketplaceFactory
    {
        protected override IMarketplace CreateMarketplace()
        {
            return new SnapFoodMarketplace();
        }
    }
}
