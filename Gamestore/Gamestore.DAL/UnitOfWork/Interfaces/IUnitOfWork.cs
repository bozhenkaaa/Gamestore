// <copyright file="IUnitOfWork.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.DAL.UnitOfWork.Interfaces;

using Gamestore.DAL.Repositories.Interfaces;
using Gamestore.Models.Models;

/// <inheritdoc cref="Interfaces" />
public interface IUnitOfWork : IDisposable
{
    /// <inheritdoc cref="IRepository{TEntity}" />
    IRepository<Game> Games { get; }

    /// <inheritdoc cref="IRepository{TEntity}" />
    IRepository<Genre> Genres { get; }

    /// <inheritdoc cref="IRepository{TEntity}" />
    IRepository<Platform> Platforms { get; }

    /// <inheritdoc cref="Task" />
    Task<int> SaveChangesAsync();
}