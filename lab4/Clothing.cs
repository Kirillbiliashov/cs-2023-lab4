using System;
namespace lab4
{
    public record class Clothing(
        string Brand,
        string Type,
        double Price,
        int Quantity,
        bool InStock);
}

