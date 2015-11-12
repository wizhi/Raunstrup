﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raunstrup.Domain
{
    public class OrderLine
    {
        private LineItem item;
        private int quantity;
        private double unitPrice;

        public OrderLine(LineItem item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }
        public LineItem getLineItem()
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
