using MySecondNiceBlazorApp.Models;
using System.Collections.Concurrent;

namespace MySecondNiceBlazorApp.Pages
{
    public partial class CartPage
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
            //
            _purchases = cart.getPurchases();

        }
      
        List<Product> _purchases;
       

    }
}
