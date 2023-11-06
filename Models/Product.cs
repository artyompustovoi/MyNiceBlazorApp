namespace MySecondNiceBlazorApp.Models
{
	public class Product
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int categoryId { get; set; }
		public decimal Price { get; set; }
		public Product(Guid guid, string name, decimal price, int categoryId)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
			}
			if (Price < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(Price));
			}
			this.Name = name;
			this.Price = price;
			this.Id = guid;
			this.categoryId = categoryId;
			var currentDateTime = DateTime.Now;
			if (currentDateTime.DayOfWeek == DayOfWeek.Sunday)
				this.Price = price * 0.5m;
			else
				this.Price = price;
		}
      
    }
}
