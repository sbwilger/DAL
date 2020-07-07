using System;
using System.Collections.Generic;
using System.Text;

namespace sbwilger.DAL.Models.Profiles
{
    public class Profile : Entity
    {
        public ulong DiscordId { get; set; }
        public ulong GuildId { get; set; }
        public int Exp { get; set; }
        public int ExpToLevel { get; set; }

        public int Level { get; set; }
    }
}
