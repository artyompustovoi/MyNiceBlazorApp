using MySecondNiceBlazorApp.Models;
using System.Collections.Concurrent;

namespace MySecondNiceBlazorApp.Pages
{
    public partial class CatalogPage
    {
        ConcurrentBag<Product> _products = new ConcurrentBag<Product>();
        Guid Guid { get; set; }
        
        protected override void OnInitialized()
        {
            base.OnInitialized();
            //
            _products = catalog.GetProducts();
            
        }
    }
}
