namespace MySecondNiceBlazorApp.Models
{
    public interface ICart
    {
        public void addProductToCart(Product purchase);
        public void deletePurchase(Guid id);
        public List<Product> getPurchases();

    }
}