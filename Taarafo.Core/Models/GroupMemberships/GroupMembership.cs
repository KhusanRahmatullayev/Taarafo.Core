﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;
using Taarafo.Core.Models.Groups;
using Taarafo.Core.Models.Profiles;

namespace Taarafo.Core.Models.GroupMemberships
{
    public class GroupMembership
    {
        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }

        public Guid GroupId { get; set; }
        public Group Group { get; set; }

        public GroupMembershipStatus Status { get; set; }
        public DateTimeOffset MembershipDate { get; set; }
    }
}
