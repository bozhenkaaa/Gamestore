// <copyright file="PlatformService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.BLL.Services.Implementations;

using Gamestore.BLL.DTOs;
using Gamestore.BLL.Services.Interfaces;

/// <inheritdoc cref="PlatformService" />
public class PlatformService : IPlatformService
{
    /// <inheritdoc/>
    public Task<IEnumerable<PlatformDTO>> GetPlatformsAsync()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task<PlatformDTO> GetPlatformAsync(int id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task AddPlatformAsync(PlatformDTO author)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task UpdatePlatformAsync(PlatformDTO author)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task DeletePlatformAsync(int id)
    {
        throw new NotImplementedException();
    }
}