using System;
using System.Collections.Generic;
using System.Text;

namespace sbwilger.DAL.Models.Items
{
    class Ingredient : Item
    {
        public PotionEffect[] effects = new PotionEffect[4];
    }
}
