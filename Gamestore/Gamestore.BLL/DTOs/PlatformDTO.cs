// <copyright file="PlatformDTO.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.BLL.DTOs;

/// <inheritdoc cref="PlatformDTO" />
public class PlatformDTO
{
    /// <inheritdoc cref="Id" />
    public int Id { get; set; }

    /// <inheritdoc cref="Type" />
    public string Type { get; set; } = null!;
}