﻿using Microsoft.AspNetCore.Mvc;
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

        public async Task <IActionResult> Index()
        {
            var lista = await _servicoDeVenda.FindAllAsync();
            return View(lista);
        }

        public async Task <IActionResult> Create()
        {
            var departamentos = await _servicoDeDepartamento.FindAllAsync();
            var viewModel = new VendedorFormViewModel
            {
                Departamentos = departamentos
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {
				var departamentos = await _servicoDeDepartamento.FindAllAsync();
				var viewModel = new VendedorFormViewModel { Vendedor = vendedor, Departamentos = departamentos };
				return View(viewModel);
			}
            await _servicoDeVenda.InsertAsync(vendedor);
            return RedirectToAction(nameof(Index));
        }

        public async Task <IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = await _servicoDeVenda.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Delete(int id)
        {
            try
            {
                await _servicoDeVenda.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
				return RedirectToAction(nameof(Error), new { message = e.Message });
			}
        }

        public async Task <IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = await _servicoDeVenda.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(obj);
        }

        public async Task <IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecidos" });
            }

            var obj = await _servicoDeVenda.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            List<Departamento> departamentos = await _servicoDeDepartamento.FindAllAsync();
            VendedorFormViewModel viewModel = new VendedorFormViewModel { Vendedor = obj, Departamentos = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Edit(int id, Vendedor vendedor)
        {
			if (!ModelState.IsValid)
			{
                var departamentos = await _servicoDeDepartamento.FindAllAsync();
                var viewModel = new VendedorFormViewModel { Vendedor = vendedor, Departamentos = departamentos };
				return View(viewModel);
			}
			if (id != vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não Correspondem" });
            }

            try
            {
                await _servicoDeVenda.UpdateAsync(vendedor);
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
