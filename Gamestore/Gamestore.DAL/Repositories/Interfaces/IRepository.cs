// <copyright file="IRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.DAL.Repositories.Interfaces;

/// <inheritdoc cref="Interfaces" />
public interface IRepository<TEntity>
    where TEntity : class
{
    /// <inheritdoc cref="Task" />
    Task AddAsync(TEntity entity);

    /// <inheritdoc cref="Void" />
    void Update(TEntity entity);

    /// <inheritdoc cref="Task" />
    Task DeleteAsync(int id);

    /// <inheritdoc cref="Task" />
    Task<TEntity?> GetByIdAsync(int id);

    /// <inheritdoc cref="Task" />
    Task<IEnumerable<TEntity>> GetAllAsync();
}