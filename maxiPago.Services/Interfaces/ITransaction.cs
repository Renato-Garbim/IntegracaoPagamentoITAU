using maxiPago.Services.DTO;
using MaxiPago.DataContract;

namespace maxiPago.Services.Interfaces
{
    public interface ITransaction
    {
        public ResponseBase Sale(TransactionDTO transactionDTO);

        public ResponseBase Sale(TransactionWithAddressDTO transactionWithAddressDTO);

        public ResponseBase Auth(TransactionDTO transactionDTO);

        public ResponseBase Auth(TransactionWithAddressDTO transactionWithAddressDTO);
    }
}
