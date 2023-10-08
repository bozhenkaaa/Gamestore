// <copyright file="ApplicationProfile.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.BLL.Profiles;

using Gamestore.BLL.DTOs;
using Gamestore.Models.Models;

/// <inheritdoc/>
public class ApplicationProfile : AutoMapper.Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApplicationProfile"/> class.
    /// </summary>
    public ApplicationProfile()
    {
        this.CreateMap<Game, GameDto>().ReverseMap();

        this.CreateMap<Genre, GenreDTO>().ReverseMap();

        this.CreateMap<Platform, PlatformDTO>().ReverseMap();
    }
}