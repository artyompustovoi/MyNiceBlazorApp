﻿using MySecondNiceBlazorApp.Models;
using System.Collections.Concurrent;

namespace MySecondNiceBlazorApp.Pages
{
    public partial class CatalogPage
    {
        List<Product> _products = new List<Product>();
        
        
        protected override void OnInitialized()
        {
            base.OnInitialized();
            //
            _products = catalog.GetProducts();
            
        }
    }
}
