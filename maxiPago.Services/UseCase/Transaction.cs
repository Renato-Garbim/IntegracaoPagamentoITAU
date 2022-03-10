using System.Threading;
using maxiPago.Services.DTO;
using maxiPago.Services.Interfaces;
using MaxiPago.DataContract;
using MaxiPago.DataContract.Transactional;
using MaxiPago.Gateway;

namespace maxiPago.Services.UseCase
{
    public class Transaction : ServiceBase, ITransaction
    {
        private TransactionRequest _request;

        public ResponseBase Auth(TransactionDTO transactionDTO)
        {
            FillRequestBase("auth", transactionDTO);

            return new Utils().SendRequest(_request, Environment);
        }

        public ResponseBase Auth(TransactionWithAddressDTO transactionWithAddressDTO)
        {
            TransactionDTO transactionDTO = new()
            {
                MerchantId = transactionWithAddressDTO.MerchantId,
                MerchantKey = transactionWithAddressDTO.MerchantKey,
                ReferenceNum = transactionWithAddressDTO.ReferenceNum,
                ChargeTotal = transactionWithAddressDTO.ChargeTotal,
                CreditCardNumber = transactionWithAddressDTO.CreditCardNumber,
                ExpMonth = transactionWithAddressDTO.ExpMonth,
                ExpYear = transactionWithAddressDTO.ExpYear,
                CvvInd = transactionWithAddressDTO.CvvInd,
                CvvNumber = transactionWithAddressDTO.CvvNumber,
                Authentication = transactionWithAddressDTO.Authentication,
                ProcessorId = transactionWithAddressDTO.ProcessorId,
                NumberOfInstallments = transactionWithAddressDTO.NumberOfInstallments,
                ChargeInterest = transactionWithAddressDTO.ChargeInterest,
                IpAddress = transactionWithAddressDTO.IpAddress,
                CustomerIdExt = transactionWithAddressDTO.CustomerIdExt,
                CurrencyCode = transactionWithAddressDTO.CurrencyCode,
                FraudCheck = transactionWithAddressDTO.FraudCheck,
                SoftDescriptor = transactionWithAddressDTO.SoftDescriptor,
                IataFee = transactionWithAddressDTO.IataFee
            };

            FillRequestBase("auth", transactionDTO);

            var auth = _request.Order.Auth;

            auth.Billing = new Billing
            {
                Address1 = transactionWithAddressDTO.BillingAddress,
                Address2 = transactionWithAddressDTO.BillingAddress2,
                City = transactionWithAddressDTO.BillingCity,
                Country = transactionWithAddressDTO.BillingCountry,
                Email = transactionWithAddressDTO.BillingEmail,
                Name = transactionWithAddressDTO.BillingName,
                Phone = transactionWithAddressDTO.BillingPhone,
                Postalcode = transactionWithAddressDTO.BillingPostalCode,
                State = transactionWithAddressDTO.BillingState
            };


            auth.Shipping = new Shipping
            {
                Address1 = transactionWithAddressDTO.ShippingAddress,
                Address2 = transactionWithAddressDTO.ShippingAddress2,
                City = transactionWithAddressDTO.ShippingCity,
                Country = transactionWithAddressDTO.ShippingCountry,
                Email = transactionWithAddressDTO.ShippingEmail,
                Name = transactionWithAddressDTO.ShippingName,
                Phone = transactionWithAddressDTO.ShippingPhone,
                Postalcode = transactionWithAddressDTO.ShippingPostalCode,
                State = transactionWithAddressDTO.ShippingState
            };


            return new Utils().SendRequest(_request, Environment);
        }

        public ResponseBase Sale(TransactionDTO transactionDTO)
        {
            FillRequestBase("sale", transactionDTO);

            return new Utils().SendRequest(_request, Environment);
        }

        public ResponseBase Sale(TransactionWithAddressDTO transactionWithAddressDTO)
        {
            TransactionDTO transactionDTO = new()
            {
                MerchantId = transactionWithAddressDTO.MerchantId,
                MerchantKey = transactionWithAddressDTO.MerchantKey,
                ReferenceNum = transactionWithAddressDTO.ReferenceNum,
                ChargeTotal = transactionWithAddressDTO.ChargeTotal,
                CreditCardNumber = transactionWithAddressDTO.CreditCardNumber,
                ExpMonth = transactionWithAddressDTO.ExpMonth,
                ExpYear = transactionWithAddressDTO.ExpYear,
                CvvInd = transactionWithAddressDTO.CvvInd,
                CvvNumber = transactionWithAddressDTO.CvvNumber,
                Authentication = transactionWithAddressDTO.Authentication,
                ProcessorId = transactionWithAddressDTO.ProcessorId,
                NumberOfInstallments = transactionWithAddressDTO.NumberOfInstallments,
                ChargeInterest = transactionWithAddressDTO.ChargeInterest,
                IpAddress = transactionWithAddressDTO.IpAddress,
                CustomerIdExt = transactionWithAddressDTO.CustomerIdExt,
                CurrencyCode = transactionWithAddressDTO.CurrencyCode,
                FraudCheck = transactionWithAddressDTO.FraudCheck,
                SoftDescriptor = transactionWithAddressDTO.SoftDescriptor,
                IataFee = transactionWithAddressDTO.IataFee
            };

            FillRequestBase("sale", transactionDTO);

            var sale = _request.Order.Sale;

            sale.Billing = new Billing
            {
                Address1 = transactionWithAddressDTO.BillingAddress,
                Address2 = transactionWithAddressDTO.BillingAddress2,
                City = transactionWithAddressDTO.BillingCity,
                Country = transactionWithAddressDTO.BillingCountry,
                Email = transactionWithAddressDTO.BillingEmail,
                Name = transactionWithAddressDTO.BillingName,
                Phone = transactionWithAddressDTO.BillingPhone,
                Postalcode = transactionWithAddressDTO.BillingPostalCode,
                State = transactionWithAddressDTO.BillingState
            };


            sale.Shipping = new Shipping
            {
                Address1 = transactionWithAddressDTO.BillingAddress,
                Address2 = transactionWithAddressDTO.BillingAddress2,
                City = transactionWithAddressDTO.BillingCity,
                Country = transactionWithAddressDTO.BillingCountry,
                Email = transactionWithAddressDTO.BillingEmail,
                Name = transactionWithAddressDTO.BillingName,
                Phone = transactionWithAddressDTO.BillingPhone,
                Postalcode = transactionWithAddressDTO.BillingPostalCode,
                State = transactionWithAddressDTO.BillingState
            };

            return new Utils().SendRequest(_request, Environment);
        }

        private void FillRequestBase(string operation, TransactionDTO transactionDTO)
        {

            _request = new TransactionRequest(transactionDTO.MerchantId, transactionDTO.MerchantKey);
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            var rBase = new RequestBase
            {
                ReferenceNum = transactionDTO.ReferenceNum,
                ProcessorId = transactionDTO.ProcessorId,
                Authentication = transactionDTO.Authentication,
                IpAddress = transactionDTO.IpAddress,
                CustomerIdExt = transactionDTO.CustomerIdExt,
                FraudCheck = transactionDTO.FraudCheck,
                Payment = new Payment
                {
                    ChargeTotal = transactionDTO.ChargeTotal,
                    CurrencyCode = transactionDTO.CurrencyCode,
                    SoftDescriptor = transactionDTO.SoftDescriptor,
                    IataFee = transactionDTO.IataFee
                }
            };

            rBase.TransactionDetail.PayType.CreditCard = new CreditCard
            {
                CvvInd = transactionDTO.CvvInd,
                CvvNumber = transactionDTO.CvvNumber,
                ExpMonth = transactionDTO.ExpMonth,
                ExpYear = transactionDTO.ExpYear,
                Number = transactionDTO.CreditCardNumber
            };

            if (string.IsNullOrEmpty(transactionDTO.NumberOfInstallments))
                transactionDTO.NumberOfInstallments = "0";

            var tranInstallments = int.Parse(transactionDTO.NumberOfInstallments);

            //Verifica se vai precisar criar o nó de parcelas e juros.
            if (!string.IsNullOrEmpty(transactionDTO.ChargeInterest) && tranInstallments > 1)
            {
                rBase.Payment.CreditInstallment = new CreditInstallment
                {
                    ChargeInterest = transactionDTO.ChargeInterest.ToUpper(),
                    NumberOfInstallments = transactionDTO.NumberOfInstallments
                };
            }

            if (operation.Equals("sale"))
                _request.Order.Sale = rBase;
            else if (operation.Equals("auth"))
                _request.Order.Auth = rBase;
        }
    }
}
