// <copyright file="GenreDTO.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.BLL.DTOs;

/// <inheritdoc cref="GenreDTO" />
public class GenreDTO
{
    /// <inheritdoc cref="Id" />
    public int Id { get; set; }

    /// <inheritdoc cref="Name" />
    public string Name { get; set; } = null!;

    /// <inheritdoc cref="ParentGenreId" />
    public int? ParentGenreId { get; set; }
}