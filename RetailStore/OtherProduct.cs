
namespace RetailStore
{
    public sealed class OtherProduct : Product
    {
        public OtherProduct(string name, IProductType productType = null) : base(name, productType?? new NonGrocery("NonGrocery"))
        {
            Price = 100;
            AvailableStock = 1001;
        }
    }
}
