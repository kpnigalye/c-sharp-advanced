using System;

namespace c_sharp_delegates
{
    public class CartHelper
    {
        public static void NotifyUser(string message)
        {
            Console.WriteLine(message);
        }

        public static void ExecuteCarCommands()
        {
            "Shopping Cart App".PrintHeader('=');
            "Products Listing".PrintHeader();

            Console.WriteLine("=> Enter 0 to Exit\n");

            ProductListing.GetProducts();
            int userChoice = -1;
            ShoppingCart cart = new ShoppingCart();

            while (userChoice != 0)
            {
                Console.Write("\nEnter Your Choice: ");
                try
                {
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    switch (userChoice)
                    {
                        case 101:
                            cart.AddToCart(userChoice, NotifyUser);
                            break;
                        case 102:
                            cart.AddToCart(userChoice, NotifyUser);
                            break;
                        case 103:
                            cart.AddToCart(userChoice, NotifyUser);
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Choice");
                }
            }

            Console.Write("\nReady to checkout? (Y/N) ");
            string readyToCheckout = Console.ReadLine();

            if (readyToCheckout.ToUpper() == "Y")
            {
                Console.Write("\nAre you a student? (Y/N) ");
                string areYouStudent = Console.ReadLine();
                if (areYouStudent.ToUpper() == "Y")
                    cart.Checkout(NotifyUser, (total) => total - 2000);
                else
                    cart.Checkout(NotifyUser, (total) => total - 1000);     // passing Anonymous method as an argument

                cart.DispatchProducts(NotifyUser);
            }
            else
                cart.EmptyCart(NotifyUser);

            Console.ReadLine();
        }
    }
}
