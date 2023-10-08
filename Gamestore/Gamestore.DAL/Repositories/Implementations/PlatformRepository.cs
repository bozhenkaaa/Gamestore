// <copyright file="PlatformRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.DAL.Repositories.Implementations;

using Gamestore.DAL.Data;
using Gamestore.DAL.Repositories.Interfaces;
using Gamestore.Models.Models;

/// <inheritdoc cref="PlatformRepository" />
public class PlatformRepository : Repository<Platform>, IPlatformRepository
{
    /// <inheritdoc cref="PlatformRepository" />
    public PlatformRepository(GamestoreDbContext context)
        : base(context)
    {
    }
}