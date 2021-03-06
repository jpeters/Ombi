﻿using System.Collections.Generic;

namespace Ombi.Settings.Settings.Models
{
    public class UserManagementSettings : Settings
    {
        public bool ImportPlexUsers { get; set; }
        public bool ImportEmbyUsers { get; set; }
        public List<string> DefaultRoles { get; set; } = new List<string>();
        public List<string> BannedPlexUserIds { get; set; } = new List<string>();
        public List<string> BannedEmbyUserIds { get; set; } = new List<string>();
    }
}