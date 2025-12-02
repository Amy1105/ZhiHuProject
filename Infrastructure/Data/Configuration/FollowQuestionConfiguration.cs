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
    internal class FollowQuestionConfiguration : IEntityTypeConfiguration<FollowQuestion>
    {
        public void Configure(EntityTypeBuilder<FollowQuestion> builder)
        {
            builder.HasIndex(i => new { i.UserId, i.QuestionId }).IsUnique();
            builder.HasOne(i=>i.AppUser).WithMany(m=>m.FollowQuestions).HasForeignKey(i=>i.UserId).IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
