using SalesWebMvc.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SalesWebMvc.Services
{
	public class SalesRecordService
	{
		public readonly SalesWebMvcContext _context;
		public SalesRecordService(SalesWebMvcContext context)
		{
			_context = context;
		}

		public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
		{
			var result = from obj in _context.SalesRecord select obj;
			if(minDate.HasValue)
			{
				result = result.Where(x => x.Date >= minDate.Value);
			}
			if(maxDate.HasValue)
			{
				result = result.Where(x => x.Date <= maxDate.Value);
			}
			return await result
				.Include(x => x.Vendedor)
				.Include(x => x.Vendeodor.Departamento)
				.OrderByDescending(x => x.Date)
				.ToListAsync();
		} 
	}
}
