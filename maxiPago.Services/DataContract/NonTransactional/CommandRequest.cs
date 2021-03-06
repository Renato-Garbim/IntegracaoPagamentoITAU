using System;
using System.Xml.Serialization;

namespace MaxiPago.DataContract.NonTransactional
{

    [Serializable]
    [XmlRoot(ElementName = "request")]
    public class CommandRequest
    {

        [XmlElement("customerId")]
        public string CustomerId { get; set; }
        public bool ShouldSerializeCustomerId() { return !string.IsNullOrEmpty(CustomerId); }

        [XmlElement("customerIdExt")]
        public string CustomerIdExt { get; set; }
        public bool ShouldSerializeCustomerIdExt() { return !string.IsNullOrEmpty(CustomerIdExt); }

        [XmlElement("firstName")]
        public string FirstName { get; set; }
        public bool ShouldSerializeFirstName() { return !string.IsNullOrEmpty(FirstName); }

        [XmlElement("lastName")]
        public string LastName { get; set; }
        public bool ShouldSerializeLastName() { return !string.IsNullOrEmpty(LastName); }

        [XmlElement("address1")]
        public string Address1 { get; set; }
        public bool ShouldSerializeAddress1() { return !string.IsNullOrEmpty(Address1); }

        [XmlElement("address2")]
        public string Address2 { get; set; }
        public bool ShouldSerializeAddress2() { return !string.IsNullOrEmpty(Address2); }

        [XmlElement("city")]
        public string City { get; set; }
        public bool ShouldSerializeCity() { return !string.IsNullOrEmpty(City); }

        [XmlElement("state")]
        public string State { get; set; }
        public bool ShouldSerializeState() { return !string.IsNullOrEmpty(State); }

        [XmlElement("zip")]
        public string Zip { get; set; }
        public bool ShouldSerializeZip() { return !string.IsNullOrEmpty(Zip); }

        [XmlElement("phone")]
        public string Phone { get; set; }
        public bool ShouldSerializePhone() { return !string.IsNullOrEmpty(Phone); }

        [XmlElement("email")]
        public string Email { get; set; }
        public bool ShouldSerializeEmail() { return !string.IsNullOrEmpty(Email); }

        [XmlElement("dob")]
        public string Dob { get; set; }
        public bool ShouldSerializeDob() { return !string.IsNullOrEmpty(Dob); }

        [XmlElement("ssn")]
        public string Ssn { get; set; }
        public bool ShouldSerializeSsn() { return !string.IsNullOrEmpty(CustomerIdExt); }

        [XmlElement("sex")]
        public string Sex { get; set; }
        public bool ShouldSerializeSex() { return !string.IsNullOrEmpty(CustomerIdExt); }

        [XmlElement("creditCardNumber")]
        public string CreditCardNumber { get; set; }
        public bool ShouldSerializeCreditCardNumber() { return !string.IsNullOrEmpty(CreditCardNumber); }

        [XmlElement("expirationMonth")]
        public string ExpirationMonth { get; set; }
        public bool ShouldSerializeExpirationMonth() { return !string.IsNullOrEmpty(ExpirationMonth); }

        [XmlElement("expirationYear")]
        public string ExpirationYear { get; set; }
        public bool ShouldSerializeExpirationYear() { return !string.IsNullOrEmpty(ExpirationYear); }

        [XmlElement("billingName")]
        public string BillingName { get; set; }
        public bool ShouldSerializeBillingName() { return !string.IsNullOrEmpty(BillingName); }

        [XmlElement("billingAddress1")]
        public string BillingAddress1 { get; set; }
        public bool ShouldSerializeBillingAddress1() { return !string.IsNullOrEmpty(BillingAddress1); }

        [XmlElement("billingAddress2")]
        public string BillingAddress2 { get; set; }
        public bool ShouldSerializeBillingAddress2() { return !string.IsNullOrEmpty(BillingAddress2); }

        [XmlElement("billingCity")]
        public string BillingCity { get; set; }
        public bool ShouldSerializeBillingCity() { return !string.IsNullOrEmpty(BillingCity); }

        [XmlElement("billingState")]
        public string BillingState { get; set; }
        public bool ShouldSerializeBillingState() { return !string.IsNullOrEmpty(BillingState); }

        [XmlElement("billingZip")]
        public string BillingZip { get; set; }
        public bool ShouldSerializeBillingZip() { return !string.IsNullOrEmpty(BillingZip); }

        [XmlElement("billingCountry")]
        public string BillingCountry { get; set; }
        public bool ShouldSerializeBillingCountry() { return !string.IsNullOrEmpty(BillingCountry); }

        [XmlElement("billingPhone")]
        public string BillingPhone { get; set; }
        public bool ShouldSerializeBillingPhone() { return !string.IsNullOrEmpty(BillingPhone); }

        [XmlElement("billingEmail")]
        public string BillingEmail { get; set; }
        public bool ShouldSerializeBillingEmail() { return !string.IsNullOrEmpty(BillingEmail); }

        [XmlElement("orderID")]
        public string OrderID { get; set; }
        public bool ShouldSerializeOrderID() { return !string.IsNullOrEmpty(OrderID); }

        [XmlElement("token")]
        public string Token { get; set; }
        public bool ShouldSerializeToken() { return !string.IsNullOrEmpty(Token); }

        [XmlElement("onFileEndDate")]
        public string OnFileEndDate { get; set; }
        public bool ShouldSerializeOnFileEndDate() { return !string.IsNullOrEmpty(OnFileEndDate); }

        [XmlElement("onFilePermissions")]
        public string OnFilePermission { get; set; }
        public bool ShouldSerializeOnFilePermission() { return !string.IsNullOrEmpty(OnFilePermission); }

        [XmlElement("onFileComment")]
        public string OnFileComment { get; set; }
        public bool ShouldSerializeOnFileComment() { return !string.IsNullOrEmpty(OnFileComment); }

        [XmlElement("onFileMaxChargeAmount")]
        public string OnFileMaxChargeAmount { get; set; }
        public bool ShouldSerializeOnFileMaxChargeAmount() { return !string.IsNullOrEmpty(OnFileMaxChargeAmount); }

    }
}
