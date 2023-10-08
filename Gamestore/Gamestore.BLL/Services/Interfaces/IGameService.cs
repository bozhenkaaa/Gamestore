// <copyright file="IGameService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.BLL.Services.Interfaces;

using Gamestore.BLL.DTOs;

/// <inheritdoc cref="IGameService" />
public interface IGameService
{
    /// <inheritdoc cref="GetGamesAsync" />
    Task<IEnumerable<GameDto>> GetGamesAsync();

    /// <inheritdoc cref="GetGameAsync" />
    Task<GameDto> GetGameAsync(int id);

    /// <inheritdoc cref="AddGameAsync" />
    Task AddGameAsync(GameDto author);

    /// <inheritdoc cref="UpdateGameAsync" />
    Task UpdateGameAsync(GameDto author);

    /// <inheritdoc cref="DeleteGameAsync" />
    Task DeleteGameAsync(int id);
}