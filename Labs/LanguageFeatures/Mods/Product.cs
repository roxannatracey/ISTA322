namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; } // automatic
        public decimal? Price { get; set; } // ? is initializing the value type 
        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Price = 275M
            };
            Product lifejacket = new Product   // this is an object initializer syntax with two propertie s
            {
                Name = "Lifejacket", // property one 
                Price = 48.95M // property two 
            };
            return new Product[] { kayak, lifejacket, null };
        }
    }
}