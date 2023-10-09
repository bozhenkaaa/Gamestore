// <copyright file="IPlatformService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.BLL.Services.Interfaces;

using Gamestore.BLL.DTOs;
using Gamestore.Models.Models;

/// <inheritdoc cref="IPlatformService" />
public interface IPlatformService
{
    /// <inheritdoc cref="GetPlatformsAsync" />
    Task<IEnumerable<Platform>> GetPlatformsAsync();

    /// <inheritdoc cref="GetPlatformAsync" />
    Task<PlatformDTO> GetPlatformAsync(int id);

    /// <inheritdoc cref="AddPlatformAsync" />
    Task AddPlatformAsync(PlatformDTO author);

    /// <inheritdoc cref="UpdatePlatformAsync" />
    Task UpdatePlatformAsync(PlatformDTO author);

    /// <inheritdoc cref="DeletePlatformAsync" />
    Task DeletePlatformAsync(int id);
}