namespace Basket.API.Entities
{
    public class BasketCheckout
    {
        public User UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public Address UserAddress { get; set; }
        public Payment UserPayment { get; set; }
    }
}
