namespace SpaceRental.Core.Entities
{
    public class Payment
    {
        public string CardholderName { get; set; }
        public string CreditCardNumber{ get; set; }
        public string MonthExpires{ get; set; }
        public string YearExpires { get; set; }
        public string CardVerificationValue { get; set; }
    }
}