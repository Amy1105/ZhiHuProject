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
    /// <summary>
    /// 写成class而不是直接字段上使用属性注解的好处是什么？to do...
    /// </summary>
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.Property(p => p.Content).HasColumnType("text").IsRequired();

            //这里写明外键，和类中直接设置导航属性有什么区别，设置了导航属性，这里还需写一对多关系，标明外键吗？ to do...
            builder.HasOne(a => a.Question).WithMany(q => q.Answers).HasForeignKey(a => a.QuestionId).IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
