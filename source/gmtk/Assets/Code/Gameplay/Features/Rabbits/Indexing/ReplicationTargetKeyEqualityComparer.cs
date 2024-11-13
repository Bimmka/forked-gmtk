﻿using System;
using System.Collections.Generic;

namespace Code.Gameplay.Features.Rabbits.Indexing
{
    public class ReplicationTargetKeyEqualityComparer : IEqualityComparer<ReplicationTargetKey>
    {
        public bool Equals(ReplicationTargetKey x, ReplicationTargetKey y)
        {
            return x.StallIndex == y.StallIndex;
        }

        public int GetHashCode(ReplicationTargetKey obj)
        {
            return HashCode.Combine(obj.StallIndex);
        }
    }
}