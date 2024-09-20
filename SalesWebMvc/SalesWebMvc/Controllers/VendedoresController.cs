using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class VendedoresController : Controller
    {

        private readonly ServicosDeVendas _servicoDeVenda;
        private readonly ServicosDeDepartamento _servicoDeDepartamento;

        public VendedoresController(ServicosDeVendas servicoDeVenda, ServicosDeDepartamento servicosDeDepartamento)
        {
            _servicoDeVenda = servicoDeVenda;
            _servicoDeDepartamento = servicosDeDepartamento;
		}

        public IActionResult Index()
        {
            var lista = _servicoDeVenda.FindAll();
            return View(lista);
        }

        public IActionResult Create()
        {
            var departamentos = _servicoDeDepartamento.FindAll();
            var viewModel = new VendedorFormViewModel
            {
                Departamentos = departamentos
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create2(Vendedor vendedor)
        {
            _servicoDeVenda.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete (int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = _servicoDeVenda.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete2(int id)
        {
            _servicoDeVenda.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details (int ? id)
        {
			if (id == null)
			{
				return NotFound();
			}

			var obj = _servicoDeVenda.FindById(id.Value);
			if (obj == null)
			{
				return NotFound();
			}

			return View(obj);
		}
    }
}
