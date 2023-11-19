using NiceBikeShopBackend.Data;
using NiceBikeShopBlazorFrontend.Models;
using Product = NiceBikeShopBackend.Data.Product;

namespace NiceBikeShopBlazorFrontend.Pages
{
    public partial class TMP
    {
        private IReadOnlyList<Product>? _purchases = null;
        private Product? _product;
        Guid _id = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6");
        protected override async Task OnInitializedAsync()
        {
            base.OnInitialized();
            //
            _purchases = await apiClient.GetProductsAsync();
            _product = await apiClient.GetProductByIdAsync(_id);

        }


    }
}
