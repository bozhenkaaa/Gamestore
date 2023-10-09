// <copyright file="PlatformsController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.Controllers;

using Gamestore.BLL.DTOs;
using Gamestore.BLL.Services.Interfaces;
using Gamestore.Models.Models;
using Microsoft.AspNetCore.Mvc;

/// <inheritdoc />
[ApiController]
[Route("api/[controller]")]
public class PlatformsController : ControllerBase
{
    private readonly IPlatformService platformService;

    /// <inheritdoc cref="PlatformsController" />
    public PlatformsController(IPlatformService platformService)
    {
        this.platformService = platformService;
    }

    /// <inheritdoc cref="GetPlatformsAsync" />
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PlatformDTO>>> GetPlatformsAsync()
    {
        var authors = await this.platformService.GetPlatformsAsync();
        return this.Ok(authors);
    }
}