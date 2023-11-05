using Microsoft.AspNetCore.Components;
using MySecondNiceBlazorApp.Models;

namespace MySecondNiceBlazorApp.Components
{
    public partial class ProductCard
    {
    
        //public Product product { get; set; }
        //private string? imageSource;
        
        string showCard(Guid id)
        {
            Product product = catalog.GetProductById(id);
            return product.Name + " " + product.Price + " ";
        }
    }
}
