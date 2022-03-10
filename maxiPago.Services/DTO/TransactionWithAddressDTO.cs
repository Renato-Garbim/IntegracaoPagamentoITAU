namespace maxiPago.Services.DTO
{
    public class TransactionWithAddressDTO
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
        public string BillingName { get; set; }
        public string BillingAddress { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPhone { get; set; }
        public string BillingEmail { get; set; }
        public string ShippingName { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingPhone { get; set; }
        public string ShippingEmail { get; set; }
        public string FraudCheck { get; set; }
        public string SoftDescriptor { get; set; }
        public decimal? IataFee { get; set; }
    }
}
