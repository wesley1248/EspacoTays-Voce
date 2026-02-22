using System;
using Domain.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Domain.Services;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _ProdutoRepository;

    public ProdutoService(IProdutoRepository produtoRepository)
    {
        _ProdutoRepository = produtoRepository;
    }

    public async Task NewProduto(Produto produto)
    {
        await _ProdutoRepository.AdicionarProdutoAsync(produto);
    }

    public async Task ConsultarProduto(string id)
    {
        await _ProdutoRepository.ObterProdPorIdAsync(id);
    }

    // public async Task ObterTodosPaginado()
    // {

    // }

    // public async Task DeleteProduto(string id)
    // {

    // }

    // public async Task EditProduto(Produto produto)
    // {

    // }
}
