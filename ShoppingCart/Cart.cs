using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class Cart
    {
        ShopApp shopApp = new ShopApp();
        public Cart()
        {

        }

        public void ShowCart()
        {
            int totalPrice = 0;
            foreach (Item item in shopApp.items)
            {
                int singleItemPrice = item.Price * item.Quantity;
                totalPrice += singleItemPrice;
                int i = 1;
                Console.WriteLine($"{i}.Item: {item.Name}, Price: {item.Price}, Quanitity: {item.Quantity} ");

                
                i++;

            }
            Console.WriteLine($" Total Price {totalPrice}");
        }
        public void AddItemToCart(Item item)

        {
            shopApp.items.Add(item);
        }
        public void CalculateCartCost()
        {
            foreach (Item item in shopApp.items)
            {
                Console.WriteLine();
            }
        }
    }
}