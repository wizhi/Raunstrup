﻿namespace Raunstrup.Core.Domain
{
    public class OrderLine
    {
        private Product item;
        private int quantity;
        private double unitPrice;

        public OrderLine(Product item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }
        public Product getLineItem()
        {
            return item;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public double getTotal()
        {
            return unitPrice * quantity; 
        }
    }
}
