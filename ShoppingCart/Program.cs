using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopApp shopApp = new ShopApp();
            Item item = new Item();
            Cart cart = new Cart();
            bool shopping = false;

            Console.WriteLine("Please type '1' to begin shopping");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            if (userchoice == 1)
            {
                do
                {
                    //Console.WriteLine("To go to Checkout, enter 'c");
                    Console.WriteLine("Please enter the name of the item");
                    string name = Console.ReadLine();

                    Console.WriteLine("Please enter the price of the item");
                    int price = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter the quantity of the item");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    item = new Item(name, price, quantity);
                    cart.AddItemToCart(item);
                    cart.ShowCart();

                    Console.WriteLine("Do you want to keep shopping?  If yes type: 'y'. if no type: 'n'");
                    string userInput = Console.ReadLine();

                    if (userInput == "y")
                    {
                        shopping = true;
                    }
                    else shopping = false;
                } while (shopping);


            }
        }
    }
}