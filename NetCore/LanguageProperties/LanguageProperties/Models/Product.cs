using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 

namespace LanguageProperties.Models
{
    public class Product
    {

        public Product(bool stock = true)
        {
            InStock = stock;
        }

        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Category { get; set; } = "WaterSports";
        public Product Related { get; set; }
        public bool InStock { get; }
        public bool NameBeginsWithS => Name?[0] == 'S';

        public static Product[] GetProducts()
        {
            Product kayak = new Product(false)
            {
                Name = "Kayak",
                Price = 275M,
                Category = "WaterCraft"
            };
            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null };
        }


    }
}