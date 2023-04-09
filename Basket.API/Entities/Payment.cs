namespace Basket.API.Entities
{
    public class Payment
    {
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string Expiration { get; set; }
        public string CVV { get; set; }
        public Method PaymentMethod { get; set; }

        public enum Method
        {
            None,
            Debit,
            Credit
        }
    }
}
