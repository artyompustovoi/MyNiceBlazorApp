using System.Collections.Concurrent;

namespace MySecondNiceBlazorApp.Models
{
    public interface ICatalog
    {
        public ConcurrentBag<Product> GetProducts();
        //public Microsoft.AspNetCore.Mvc.IActionResult CreateProduct(Product product);
        public Product GetProductById(Guid guid);
        //public void DeleteProduct(Guid guid);
        //public void EditProduct(Guid guid, string newName, decimal newPrice);
    }
}
