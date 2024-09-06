using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
	public class ServicosDeDepartamento
	{
		private readonly SalesWebMvcContext _context;

		public ServicosDeDepartamento(SalesWebMvcContext context)
		{
			_context = context;
		}

		public List<Departamento> FindAll()
		{
			return _context.Departamento.OrderBy(x => x.Nome).ToList();
		}
	}
}
