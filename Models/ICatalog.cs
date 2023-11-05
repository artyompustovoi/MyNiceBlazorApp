using System.Collections.Concurrent;

namespace MySecondNiceBlazorApp.Models
{
    public interface ICatalog
    {
        public List<Product> GetProducts();
        public void CreateProduct(Product product);
        public Product GetProductById(Guid guid);
        //public void DeleteProduct(Guid guid);
        //public void EditProduct(Guid guid, string newName, decimal newPrice);
    }
}
