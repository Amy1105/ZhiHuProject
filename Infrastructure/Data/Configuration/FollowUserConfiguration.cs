using Core.AppUserAggregate.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configuration
{
    internal class FollowUserConfiguration : IEntityTypeConfiguration<FollowUser>
    {
        public void Configure(EntityTypeBuilder<FollowUser> builder)
        {
            builder.HasIndex(i => new { i.FollowerId, i.FolloweeId }).IsUnique();

            builder.HasOne(p => p.Follower).WithMany(x => x.Followees).HasForeignKey(f => f.FollowerId)
                .IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(f=>f.Followee).WithMany(x=>x. Followers).HasForeignKey(f => f.FolloweeId)
                .IsRequired().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
