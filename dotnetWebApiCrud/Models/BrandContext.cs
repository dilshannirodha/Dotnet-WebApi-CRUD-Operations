﻿using Microsoft.EntityFrameworkCore;

namespace dotnetWebApiCrud.Models
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options) :base(options)
        {
            
        }
        public DbSet<Brand> Brands { get; set; }
    }
}
