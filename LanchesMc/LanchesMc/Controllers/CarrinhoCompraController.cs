using LanchesMc.Models;
using LanchesMc.Repositories;
using LanchesMc.Repositories.Interfaces;
using LanchesMc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMc.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public CarrinhoCompraViewModel CarrinhoCompraVm { get; private set; }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var CarrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };
            return View(CarrinhoCompraVM);
        }
        public IActionResult AdicionarItemNoCarrinhoCompra (int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault (p => p.LancheId == lancheId);
            if(lancheSelecionado != null)
            {
                _carrinhoCompra.AdcionarAoCarrinho(lancheSelecionado);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCArrinhoCompra(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.LancheId== lancheId);

            if(lancheSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(lancheSelecionado);
            }
            return RedirectToAction("Index");
        }
    }
}
