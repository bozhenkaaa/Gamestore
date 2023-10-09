// <copyright file="PlatformService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.BLL.Services.Implementations;

using Gamestore.BLL.DTOs;
using Gamestore.BLL.Services.Interfaces;
using Gamestore.DAL.Repositories.Interfaces;
using Gamestore.DAL.UnitOfWork.Interfaces;
using Gamestore.Models.Models;

/// <inheritdoc cref="PlatformService" />
public class PlatformService : IPlatformService
{
    private readonly IUnitOfWork unitOfWork;

    /// <inheritdoc cref="PlatformService" />
    public PlatformService(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<Platform>> GetPlatformsAsync()
    {
        return await this.unitOfWork.Platforms.GetAllAsync();
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