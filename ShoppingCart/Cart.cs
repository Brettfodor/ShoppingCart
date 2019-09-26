using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart
{
    public class Cart
    {
        Item item = new Item();
        ShopApp shopApp = new ShopApp();
        public Cart()
        {

        }

        public void ShowCart()
        {
            int i = 1;
            int totalPrice = 0;
            foreach (Item item in shopApp.items)
            {
                
                int singleItemPrice = item.Price * item.Quantity;
                totalPrice += singleItemPrice;
                
                Console.WriteLine($"{i}. Item: {item.Name}, Price: {item.Price}, Quanitity: {item.Quantity} ");

                i++;
                

            }
            Console.WriteLine($" Total Price {totalPrice}");
        }

        public void AddItemToCart(Item item)

        {
            shopApp.items.Add(item);
        }




        public void RemoveSelectedItem(Item selectedItem)
        {
            shopApp.items.Remove(selectedItem);
            Console.WriteLine($"{selectedItem.Name} has been removed from your Cart");
        }

        public Item SelectItem(ShopApp shopApp)
        {
            
            Console.WriteLine("Please Choose the number of the item you would like to remove.");

            ShowCart();
            int userInput = Convert.ToInt32(Console.ReadLine());

            Item selectedItem = shopApp.items[userInput - 1];


            return selectedItem;

        }

    }
}