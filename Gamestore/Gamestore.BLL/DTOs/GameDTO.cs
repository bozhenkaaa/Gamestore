// <copyright file="GameDTO.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.BLL.DTOs;

/// <inheritdoc cref="GameDto" />
public class GameDto
{
    /// <inheritdoc cref="Id" />
    public int Id { get; set; }

    /// <inheritdoc cref="GameAlias" />
    public string? GameAlias { get; set; }

    /// <inheritdoc cref="Name" />
    public string Name { get; set; } = null!;

    /// <inheritdoc cref="Description" />
    public string Description { get; set; } = null!;

    /// <inheritdoc cref="GenreId" />
    public int? GenreId { get; set; }

    /// <inheritdoc cref="PlatformId" />
    public int? PlatformId { get; set; }
}