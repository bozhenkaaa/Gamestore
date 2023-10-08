// <copyright file="GenreService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.BLL.Services.Implementations;

using Gamestore.BLL.DTOs;
using Gamestore.BLL.Services.Interfaces;

/// <inheritdoc cref="GenreService" />
public class GenreService : IGenreService
{
    /// <inheritdoc/>
    public Task<IEnumerable<GenreDTO>> GetGenresAsync()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task<GenreDTO> GetGenreAsync(int id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task AddGenreAsync(GenreDTO author)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task UpdateGenreAsync(GenreDTO author)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task DeleteGenreAsync(int id)
    {
        throw new NotImplementedException();
    }
}