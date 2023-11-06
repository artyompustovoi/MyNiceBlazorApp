namespace MySecondNiceBlazorApp.Models
{
    public interface ICart
    {
        public void addProductToCart(Product purchase);
        public void deletePurchase(Product product);
        public List<Product> getPurchases();
        

    }
}