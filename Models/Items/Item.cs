using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Serana Wilger
/// 06/26/2020
/// Item.cs
/// 
/// A class for handling RPG items
/// </summary>

namespace sbwilger.DAL.Models.Items
{
    public class Item : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public BaseStats AttackStat { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Price { get; set; }
    }
}
