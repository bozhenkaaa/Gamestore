// <copyright file="GenreRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.DAL.Repositories.Implementations;

using Gamestore.DAL.Data;
using Gamestore.DAL.Repositories.Interfaces;
using Gamestore.Models.Models;

/// <inheritdoc cref="GenreRepository" />
public class GenreRepository : Repository<Genre>, IGenreRepository
{
    /// <inheritdoc cref="GenreRepository" />
    public GenreRepository(GamestoreDbContext context)
        : base(context)
    {
    }
}