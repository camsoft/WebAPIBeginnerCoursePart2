namespace WebAPICourse.Models
{
    public class Product
    {
        /// <summary>
        /// Unique identifier for the product
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the product (e.g., Laptop, Mouse)
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Product price. Must be greater than zero.
        /// </summary>
        public decimal Price { get; set; }
    }
}
