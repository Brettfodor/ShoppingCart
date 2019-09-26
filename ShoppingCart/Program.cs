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
                while(shopping == false)
                {
                    int userInput;
                    string userChoice;
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
                    userChoice = Console.ReadLine();

                    if (userChoice == "y")
                    {
                        shopping = false;
                    }
                    else 
                
                    Console.WriteLine("Type 1 to checkout, 2 to remove and item, or 3 to exit the program");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == 1)
                    {
                        Console.WriteLine("Thank you for your purchase");
                    }
                    else if (userInput == 2)
                    {
                        cart.RemoveSelectedItem(cart.SelectItem(shopApp));
                    }
                    else
                        Environment.Exit(1);

                    

                }

                


            }
        }
    }
}