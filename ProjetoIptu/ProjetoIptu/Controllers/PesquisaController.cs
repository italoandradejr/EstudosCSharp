using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProjetoIptu.Models;

namespace ProjetoIptu.Controllers
{
    public class PesquisaController : Controller
    {
        private string _connectionString = "Server=SUPORTE6\\SQLEXPRESS;Database=TESTE_IPTU;Integrated Security=True";

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Resultado(PesquisaViewModel model)
        //{
        //    List<PesquisaViewModel> resultados = new List<PesquisaViewModel>();

        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    {
        //        connection.Open();

        //        // Construir a consulta SQL dinâmica
               
                
        //    }
        //}
    }
}
