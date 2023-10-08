// <copyright file="UnitOfWork.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.DAL.UnitOfWork.Implementations;

using Gamestore.DAL.Data;
using Gamestore.DAL.Repositories.Implementations;
using Gamestore.DAL.Repositories.Interfaces;
using Gamestore.DAL.UnitOfWork.Interfaces;
using Gamestore.Models.Models;

/// <inheritdoc cref="IUnitOfWork" />
public class UnitOfWork : IUnitOfWork
{
    /// <inheritdoc cref="GamestoreDbContext" />
    private readonly GamestoreDbContext dbContext;

    /// <inheritdoc cref="bool" />
    private bool disposed = false;

    /// <inheritdoc cref="UnitOfWork" />
    public UnitOfWork(GamestoreDbContext dbContext)
    {
        this.dbContext = dbContext;
        this.Games = new GameRepository(this.dbContext);
        this.Genres = new GenreRepository(this.dbContext);
        this.Platforms = new PlatformRepository(this.dbContext);
    }

    /// <inheritdoc cref="IRepository{TEntity}" />
    public IRepository<Game> Games { get; private set; }

    /// <inheritdoc cref="IRepository{TEntity}" />
    public IRepository<Genre> Genres { get; private set; }

    /// <inheritdoc cref="IRepository{TEntity}" />
    public IRepository<Platform> Platforms { get; private set; }

    /// <inheritdoc cref="Task" />
    public async Task<int> SaveChangesAsync()
    {
        return await this.dbContext.SaveChangesAsync();
    }

    /// <inheritdoc cref="Void" />
    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <inheritdoc cref="Void" />
    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                this.dbContext.Dispose();
            }
        }

        this.disposed = true;
    }
}