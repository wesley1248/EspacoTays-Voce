using System;
using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface IProdutoRepository
{
    Task<Produto?> ObterProdPorIdAsync(string id);

    // Task<List<Produto>> ObterTodosPaginadoAsync();

    Task AdicionarProdutoAsync(Produto produto);

    // Task EditarProdutoAsync(Produto produto);

    // Task DeletarProdutoAsync(string id);
}



