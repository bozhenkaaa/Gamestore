// <copyright file="Game.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.Models.Models;

using System.ComponentModel.DataAnnotations;

/// <inheritdoc cref="Game" />
public class Game
{
    /// <inheritdoc cref="Id" />
    public int Id { get; set; }

    /// <inheritdoc cref="GameAlias" />
    [Required]
    public string GameAlias { get; set; } = null!;

    /// <inheritdoc cref="Name" />
    [Required]
    public string Name { get; set; } = null!;

    /// <inheritdoc cref="Description" />
    public string Description { get; set; } = null!;

    /// <inheritdoc cref="GenreId" />
    public int? GenreId { get; set; }

    /// <inheritdoc cref="Genre" />
    public Genre Genre { get; set; } = null!;

    /// <inheritdoc cref="PlatformId" />
    public int? PlatformId { get; set; }

    /// <inheritdoc cref="Platform" />
    public Platform Platform { get; set; } = null!;
}
