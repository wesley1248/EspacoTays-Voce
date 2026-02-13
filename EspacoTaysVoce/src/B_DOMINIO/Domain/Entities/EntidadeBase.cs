using System;

namespace Domain.Entities;

public abstract class EntidadeBase
{
    public string Id { get; protected set; }
    public DateTime DataCadastro { get; protected set; }

    protected EntidadeBase()
    {
        Id = Guid.NewGuid().ToString();
        DataCadastro = DateTime.Now;
    }
}
