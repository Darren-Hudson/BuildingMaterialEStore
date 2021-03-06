﻿using BmesRestApi.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace BmesRestApi.Database
{
    public class BmesDbContext : DbContext
    {
        public BmesDbContext(DbContextOptions<BmesDbContext> Options) : base(Options) {}
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
