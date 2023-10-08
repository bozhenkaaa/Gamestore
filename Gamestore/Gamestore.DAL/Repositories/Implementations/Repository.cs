// <copyright file="Repository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.DAL.Repositories.Implementations;

using Gamestore.DAL.Data;
using Gamestore.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

/// <inheritdoc cref="Repository{T}" />
public class Repository<T> : IRepository<T>
    where T : class
{
    private readonly GamestoreDbContext context;
    private readonly DbSet<T> dbSet;

    /// <inheritdoc cref="Repository{T}" />
    public Repository(GamestoreDbContext context)
    {
        this.context = context;
        this.dbSet = this.context.Set<T>();
    }

    /// <inheritdoc cref="GetAllAsync" />
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await this.dbSet.ToListAsync();
    }

    /// <inheritdoc cref="DeleteAsync" />
    public async Task DeleteAsync(int id)
    {
        T? entity = await this.GetByIdAsync(id);
        if (entity != null)
        {
            this.dbSet.Remove(entity);
        }
    }

    /// <inheritdoc cref="GetByIdAsync" />
    public async Task<T?> GetByIdAsync(int id)
    {
        return await this.dbSet.FindAsync(id);
    }

    /// <inheritdoc cref="AddAsync" />
    public async Task AddAsync(T entity)
    {
        await this.dbSet.AddAsync(entity);
    }

    /// <inheritdoc cref="Update" />
    public void Update(T entity)
    {
        this.dbSet.Attach(entity);
        this.context.Entry(entity).State = EntityState.Modified;
    }
}