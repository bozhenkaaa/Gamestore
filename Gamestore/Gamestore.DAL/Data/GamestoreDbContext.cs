// <copyright file="GamestoreDbContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Gamestore.DAL.Data;

using Gamestore.Models.Models;
using Microsoft.EntityFrameworkCore;

/// <inheritdoc cref="GamestoreDbContext" />
public class GamestoreDbContext : DbContext
{
    /// <inheritdoc cref="GamestoreDbContext" />
    public GamestoreDbContext(DbContextOptions<GamestoreDbContext> options)
        : base(options)
    {
    }

    /// <inheritdoc cref="Games" />
    public DbSet<Game> Games { get; set; } = null!;

    /// <inheritdoc cref="Genres" />
    public DbSet<Genre> Genres { get; set; } = null!;

    /// <inheritdoc cref="Platforms" />
    public DbSet<Platform> Platforms { get; set; } = null!;

    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>()
            .HasKey(b => b.Id);

        modelBuilder.Entity<Genre>()
            .HasKey(b => b.Id);

        modelBuilder.Entity<Platform>()
            .HasKey(b => b.Id);

        modelBuilder.Entity<Game>()
            .HasOne(g => g.Genre)
            .WithMany(g => g.Games)
            .HasForeignKey(g => g.GenreId);

        modelBuilder.Entity<Game>()
            .HasOne(p => p.Platform)
            .WithMany(g => g.Games)
            .HasForeignKey(g => g.PlatformId);

        modelBuilder.Entity<Genre>()
            .HasOne(g => g.ParentGenre)
            .WithMany(g => g.SubGenres)
            .HasForeignKey(g => g.ParentGenreId);

        modelBuilder.Entity<Genre>()
            .HasMany(g => g.Games)
            .WithOne(g => g.Genre)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Platform>()
            .HasMany(g => g.Games)
            .WithOne(g => g.Platform)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Game>()
            .HasIndex(g => g.GameAlias)
            .IsUnique();

        modelBuilder.Entity<Platform>()
            .HasIndex(p => p.Type)
            .IsUnique();

        modelBuilder.Entity<Genre>().HasData(
            new Genre { Id = 1, Name = "Strategy" },
            new Genre { Id = 2, Name = "RPG" },
            new Genre { Id = 3, Name = "Sports" },
            new Genre { Id = 4, Name = "Races" },
            new Genre { Id = 5, Name = "Action" },
            new Genre { Id = 6, Name = "Adventure" },
            new Genre { Id = 7, Name = "Puzzle & Skill" },
            new Genre { Id = 8, Name = "Misc" });

        // Nested genres for "Strategy" (Id = 1)
        modelBuilder.Entity<Genre>().HasData(
            new Genre { Id = 9, Name = "RTS", ParentGenreId = 1 },
            new Genre { Id = 10, Name = "TBS", ParentGenreId = 1 });

        modelBuilder.Entity<Genre>().HasData(
            new Genre { Id = 11, Name = "Rally", ParentGenreId = 4 },
            new Genre { Id = 12, Name = "Arcade", ParentGenreId = 4 },
            new Genre { Id = 13, Name = "Formula", ParentGenreId = 4 },
            new Genre { Id = 14, Name = "Off-road", ParentGenreId = 4 });

        // Nested genres for "Action" (Id = 5)
        modelBuilder.Entity<Genre>().HasData(
            new Genre { Id = 15, Name = "FPS", ParentGenreId = 5 },
            new Genre { Id = 16, Name = "TPS", ParentGenreId = 5 });

        // Seed predefined platforms
        modelBuilder.Entity<Platform>().HasData(
            new Platform { Id = 1, Type = "Mobile" },
            new Platform { Id = 2, Type = "Browser" },
            new Platform { Id = 3, Type = "Desktop" },
            new Platform { Id = 4, Type = "Console" });
    }
}