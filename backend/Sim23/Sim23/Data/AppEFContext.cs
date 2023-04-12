﻿using Microsoft.EntityFrameworkCore;
using Sim23.Data.Entities;

namespace Sim23.Data
{
    public class AppEFContext : DbContext
    {
        public AppEFContext(DbContextOptions<AppEFContext> options)
            : base(options)
        {
            
        }

        public DbSet<CategoryEntity> Categories { get; set; }
    }
}

