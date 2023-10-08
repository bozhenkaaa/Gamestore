// <copyright file="Platform.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.Models.Models;

using System.ComponentModel.DataAnnotations;

/// <inheritdoc cref="Platform" />
public class Platform
{
    /// <inheritdoc cref="Id" />
    public int Id { get; set; }

    /// <inheritdoc cref="Type" />
    [Required]
    public string Type { get; set; } = null!;

    /// <inheritdoc cref="Games" />
    public ICollection<Game> Games { get; set; } = null!;
}