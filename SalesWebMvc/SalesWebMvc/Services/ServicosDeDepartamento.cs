using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
	public class ServicosDeDepartamento
	{
		private readonly SalesWebMvcContext _context;

		public ServicosDeDepartamento(SalesWebMvcContext context)
		{
			_context = context;
		}

		public async Task <List<Departamento>> FindAllAsync()
		{
			return await _context.Departamento.OrderBy(x => x.Nome).ToListAsync();
		}
	}
}
