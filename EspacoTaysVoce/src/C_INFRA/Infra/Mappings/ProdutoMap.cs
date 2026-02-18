using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings;

public class ProdutoMap : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("tb0001");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
            .IsRequired()
            .HasMaxLength(36)
            .HasColumnName("c01_id");

        builder.Property(p => p.DataCadastro)
            .IsRequired()
            .HasColumnType("timestamp with time zone")
            .HasColumnName("c01_data_cadastro");

        builder.Property(p => p.Descricao)
            .IsRequired()
            .HasMaxLength(1000)
            .HasColumnName("c01_descricao");

        builder.Property(p => p.Preco)
            .IsRequired()
            .HasColumnName("c01_preco")
            .HasColumnType("decimal(18,2)");

        builder.Property(p => p.Quantidade)
            .HasColumnName("c01_quantidade");

        builder.Property(p => p.Ativo)
            .HasColumnName("c01_ativo");

        // continuar o mapping
    }
}
