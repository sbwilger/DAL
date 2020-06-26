using System;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Serana Wilger
/// 06/26/2020
/// Entity.cs
/// 
/// The abstract class for Database Entities
/// </summary>

namespace sbwilger.DAL
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
