using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_delegates
{
    public class ShoppingCart
    {
        public List<Product> SelectedProducts { get; set; } = new List<Product>();
        private int Total { get; set; } = 0;

        public delegate void ShoppingCartAlert(string message);

        private int MoveItemToShoppingCart(int code, ShoppingCartAlert cartAlert)
        {
            Product product = ProductListing.Products.First(a => a.Code == code);
            SelectedProducts.Add(product);

            cartAlert($"\n{product.Name} is Added to cart. ");
            
            return product.Price;
        }

        private void UpdateTotalAmount(int amount, ShoppingCartAlert cartAlert)
        {
            Total += amount;
            cartAlert($"\tPrice: {amount}\n\tTotal: {Total}");
        }

        public void AddToCart(int code, ShoppingCartAlert cartAlert)
        {
            int price = MoveItemToShoppingCart(code, cartAlert);
            UpdateTotalAmount(price, cartAlert);
        }

        public void Checkout(ShoppingCartAlert cartAlert)
        {
            cartAlert($"You paid {Total} using online payment system.");
        }

        public void EmptyCart(ShoppingCartAlert cartAlert)
        {
            SelectedProducts.Clear();
            Total = 0;
            cartAlert("Shopping Cart is empty.");
        }

        public void DispatchProducts(ShoppingCartAlert cartAlert)
        {
            cartAlert("Your Products will be dispatched soon.");
        }

    }
}
