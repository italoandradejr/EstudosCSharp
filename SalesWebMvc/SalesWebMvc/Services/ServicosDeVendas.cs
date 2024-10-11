﻿using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Data;
using SalesWebMvc.Services.Exceptions;
//arquivo criado
namespace SalesWebMvc.Services
{
    public class ServicosDeVendas
    {
        private readonly SalesWebMvcContext _context;

        public ServicosDeVendas(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task <List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public async Task InsertAsync(Vendedor obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Vendedor> FindByIdAsync(int id)
        {
			return await _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Vendedor.FindAsync(id);
                _context.Vendedor.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Vendedor com vendas não pode ser deletados");
            }
        }

        public async Task UpdateAsync (Vendedor obj)
        {
            bool hasAny = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);

			if (!hasAny)
            {
                throw new DirectoryNotFoundException("Id Não Encontrado");
            }
            try
            {
				_context.Update(obj);
				await _context.SaveChangesAsync();
			}
            catch (DbUpdateConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
             
        }
    }
}
