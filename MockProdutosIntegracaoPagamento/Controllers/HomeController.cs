using System;
using System.Diagnostics;
using IBBA.Services.DTO;
using IBBA.Services.Interfaces;
using maxiPago.Services.DTO;
using maxiPago.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockProdutosIntegracaoPagamento.Models;
using MockProdutosIntegracaoPagamento.Models.Home;

namespace MockProdutosIntegracaoPagamento.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPixApiService _pixApiService;
        private readonly ITransaction _transaction;

        public HomeController(ILogger<HomeController> logger, IPixApiService pixApiService, ITransaction transaction)
        {
            _pixApiService = pixApiService;
            _transaction = transaction;
        }

        public PartialViewResult CarregarFormularioCompra()
        {
            var model = new ModalViewModel();

            var token = _pixApiService.GerarToken();

            var dados = PopularModelPix();

            var pedido = _pixApiService.GerarPedido(token.access_token, dados);

            model.QRCode = _pixApiService.ObterQRCodePixPor(pedido.Txid, token.access_token);

            return PartialView("ModalAssinatura", model);
        }

        public PartialViewResult CarregarFormularioCompraCartaoDeCredito()
        {
            return PartialView("ModalFormulario");
        }

        private static DadosEnvioPixDTO PopularModelPix()
        {
            var model = new DadosEnvioPixDTO
            {
                Calendario = new CalendarioDTO() { Expiracao = 50 },
                Chave = "10230480001960", //chave pix
                Devedor = new DevedorDTO
                {
                    Nome = "Renato Garbim",
                    Cpf = "12345678910"
                },
                Valor = new ValorDTO
                {
                    Original = 140
                }
            };

            return model;
        }

        public ActionResult EnviarDados(TransactionWithAddressDTO transactionDTO)
        {
            try
            {
                _transaction.Sale(transactionDTO);
            }
            catch (Exception)
            {
                throw;
            }

            return Ok();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
