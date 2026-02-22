using System;
using Domain.Entities;

namespace Domain.Interfaces.Services;

public interface IProdutoService
{
    Task NewProduto(Produto produto);

    Task ConsultarProduto(string id);

    // Task ObterTodosPaginado();

    // Task DeleteProduto(string id);

    // Task EditProduto(Produto produto);
}



