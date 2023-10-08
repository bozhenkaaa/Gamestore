// <copyright file="IGenreService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.BLL.Services.Interfaces;

using Gamestore.BLL.DTOs;

/// <inheritdoc cref="IGenreService" />
public interface IGenreService
{
    /// <inheritdoc cref="GetGenresAsync" />
    Task<IEnumerable<GenreDTO>> GetGenresAsync();

    /// <inheritdoc cref="GetGenreAsync" />
    Task<GenreDTO> GetGenreAsync(int id);

    /// <inheritdoc cref="AddGenreAsync" />
    Task AddGenreAsync(GenreDTO author);

    /// <inheritdoc cref="UpdateGenreAsync" />
    Task UpdateGenreAsync(GenreDTO author);

    /// <inheritdoc cref="DeleteGenreAsync" />
    Task DeleteGenreAsync(int id);
}