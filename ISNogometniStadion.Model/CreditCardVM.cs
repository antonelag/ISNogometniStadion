namespace ISNogometniStadion.Model
{
    public class CreditCardVM
    {
        public string CreditCardNumber { get; set; }
        public long ExpYear { get; set; }
        public long ExpMonth { get; set; }
        public string CVV { get; set; }
        public decimal amount { get; set; }
    }

}
