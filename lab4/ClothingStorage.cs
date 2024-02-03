using System;
namespace lab4
{
    public static class ClothingStorage
    {

        public static List<Clothing> Clothes = new List<Clothing>
        {
            new Clothing("Adidas", "Shirt", 29.99, 50, true),
            new Clothing("Levi's", "Jeans", 49.99, 30, true),
            new Clothing("Calvin Klein", "Dress", 59.99, 20, true),
            new Clothing("Gucci", "Sweater", 39.99, 40, true),
            new Clothing("Nike", "Shorts", 19.99, 60, true),
            new Clothing("Stone Island", "Jacket", 79.99, 15, false),
            new Clothing("H&M", "Skirt", 34.99, 25, false),
            new Clothing("Puma", "Trousers", 44.99, 35, true),
            new Clothing("Ralph Lauren", "T-Shirt", 14.99, 70, true),
            new Clothing("Puma", "Hoodie", 54.99, 10, true)
        };
    }
}

