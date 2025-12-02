using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.AppUserAggregate.Entites
{
    public  class FollowUser:BaseEntity
    {
        public int FollowerId { get; set; }

        public AppUser Follower { get; set; } = null!;

        public int FolloweeId { get; set; }

        public AppUser Followee { get; set; } = null!;

        public DateTimeOffset  FollowDate { get; set; }

    }
}
