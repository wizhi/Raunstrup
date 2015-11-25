﻿namespace Raunstrup.Model
{
    public class OrderLine
    {
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }

        public OrderLine(Product item, int quantity)
        {
            Product = item;
            Quantity = quantity;
            UnitPrice = item.SalesPrice;
        }
        public Product GetProduct()
        {
            return Product;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public decimal GetTotal()
        {
            return UnitPrice * Quantity;
        }
    }
}