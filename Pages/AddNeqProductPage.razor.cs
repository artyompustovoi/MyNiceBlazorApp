using MySecondNiceBlazorApp.Models;

namespace MySecondNiceBlazorApp.Pages
{
    public partial class AddNeqProductPage
    {
        void addProduct(Product p)
        {
            p.Id = Guid.NewGuid();
            catalog.CreateProduct(p);
        }
    }
}
