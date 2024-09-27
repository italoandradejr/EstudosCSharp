using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;
using SalesWebMvc.Services.Exceptions;
using System.Data;
using System.Diagnostics;

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
        public IActionResult Create(Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {
				var departamentos = _servicoDeDepartamento.FindAll();
				var viewModel = new VendedorFormViewModel { Vendedor = vendedor, Departamentos = departamentos };
				return View(viewModel);
			}
            _servicoDeVenda.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = _servicoDeVenda.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
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

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = _servicoDeVenda.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecidos" });
            }

            var obj = _servicoDeVenda.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            List<Departamento> departamentos = _servicoDeDepartamento.FindAll();
            VendedorFormViewModel viewModel = new VendedorFormViewModel { Vendedor = obj, Departamentos = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Vendedor vendedor)
        {
			if (!ModelState.IsValid)
			{
                var departamentos = _servicoDeDepartamento.FindAll();
                var viewModel = new VendedorFormViewModel { Vendedor = vendedor, Departamentos = departamentos };
				return View(viewModel);
			}
			if (id != vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não Correspondem" });
            }

            try
            {
                _servicoDeVenda.Update(vendedor);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
