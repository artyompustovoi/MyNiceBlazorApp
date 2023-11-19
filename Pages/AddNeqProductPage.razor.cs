using NiceBikeShopBlazorFrontend.Models;

namespace NiceBikeShopBlazorFrontend.Pages
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
