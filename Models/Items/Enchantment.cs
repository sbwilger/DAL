using System;
using System.Collections.Generic;
using System.Text;

namespace sbwilger.DAL.Models.Items
{
    public enum EnchantmentTypes
    {

    }
    public struct Enchantment
    {
        public EnchantmentTypes EnchantmentType { get; set; }
        public int Potency { get; set; }
        public int Duration { get; set; }
    }
}
