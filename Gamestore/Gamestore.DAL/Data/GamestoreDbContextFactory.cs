// <copyright file="GamestoreDbContextFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.DAL.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

/// <summary>
///    Factory for creating <see cref="GamestoreDbContext" />.
/// </summary>
public class GamestoreDbContextFactory : IDesignTimeDbContextFactory<GamestoreDbContext>
{
    /// <inheritdoc cref="GamestoreDbContext" />
    public GamestoreDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<GamestoreDbContext>();
        optionsBuilder.UseSqlServer("DefaultConnection");

        return new GamestoreDbContext(optionsBuilder.Options);
    }
}