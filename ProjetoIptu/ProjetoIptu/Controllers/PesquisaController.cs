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



        [HttpPost]
        public IActionResult Resultado(PesquisaViewModel model)
        {
            List<PesquisaViewModel> resultados = new List<PesquisaViewModel>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Construir a consulta SQL dinâmica
                string query = "SELECT * FROM TESTESQL$ WHERE 1 = 1";

                if (!string.IsNullOrEmpty(model.Proprietario))
                {
                    query += " AND PROPRIETARIO LIKE @Proprietario";
                }

                if (!string.IsNullOrEmpty(model.Grupo))
                {
                    query += " AND GRUPO LIKE @Grupo";
                }

                if (model.DataInicio != null && model.DataFim != null)
                {
                    query += " AND DATA_MOVIMENTO BETWEEN @DataInicio AND @DataFim";
                }
                else if (model.DataInicio != null)
                {
                    query += " AND DATA_MOVIMENTO >= @DataInicio";
                }
                else if (model.DataFim != null)
                {
                    query += " AND DATA_MOVIMENTO <= @DataFim";
                }

                if (!string.IsNullOrEmpty(model.Empreendimento))
                {
                    query += " AND EMPREENDIMENTO LIKE @Empreendimento";
                }

                if (!string.IsNullOrEmpty(model.ContribuinteImovel))
                {
                    query += " AND ESPECIFI LIKE @ContribuinteImovel";
                }

                SqlCommand command = new SqlCommand(query, connection);

                // Adicionar parâmetros à consulta
                if (!string.IsNullOrEmpty(model.Proprietario))
                {
                    command.Parameters.AddWithValue("@Proprietario", "%" + model.Proprietario + "%");
                }

                if (!string.IsNullOrEmpty(model.Grupo))
                {
                    command.Parameters.AddWithValue("@Grupo", "%" + model.Grupo + "%");
                }

                if (model.DataInicio != null)
                {
                    command.Parameters.AddWithValue("@DataInicio", model.DataInicio);
                }

                if (model.DataFim != null)
                {
                    command.Parameters.AddWithValue("@DataFim", model.DataFim);
                }

                if (!string.IsNullOrEmpty(model.Empreendimento))
                {
                    command.Parameters.AddWithValue("@Empreendimento", "%" + model.Empreendimento + "%");
                }

                if (!string.IsNullOrEmpty(model.ContribuinteImovel))
                {
                    command.Parameters.AddWithValue("@ContribuinteImovel", "%" + model.ContribuinteImovel + "%");
                }

                // Executar a consulta
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Verificar se os campos retornados não são nulos antes de atribuí-los
                        string proprietario = reader["PROPRIETARIO"] != DBNull.Value ? reader["PROPRIETARIO"].ToString() : null;
                        string grupo = reader["GRUPO"] != DBNull.Value ? reader["GRUPO"].ToString() : null;


                        //////////LIDA COM A DATA///////////

                        DateTime? dataInicio = null;
                        object dataInicioObj = reader["DATA_MOVIMENTO"];
                        if (dataInicioObj != DBNull.Value)
                        {
                            if (DateTime.TryParse(dataInicioObj.ToString(), out DateTime dataInicioValue))
                            {
                                dataInicio = dataInicioValue;
                            }
                            //else
                            //{
                            //    // Lidar com a conversão mal-sucedida para DateTime, se necessário
                            //}
                        }

                        //////////LIDA COM A DATA///////////

                        //DateTime? dataInicio = reader["DATA_MOVIMENTO"] != DBNull.Value ? (DateTime?)reader["DATA_MOVIMENTO"] : null;
                        string empreendimento = reader["EMPREENDIMENTO"] != DBNull.Value ? reader["EMPREENDIMENTO"].ToString() : null;
                        string contribuinteImovel = reader["ESPECIFI"] != DBNull.Value ? reader["ESPECIFI"].ToString() : null;

                        // Mapear os resultados para o modelo
                        resultados.Add(new PesquisaViewModel
                        {
                            Proprietario = proprietario,
                            Grupo = grupo,
                            DataInicio = dataInicio,
                            Empreendimento = empreendimento,
                            ContribuinteImovel = contribuinteImovel
                        });
                    }
                }

            }

            return View(resultados);
        }




    }
}
