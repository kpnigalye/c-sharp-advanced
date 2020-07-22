using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_delegates
{
    public class ShoppingCart
    {
        public List<Product> SelectedProducts { get; set; } = new List<Product>();
        private int Total { get; set; } = 0;

        //public delegate void ShoppingCartAlert(string message);

        //private int MoveItemToShoppingCart(int code, ShoppingCartAlert cartAlert)
        private int MoveItemToShoppingCart(int code, Action<string> cartAlert)
        {
            Product product = ProductListing.Products.First(a => a.Code == code);
            SelectedProducts.Add(product);

            cartAlert($"\n{product.Name} is Added to cart. ");

            return product.Price;
        }

        private void UpdateTotalAmount(int amount, Action<string> cartAlert)
        {
            Total += amount;
            cartAlert($"\tPrice: {amount}\n\tTotal: {Total}");
        }

        public void AddToCart(int code, Action<string> cartAlert)
        {
            int price = MoveItemToShoppingCart(code, cartAlert);
            UpdateTotalAmount(price, cartAlert);
        }

        public void Checkout(Action<string> cartAlert,
            Func<int, int> discountedPrice)
        {
            cartAlert("Applying discount..");
            cartAlert($"You paid { discountedPrice(Total)} using online payment system.");
        }

        public void EmptyCart(Action<string> cartAlert)
        {
            SelectedProducts.Clear();
            Total = 0;
            cartAlert("Shopping Cart is empty.");
        }

        public void DispatchProducts(Action<string> cartAlert)
        {
            cartAlert("Your Products will be dispatched soon.");
        }

    }
}
