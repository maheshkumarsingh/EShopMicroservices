namespace Basket.API.Models;

public class ShoppingCart
{
    public string UserName { get; set; } = default!;
    public List<ShoppingCartItem> Items { get; set; } = [];
    //public decimal TotalPrice
    //{
    //    get
    //    {
    //        return Items.Sum(i => i.Price * i.Quantity);
    //    }
    //}
    public decimal TotalPrice => Items!=null ? Items.Sum(item => item.Price * item.Quantity) : 0;
    public ShoppingCart()
    {
    }
    public ShoppingCart(string userName)
    {
        UserName = userName;
    }
}
