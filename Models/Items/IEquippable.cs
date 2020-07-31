using System;
using System.Collections.Generic;
using System.Text;

namespace sbwilger.DAL.Models.Items
{
    public interface IEquippable
    {
        public bool equipped { get; set; }
    }
}
