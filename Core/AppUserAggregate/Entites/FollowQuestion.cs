using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.AppUserAggregate.Entites
{
    public  class FollowQuestion:BaseEntity
    {
        public int UserId { get; set; }
        public AppUser AppUser { get; set; } = null!;

        public int QuestionId { get; set; }

        public DateTimeOffset FollowDate { get; set; }
    }
}
