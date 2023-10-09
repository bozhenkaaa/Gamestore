// <copyright file="Genre.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

#nullable enable
namespace Gamestore.Models.Models;

using System.ComponentModel.DataAnnotations;

/// <inheritdoc cref="Genre" />
public class Genre
{
    /// <inheritdoc cref="Id" />
    public int Id { get; set; }

    /// <inheritdoc cref="Name" />
    [Required]
    public string Name { get; set; } = null!;

    /// <inheritdoc cref="ParentGenreId" />
    public int? ParentGenreId { get; set; }

    /// <inheritdoc cref="ParentGenre" />
    public Genre? ParentGenre { get; set; }

    /// <inheritdoc cref="SubGenres" />
    public ICollection<Genre> SubGenres { get; set; } = null!;

    /// <inheritdoc cref="Games" />
    public ICollection<Game> Games { get; set; } = null!;
}