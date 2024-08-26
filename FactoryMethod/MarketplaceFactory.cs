namespace FactoryMethod
{
    public abstract class MarketplaceFactory
    {
        protected abstract IMarketplace CreateMarketplace();
        public IMarketplace GetNewMarketplace()
        {
            IMarketplace marketplace = CreateMarketplace();
            return marketplace;
        }
    }
}
