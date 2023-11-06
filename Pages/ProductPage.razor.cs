using Microsoft.AspNetCore.Components;
using MySecondNiceBlazorApp.Models;
using System.Collections.Concurrent;

namespace MySecondNiceBlazorApp.Pages
{
    public partial class ProductPage
    {
        [Parameter]
        public Guid ProductId { get; set; }
        private Product _product { get; set; }
        

  
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _product = catalog.GetProductById(ProductId);
            imageSource = $"ProductImages/{_product.Name}.jpg";
        }

    }
}

