using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class Item
    {
        
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }


        public Item(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public Item()
        {

        }
    }
}