﻿using LanchesMc.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace LanchesMc.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            var lanches = _lancheRepository.Lanches;       
            return View(lanches);
        }
    }
}
