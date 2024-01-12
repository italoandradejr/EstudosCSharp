﻿using LanchesMac.Models;
using LanchesMc.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMc.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches{ get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }

    }
}
