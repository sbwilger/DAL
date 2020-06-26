using Microsoft.EntityFrameworkCore;
using sbwilger.DAL.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Serana Wilger
/// 06/26/2020
/// RPGContext.cs
/// 
/// Database storage for the RPG
/// </summary>

namespace sbwilger.DAL
{
    public class RPGContext : DbContext
    {
        public RPGContext(DbContextOptions<RPGContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}
