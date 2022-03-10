using IBBA.Services.DTO.qrcode;
using maxiPago.Services.DTO;

namespace MockProdutosIntegracaoPagamento.Models.Home
{
    public class ModalViewModel
    {
        public PixQRCodeDTO QRCode { get; set; }
        public TransactionDTO TransactionDto { get; set; }

    }
}
