using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_enum_composição.Entidades
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Product + ", " + " Quantity: " + Quantity + ", " + " Subtotal: " + "$" + SubTotal();
        }
    }
}
