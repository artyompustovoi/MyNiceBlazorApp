namespace MySecondNiceBlazorApp.Models
{
    public class Cart : ICart
    {
        List<Product> _purchases = new();
        public void addProductToCart(Product purchase)
        {
            _purchases.Add(purchase);
        }

       

        public void deletePurchase(Guid id)
        {

            foreach (var purchase in _purchases)
            {
                if (purchase.Id == id)
                {
                    _purchases.Remove(purchase);
                }
            }

        }
        public List<Product> getPurchases()
        {
            return _purchases;
        }


    }
}
