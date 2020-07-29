using System;
using System.Collections.Generic;
using System.Text;

namespace sbwilger.DAL.Models.Items
{
    public enum PotionEffects
    {
        Cure_Disease,
        Damage_Health,
        Damage_Mana,
        Damage_Mana_Regen,
        Damage_Stamina,
        Damage_Stamina_Regen,
        Fear,
        Fortify_Alteration,
        Fortify_Barter,
        Fortify_Block,
        Fortify_Carry_Weight,
        Fortify_Conjuration,
        Fortify_Destruction,
        Fortify_Enchanting,
        Fortify_Health,
        Fortify_Heavy_Armour,
        Fortify_Illusion,
        Fortify_Light_Armour,
        Fortify_Lockpicking,
        Fortify_Mana,
        Fortify_Marksman,
        Fortify_One_Handed,
        Fortify_Pickpocket,
        Fortify_Restoration,
        Fortify_Smithing,
        Fortify_Sneak,
        Fortify_Stamina,
        Fortify_Two_Handed,
        Frenzy,
        Invisibility,
        Lingering_Damage_Health,
        Lingering_Damage_Mana,
        Lingering_Damage_Stamina,
        Paralysis,
        Ravage_Health,
        Ravage_Mana,
        Ravage_Stamina,
        Regenerate_Health,
        Regenerate_Magicka,
        Regenerate_Stamina,
        Resist_Fire,
        Resist_Frost,
        Resist_Magic,
        Resist_Poison,
        Resist_Shock,
        Restore_Health,
        Restore_Mana,
        Restore_Stamina,
        Slow,
        Waterbreathing,
        Weakness_to_Fire,
        Weakness_to_Frost,
        Weakness_to_Magic,
        Weakness_to_Poison,
        Weakness_to_Shock
    }
}

public class PotionEffect
{
    public float BaseCost { get; set; }
    public int Base_Potency { get; set; }
    public int Base_Duration { get; set; }
}
