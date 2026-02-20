using System;
using System.Data;
using Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories;

public class BaseRepository : IDisposable
{
    protected readonly ApplicationDbContext _context;
    protected readonly IDbConnection _dbConnection;

    protected BaseRepository(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));

        _dbConnection = _context.Database.GetDbConnection();

        if (_dbConnection.State == ConnectionState.Closed)
            _dbConnection.Open();
    }

    public void Dispose()
    {
        _context?.Dispose();
        GC.SuppressFinalize(this);
    }
}
