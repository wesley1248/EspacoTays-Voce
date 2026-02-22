using System;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;

namespace Infra.Repositories;

public class ProdutoRepository : BaseRepository, IProdutoRepository
{
    public ProdutoRepository(ApplicationDbContext context) : base(context) { }

    public async Task<Produto?> ObterProdPorIdAsync(string id)
    {
        return await _context.Produtos.FindAsync(id);
    }

    public async Task AdicionarProdutoAsync(Produto produto)
    {
        await _context.Produtos.AddAsync(produto);
    }
}
