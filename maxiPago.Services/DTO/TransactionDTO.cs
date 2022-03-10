namespace maxiPago.Services.DTO
{
    public class TransactionDTO
    {
        public string MerchantId { get; set; }
        public string MerchantKey { get; set; }
        public string ReferenceNum { get; set; }
        public decimal ChargeTotal { get; set; }
        public string CreditCardNumber { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string CvvInd { get; set; }
        public string CvvNumber { get; set; }
        public string Authentication { get; set; }
        public string ProcessorId { get; set; }
        public string NumberOfInstallments { get; set; }
        public string ChargeInterest { get; set; }
        public string IpAddress { get; set; }
        public string CustomerIdExt { get; set; }
        public string CurrencyCode { get; set; }
        public string FraudCheck  { get; set; }
        public string SoftDescriptor { get; set; }
        public decimal? IataFee { get; set; }
    }
}
