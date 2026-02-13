using System;
using Domain.Exceptions;

namespace Domain.Entities;

public class Produto : EntidadeBase
{
    public string Descricao { get; protected set; }
    public Decimal Preco { get; protected set; }
    public int Quantidade { get; protected set; }
    public bool Ativo { get; protected set; }
    public string Imagem { get; protected set; }
    public string Tamanho { get; protected set; }

    public Produto()
    {
        Descricao = string.Empty;
        Preco = 0;
        Quantidade = 0;
        Ativo = true;
        Imagem = string.Empty;
        Tamanho = string.Empty;
    }

    private void ValidarDominio(string descricao, decimal preco, int quantidade, string tamanho)
    {
        DomainException.When(string.IsNullOrWhiteSpace(descricao), "Descrição inválida.");
        DomainException.When(preco <= 0, "Preço deve ser maior que zero.");
        DomainException.When(quantidade < 0, "Quantidade não pode ser negativa.");
        DomainException.When(string.IsNullOrWhiteSpace(tamanho), "Tamanho é obrigatório.");
    }

    private void ValidarPreco(decimal preco)
    {
        DomainException.When(preco <= 0, "Preço deve ser maior que zero.");
    }

    private void ValidarDescricao(string descricao)
    {
        DomainException.When(string.IsNullOrWhiteSpace(descricao), "Descrição inválida.");
    }

    private void ValidarQuantidade(int quantidade)
    {
        DomainException.When(quantidade < 0, "Quantidade não pode ser negativa.");
    }

    private void ValidarTamanho(string tamanho)
    {
        DomainException.When(string.IsNullOrWhiteSpace(tamanho), "Tamanho é obrigatório.");
    }

    public void Desativar() => Ativo = false;

    public void NewProduto(string descricao, decimal preco, int quantidade, string tamanho)
    {
        ValidarDominio(descricao, preco, quantidade, tamanho);
        this.Descricao = descricao;
        this.Preco = preco;
        this.Quantidade = quantidade;
        this.Tamanho = tamanho;
    }

    public void EditarDescricao(string descricao)
    {
        ValidarDescricao(descricao);
        this.Descricao = descricao;
    }

    public void EditarPreco(decimal preco)
    {
        ValidarPreco(preco);
        this.Preco = preco;
    }

    public void EditarQuantidade(int quantidade)
    {
        ValidarQuantidade(quantidade);
        this.Quantidade = quantidade;
    }

    public void EditarTamanho(string tamanho)
    {
        ValidarTamanho(tamanho);
        this.Tamanho = tamanho;
    }

}
