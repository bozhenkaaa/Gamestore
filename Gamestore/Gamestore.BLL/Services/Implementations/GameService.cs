// <copyright file="GameService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.BLL.Services.Implementations;

using Gamestore.BLL.DTOs;
using Gamestore.BLL.Services.Interfaces;

/// <inheritdoc />
public class GameService : IGameService
{
    /// <inheritdoc/>
    public Task<IEnumerable<GameDto>> GetGamesAsync()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task<GameDto> GetGameAsync(int id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task AddGameAsync(GameDto author)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task UpdateGameAsync(GameDto author)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Task DeleteGameAsync(int id)
    {
        throw new NotImplementedException();
    }
}