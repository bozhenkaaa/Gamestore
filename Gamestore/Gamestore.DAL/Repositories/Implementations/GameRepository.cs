// <copyright file="GameRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.DAL.Repositories.Implementations;

using Gamestore.DAL.Data;
using Gamestore.DAL.Repositories.Interfaces;
using Gamestore.Models.Models;

/// <inheritdoc cref="GameRepository" />
public class GameRepository : Repository<Game>, IGameRepository
{
    /// <inheritdoc cref="GameRepository" />
    public GameRepository(GamestoreDbContext context)
        : base(context)
    {
    }
}