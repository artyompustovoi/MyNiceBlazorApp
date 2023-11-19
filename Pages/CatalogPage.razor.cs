using NiceBikeShopBlazorFrontend.Models;
using System.Collections.Concurrent;

namespace NiceBikeShopBlazorFrontend.Pages
{
    public partial class CatalogPage
    {
        List<Product> _products = new List<Product>();


        protected override void OnInitialized()
        {
            base.OnInitialized();

            _products = catalog.GetProducts();

        }
        private void OnSelectedValuesChanged(IEnumerable<string> values)
        {
            //костыльные костыли
            int[] selectedCategories = new int[values.Count()];
            int counter = 0;

            foreach (var item in values.ToList())
            {
                foreach (var c in categories)
                {
                    if (c.CategoryName == item)
                    {
                        selectedCategories[counter] = c.CategoryId;
                        counter++;
                    }
                }

            }
            prod.Clear();
            foreach (var product in _products)
            {
                foreach (var category in selectedCategories)
                {
                    if (product.categoryId == category)
                        prod.Add(product);


                }

            }
        }

        IEnumerable<Categories> categories = new List<Categories>()
    {
        new Categories() {CategoryId = 1, CategoryName = "Шоссейные"},
        new Categories() {CategoryId = 2, CategoryName = "Горные"},
        new Categories() {CategoryId = 3, CategoryName = "Детские"}

    };


        public class Categories
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
            public override bool Equals(object o)
            {
                var other = o as Categories;
                return other?.CategoryId == CategoryId;
            }
            public override int GetHashCode() => CategoryId.GetHashCode();
            public override string ToString()
            {
                return CategoryName;
            }
        }

        List<Product> prod = new();


    }


}
