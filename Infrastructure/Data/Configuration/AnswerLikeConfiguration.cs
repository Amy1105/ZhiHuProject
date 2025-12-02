using Core.QuestionAggregate.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configuration
{
    internal class AnswerLikeConfiguration : IEntityTypeConfiguration<AnswerLike>
    {
        public void Configure(EntityTypeBuilder<AnswerLike> builder)
        {
            builder.HasIndex(a => new { a.AnswerId, a.UserId }).IsUnique();

            builder.HasOne(a => a.Answer).WithMany(a => a.AnswerLikes).HasForeignKey(a => a.AnswerId)
                .IsRequired().OnDelete(DeleteBehavior.NoAction); ;
        }
    }
}
